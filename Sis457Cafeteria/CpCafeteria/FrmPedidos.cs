using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CadCafeteria;
using ClnCafeteria;
using System.ComponentModel;
using System.Text;

namespace CpCafeteria
{
    public partial class FrmPedidos : Form
    {
        private List<DetallePedido> detalles = new List<DetallePedido>();
        private Cliente clienteSeleccionado = null;
        private System.Windows.Forms.Timer catalogoSearchTimer;
        private const int CATALOGO_SEARCH_DELAY = 300;
        private bool _construyendoCatalogo = false;

        public FrmPedidos()
        {
            InitializeComponent();
            // Garantiza que el Load se ejecute aunque no esté asignado en el diseñador
            this.Load += FrmPedido_Load;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            txtNombreCliente.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtCambio.ReadOnly = true;
            dgvDetallePedido.AutoGenerateColumns = false;
            ConfigurarDgvDetalle();
            LimpiarFormulario();

            // Suscribir búsqueda (asegúrate de crear un TextBox llamado txtBuscarProducto en el diseñador)
            if (txtBuscarProducto != null)
                txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;

            ConstruirCatalogoProductos(); // Carga el catálogo visual
        }

        private string Trunc(string txt, int len)
        {
            if (string.IsNullOrEmpty(txt)) return "";
            if (txt.Length <= len) return txt;
            return txt.Substring(0, len - 1) + "…";
        }

        private bool ConfirmarResumenPedido()
        {
            // Asegurar sincronización por si hubo cambios en catálogo
            SincronizarDetallesDesdeCatalogo();

            decimal total = detalles.Sum(d => d.total);
            decimal efectivo = 0;
            decimal.TryParse(txtEfectivo.Text, out efectivo);

            var sb = new StringBuilder();
            sb.AppendLine("Cliente: " + clienteSeleccionado.nombres + " " +
                          clienteSeleccionado.apellidos + " (" + clienteSeleccionado.cedulaIdentidad + ")");
            sb.AppendLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine();
            sb.AppendLine("Detalle:");
            sb.AppendLine("Cant  Producto                    P.Unit   Importe");
            foreach (var d in detalles)
            {
                var prod = d.Producto ?? ProductoCln.obtenerUno(d.idProducto);
                string nombre = prod != null ? prod.nombre : "(?)";
                sb.AppendLine($"{d.cantidad,4}  {Trunc(nombre, 25),-25} {d.precioUnitario,7:0.00} {d.total,8:0.00}");
            }
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine($"TOTAL:    {total:0.00}");
            sb.AppendLine($"EFECTIVO: {efectivo:0.00}");
            sb.AppendLine($"CAMBIO:   {(efectivo - total):0.00}");
            sb.AppendLine();
            sb.AppendLine("¿Confirmar y guardar el pedido?");

            var dr = MessageBox.Show(sb.ToString(), "Confirmar Pedido",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }

        // 3. Agrega el manejador con retraso (debounce) para evitar reconstruir en cada pulsación:
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (catalogoSearchTimer != null)
            {
                catalogoSearchTimer.Stop();
                catalogoSearchTimer.Tick -= CatalogoSearchTimer_Tick;
                catalogoSearchTimer.Dispose();
                catalogoSearchTimer = null;
            }

            catalogoSearchTimer = new Timer();
            catalogoSearchTimer.Interval = CATALOGO_SEARCH_DELAY;
            catalogoSearchTimer.Tick += CatalogoSearchTimer_Tick;
            catalogoSearchTimer.Start();
        }

        private void CatalogoSearchTimer_Tick(object sender, EventArgs e)
        {
            catalogoSearchTimer.Stop();
            catalogoSearchTimer.Tick -= CatalogoSearchTimer_Tick;
            catalogoSearchTimer.Dispose();
            catalogoSearchTimer = null;
            AplicarFiltroCatalogo();
        }


        // 6. (Opcional) En FormClosing si deseas limpiar el timer:
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (catalogoSearchTimer != null)
            {
                catalogoSearchTimer.Stop();
                catalogoSearchTimer.Tick -= CatalogoSearchTimer_Tick;
                catalogoSearchTimer.Dispose();
                catalogoSearchTimer = null;
            }
            base.OnFormClosing(e);
        }

        private void ConfigurarDgvDetalle()
        {
            dgvDetallePedido.Columns.Clear();

            var colNombre = new DataGridViewTextBoxColumn
            {
                Name = "nombreProducto",
                HeaderText = "Producto",
                DataPropertyName = "nombreProducto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            var colCantidad = new DataGridViewTextBoxColumn
            {
                Name = "cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "cantidad",
                Width = 80
            };
            var colPrecio = new DataGridViewTextBoxColumn
            {
                Name = "precioUnitario",
                HeaderText = "Precio Unitario",
                DataPropertyName = "precioUnitario",
                Width = 110,
                DefaultCellStyle = { Format = "0.00" }
            };
            var colTotal = new DataGridViewTextBoxColumn
            {
                Name = "total",
                HeaderText = "Total",
                DataPropertyName = "total",
                Width = 110,
                DefaultCellStyle = { Format = "0.00" }
            };

            dgvDetallePedido.Columns.AddRange(colNombre, colCantidad, colPrecio, colTotal);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string criterio = txtCedulaCliente.Text.Trim();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese CI, nombre o apellido para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCliente.Clear();
                clienteSeleccionado = null;
                return;
            }

            var coincidencias = ClientesCln.listarPa(criterio);

            if (coincidencias == null || coincidencias.Count == 0)
            {
                txtNombreCliente.Clear();
                clienteSeleccionado = null;
                MessageBox.Show("Cliente no encontrado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coincidencia exacta de CI
            var exactaCedula = coincidencias
                .FirstOrDefault(c => !string.IsNullOrEmpty(c.cedulaIdentidad) &&
                                     c.cedulaIdentidad.Equals(criterio, StringComparison.OrdinalIgnoreCase));

            var seleccionado = exactaCedula ?? coincidencias.First();

            // Mapear resultado del procedimiento a entidad Cliente (sin otro acceso a BD)
            clienteSeleccionado = new Cliente
            {
                id = seleccionado.id,
                cedulaIdentidad = seleccionado.cedulaIdentidad,
                nombres = seleccionado.nombres,
                apellidos = seleccionado.apellidos,
                usuarioRegistro = seleccionado.usuarioRegistro,
                fechaRegistro = seleccionado.fechaRegistro,
                estado = seleccionado.estado
            };

            txtNombreCliente.Text = clienteSeleccionado.nombres + " " + clienteSeleccionado.apellidos;

            if (exactaCedula == null && coincidencias.Count > 1)
            {
                MessageBox.Show($"Se encontraron {coincidencias.Count} coincidencias. Se seleccionó la primera. Refine la búsqueda si necesita otro cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Manejador: dispara la búsqueda al presionar Enter en txtCedulaCliente
        private void txtCedulaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el beep y el salto de línea
                btnBuscarCliente.PerformClick();
            }
        }

        // Botón para crear un nuevo cliente desde el pedido
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAgregarClienteRapido())
            {
                var dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK && frm.ClienteCreado != null)
                {
                    clienteSeleccionado = frm.ClienteCreado;
                    txtCedulaCliente.Text = clienteSeleccionado.cedulaIdentidad;
                    txtNombreCliente.Text = clienteSeleccionado.nombres + " " + clienteSeleccionado.apellidos;
                }
            }
        }

        // Mantener botón existente para selección clásica (opcional)
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frm = new FrmSeleccionarProducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var detalle = frm.DetalleSeleccionado;
                if (detalle != null)
                {
                    var existente = detalles.FirstOrDefault(d => d.idProducto == detalle.idProducto);
                    if (existente != null)
                    {
                        var producto = ProductoCln.obtenerUno(existente.idProducto);
                        int nuevaCantidad = existente.cantidad + detalle.cantidad;
                        if (nuevaCantidad > (int)producto.saldo)
                        {
                            MessageBox.Show("La suma excede el stock disponible.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        existente.cantidad = nuevaCantidad;
                        existente.total = existente.cantidad * existente.precioUnitario;
                    }
                    else
                    {
                        detalles.Add(detalle);
                    }
                    RefrescarDetalle();
                }
            }
        }

        private void RefrescarDetalle()
        {
            dgvDetallePedido.DataSource = null;
            dgvDetallePedido.DataSource = detalles.Select(d => new
            {
                nombreProducto = d.Producto != null ? d.Producto.nombre : ProductoCln.obtenerUno(d.idProducto).nombre,
                cantidad = d.cantidad,
                precioUnitario = d.precioUnitario,
                total = d.total
            }).ToList();

            txtTotal.Text = detalles.Sum(d => d.total).ToString("0.00");
            CalcularCambio();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal total = 0, efectivo = 0;
            decimal.TryParse(txtTotal.Text, out total);
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            txtCambio.Text = (efectivo - total).ToString("0.00");
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            SincronizarDetallesDesdeCatalogo();

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (detalles.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = detalles.Sum(d => d.total);
            decimal efectivo = 0;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            if (efectivo < total)
            {
                MessageBox.Show("El efectivo no puede ser menor al total.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar resumen y confirmar
            if (!ConfirmarResumenPedido())
                return;

            // Persistencia real
            var pedido = new Pedido
            {
                idCliente = clienteSeleccionado.id,
                idUsuario = Util.usuario.id,
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };
            int idPedido = PedidoCln.insertar(pedido);

            foreach (var det in detalles)
            {
                det.idPedido = idPedido;
                det.usuarioRegistro = Util.usuario.usuario1;
                det.fechaRegistro = DateTime.Now;
                det.estado = 1;
                DetallePedidoCln.insertar(det);

                var producto = ProductoCln.obtenerUno(det.idProducto);
                producto.saldo -= det.cantidad;
                ProductoCln.actualizar(producto);
            }

            MessageBox.Show("Venta registrada correctamente", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
            ConstruirCatalogoProductos();
        }

        private void LimpiarFormulario()
        {
            txtCedulaCliente.Clear();
            txtNombreCliente.Clear();
            detalles.Clear();
            RefrescarDetalle();
            txtEfectivo.Clear();
            txtCambio.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            clienteSeleccionado = null;
            ConstruirCatalogoProductos();
        }

        private void AplicarFiltroCatalogo()
        {
            ConstruirCatalogoProductos();
        }


        // Reemplaza TODO el método ConstruirCatalogoProductos por este
        // Reemplaza el método ConstruirCatalogoProductos por esta versión (añade llamada a ReordenarTodosCardsSegunCantidad)
        private void ConstruirCatalogoProductos()
        {
            if (flpCatalogoProductos == null) return;

            string filtro = txtBuscarProducto != null ? txtBuscarProducto.Text.Trim() : "";
            filtro = filtro ?? "";

            _construyendoCatalogo = true;
            flpCatalogoProductos.SuspendLayout();
            try
            {
                flpCatalogoProductos.Controls.Clear();

                var productos = ProductoCln.listar();

                if (productos == null || productos.Count == 0)
                {
                    var listaPa = ProductoCln.listarPa(filtro);
                    if (listaPa != null && listaPa.Count > 0)
                    {
                        productos = listaPa
                            .Select(x => ProductoCln.obtenerUno(x.id))
                            .Where(x => x != null && x.estado != -1)
                            .ToList();
                    }
                }

                if (productos != null)
                {
                    if (!(productos.Count > 0 && filtro.Length == 0))
                    {
                        productos = productos
                            .Where(p =>
                                string.IsNullOrEmpty(filtro) ||
                                (p.nombre != null && p.nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                (p.codigo != null && p.codigo.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                (p.descripcion != null && p.descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                            .ToList();
                    }
                }

                if (productos != null && productos.Count > 0)
                {
                    foreach (var p in productos.OrderBy(p => p.nombre))
                    {
                        var card = CrearCardProducto(p);
                        flpCatalogoProductos.Controls.Add(card);

                        // Restaurar cantidad (dispara ValueChanged pero el flag evita reordenamiento por evento)
                        var existente = detalles.FirstOrDefault(d => d.idProducto == p.id);
                        if (existente != null)
                        {
                            var nud = card.Controls.OfType<NumericUpDown>().FirstOrDefault();
                            if (nud != null)
                            {
                                int safeCantidad = Math.Min(existente.cantidad, (int)p.saldo);
                                nud.Value = safeCantidad;
                            }
                        }
                    }

                    // Ahora sí, reordenar todos juntos (los con cantidad > 0 arriba)
                    ReordenarTodosCardsSegunCantidad();
                }
                else
                {
                    var lbl = new Label
                    {
                        Text = "No hay productos para mostrar.",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        ForeColor = Color.DimGray
                    };
                    flpCatalogoProductos.Controls.Add(lbl);
                }
            }
            finally
            {
                _construyendoCatalogo = false;
                flpCatalogoProductos.ResumeLayout();
            }
        }

        private Control CrearCardProducto(Producto p)
        {
            var panel = new Panel
            {
                Width = 160,
                Height = 230,
                BackColor = Color.White,
                Margin = new Padding(8),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = p.id
            };

            var pb = new PictureBox
            {
                Width = 140,
                Height = 120,
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Gainsboro
            };
            CargarImagenProducto(p, pb);

            var lblNombre = new Label
            {
                Text = p.nombre,
                Location = new Point(10, 135),
                Width = 140,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                AutoSize = false
            };

            // AJUSTE: ancho completo y traer al frente para que no quede tapado
            var lblPrecio = new Label
            {
                Name = "lblPrecio",
                Text = "Precio: " + p.precioVenta.ToString("0.00"),
                Location = new Point(10, 155),
                Width = 140,                 // antes 75
                Height = 18,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft
            };

            int maxCantidad = (int)Math.Max(0, Math.Min((double)p.saldo, int.MaxValue));
            var nudCantidad = new NumericUpDown
            {
                Minimum = 0,
                Maximum = maxCantidad,
                Value = 0,
                Width = 60,
                Location = new Point(10, 180),
                Font = new Font("Segoe UI", 9),
                Tag = p.id,
                ReadOnly = true
            };
            nudCantidad.ValueChanged += NudCantidad_ValueChanged;

            // Stock a la derecha del NumericUpDown
            var lblStock = new Label
            {
                Text = "Stock: " + p.saldo,
                AutoSize = true,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray
            };
            int spacing = 8;
            lblStock.Location = new Point(nudCantidad.Left + nudCantidad.Width + spacing, nudCantidad.Top + 3);

            if (lblStock.Location.X + lblStock.PreferredWidth > panel.Width - 10)
            {
                lblStock.AutoSize = false;
                lblStock.Width = Math.Max(0, panel.Width - 10 - lblStock.Location.X);
                lblStock.Height = nudCantidad.Height;
                lblStock.TextAlign = ContentAlignment.MiddleLeft;
            }

            panel.Controls.Add(pb);
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(nudCantidad);
            panel.Controls.Add(lblStock);

            // Garantiza que el precio quede visible encima de otros controles
            lblPrecio.BringToFront();

            return panel;
        }

        private void NudCantidad_Validating(object sender, CancelEventArgs e)
        {
            var nud = sender as NumericUpDown;
            if (nud == null) return;

            int idProducto = (int)nud.Tag;
            var producto = ProductoCln.obtenerUno(idProducto);
            if (producto == null) return;

            int typed;
            // Tomar lo escrito (texto) para validar contra stock
            if (!int.TryParse(nud.Text, out typed))
                typed = (int)nud.Value;

            int stock = (int)producto.saldo;
            if (typed > stock)
            {
                MessageBox.Show("La suma excede el stock disponible.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Ajusta al stock y dispara ValueChanged para sincronizar 'detalles' y total
                nud.Value = stock;
                // No cancelamos porque ya corregimos el valor
                // e.Cancel = true; // si prefieres que permanezca el foco, descomenta esta línea
            }
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            var nud = sender as NumericUpDown;
            if (nud == null) return;

            int idProducto = (int)nud.Tag;
            int cantidad = (int)nud.Value;

            var producto = ProductoCln.obtenerUno(idProducto);
            if (producto == null) return;

            int stock = (int)producto.saldo;
            if (cantidad > stock)
            {
                MessageBox.Show("La suma excede el stock disponible.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud.Value = stock;
                cantidad = stock;
            }

            var existente = detalles.FirstOrDefault(d => d.idProducto == idProducto);

            if (cantidad <= 0)
            {
                if (existente != null)
                    detalles.Remove(existente);
            }
            else
            {
                if (existente == null)
                {
                    detalles.Add(new DetallePedido
                    {
                        idProducto = idProducto,
                        cantidad = cantidad,
                        precioUnitario = producto.precioVenta,
                        total = cantidad * producto.precioVenta
                    });
                }
                else
                {
                    existente.cantidad = cantidad;
                    existente.precioUnitario = producto.precioVenta;
                    existente.total = cantidad * producto.precioVenta;
                }
            }

            RefrescarDetalle();

            // NUEVO: mover el card (panel) a arriba si cantidad > 0, o al final si vuelve a 0
            ReordenarCardPorCantidad(nud);
        }

        // Reemplaza TODO el método ReordenarCardPorCantidad por este
        private void ReordenarCardPorCantidad(NumericUpDown nud)
        {
            if (_construyendoCatalogo) return; // no reordenar mientras se construye/filtra
            if (flpCatalogoProductos == null || nud == null) return;

            var card = nud.Parent as Control;
            if (card == null) return;

            // Asegura que el 'card' es realmente hijo del FlowLayoutPanel antes de reordenar
            if (!ReferenceEquals(card.Parent, flpCatalogoProductos) || !flpCatalogoProductos.Controls.Contains(card))
                return;

            flpCatalogoProductos.SuspendLayout();
            try
            {
                if (nud.Value > 0)
                    flpCatalogoProductos.Controls.SetChildIndex(card, 0);
                else
                    flpCatalogoProductos.Controls.SetChildIndex(card, flpCatalogoProductos.Controls.Count - 1);
            }
            finally
            {
                flpCatalogoProductos.ResumeLayout();
            }
        }

        // NUEVO: reordenar todos los cards (los que tienen cantidad > 0 arriba)
        private void ReordenarTodosCardsSegunCantidad()
        {
            if (flpCatalogoProductos == null) return;

            // Obtener en el orden actual los que tienen cantidad > 0
            var seleccionados = flpCatalogoProductos.Controls.Cast<Control>()
                .Where(c =>
                {
                    var nud = c.Controls.OfType<NumericUpDown>().FirstOrDefault();
                    return nud != null && nud.Value > 0;
                })
                .ToList();

            if (seleccionados.Count == 0) return;

            flpCatalogoProductos.SuspendLayout();
            try
            {
                // Movimiento estable: recorremos en reversa y ponemos cada uno en índice 0
                // Así se mantiene su orden relativo original.
                foreach (var card in seleccionados.AsEnumerable().Reverse())
                    flpCatalogoProductos.Controls.SetChildIndex(card, 0);
            }
            finally
            {
                flpCatalogoProductos.ResumeLayout();
            }
        }

        private void NudCantidad_Leave(object sender, EventArgs e)
        {
            var nud = sender as NumericUpDown;
            if (nud == null) return;

            int idProducto = (int)nud.Tag;
            var producto = ProductoCln.obtenerUno(idProducto);
            if (producto == null) return;

            int typed;
            if (int.TryParse(nud.Text, out typed))
            {
                int stock = (int)producto.saldo;
                if (typed > stock)
                {
                    MessageBox.Show("La suma excede el stock disponible.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nud.Value = stock; // esto disparará NudCantidad_ValueChanged y actualizará el total
                }
            }
        }

        private void SincronizarDetallesDesdeCatalogo()
        {
            if (flpCatalogoProductos == null) return;

            var nuevos = new List<DetallePedido>();
            foreach (Control card in flpCatalogoProductos.Controls)
            {
                var nud = card.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (nud == null) continue;

                int cantidad = (int)nud.Value;
                if (cantidad <= 0) continue;

                int idProducto = (int)nud.Tag;
                var producto = ProductoCln.obtenerUno(idProducto);
                if (producto == null) continue;

                int stock = (int)producto.saldo;
                if (cantidad > stock) cantidad = stock; // seguridad

                nuevos.Add(new DetallePedido
                {
                    idProducto = idProducto,
                    cantidad = cantidad,
                    precioUnitario = producto.precioVenta,
                    total = cantidad * producto.precioVenta
                });
            }

            detalles = nuevos;
            RefrescarDetalle();
        }



        private void CargarImagenProducto(Producto p, PictureBox pb)
        {
            try
            {
                var baseDir = Path.Combine(Application.StartupPath, "ImagesProductos");
                string[] extensiones = { ".jpg", ".png", ".jpeg" };

                // 1) Buscar por ID (recomendado)
                string ruta = extensiones
                    .Select(ext => Path.Combine(baseDir, p.id.ToString() + ext))
                    .FirstOrDefault(File.Exists);

                // 2) Respaldo: buscar por código si existe
                if (ruta == null && !string.IsNullOrWhiteSpace(p.codigo))
                {
                    ruta = extensiones
                        .Select(ext => Path.Combine(baseDir, p.codigo + ext))
                        .FirstOrDefault(File.Exists);
                }

                if (ruta != null)
                {
                    using (var tmp = Image.FromFile(ruta))
                    {
                        pb.Image = new Bitmap(tmp);
                    }
                    pb.BackColor = Color.White;
                }
                else
                {
                    // Sin imagen: dejamos el fondo gris
                    pb.Image = null;
                    pb.BackColor = Color.Gainsboro;
                }
            }
            catch
            {
                // Evitar romper flujo si la imagen falla
            }
        }

        private void BtnAgregarProductoCatalogo_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag is Tuple<int, NumericUpDown>)
            {
                var data = (Tuple<int, NumericUpDown>)btn.Tag;
                int idProducto = data.Item1;
                var nud = data.Item2;
                int cantidad = (int)nud.Value;

                var producto = ProductoCln.obtenerUno(idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cantidad > (int)producto.saldo)
                {
                    MessageBox.Show("Cantidad supera el stock disponible.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AgregarDetalleProducto(producto, cantidad);
            }
        }

        private void AgregarDetalleProducto(Producto producto, int cantidad)
        {
            var existente = detalles.FirstOrDefault(d => d.idProducto == producto.id);
            if (existente != null)
            {
                int nuevaCantidad = existente.cantidad + cantidad;
                if (nuevaCantidad > (int)producto.saldo)
                {
                    MessageBox.Show("La suma excede el stock.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.cantidad = nuevaCantidad;
                existente.total = existente.cantidad * existente.precioUnitario;
            }
            else
            {
                detalles.Add(new DetallePedido
                {
                    idProducto = producto.id,
                    cantidad = cantidad,
                    precioUnitario = producto.precioVenta,
                    total = cantidad * producto.precioVenta
                });
            }

            RefrescarDetalle();
        }
    }
}