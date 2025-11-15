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

namespace CpCafeteria
{
    public partial class FrmPedidos : Form
    {
        private List<DetallePedido> detalles = new List<DetallePedido>();
        private Cliente clienteSeleccionado = null;

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
            ConstruirCatalogoProductos(); // Carga el catálogo visual
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
            string cedula = txtCedulaCliente.Text.Trim();
            clienteSeleccionado = ClientesCln.listar().FirstOrDefault(c => c.cedulaIdentidad == cedula);
            if (clienteSeleccionado != null)
                txtNombreCliente.Text = clienteSeleccionado.nombres + " " + clienteSeleccionado.apellidos;
            else
            {
                txtNombreCliente.Clear();
                MessageBox.Show("Cliente no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Forzar validación de todos los NumericUpDown (dispara Validating)
            if (!ValidateChildren()) return;

            // Asegurar que 'detalles' refleje lo escrito en los NumericUpDown
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

            MessageBox.Show("Venta registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // =========================
        // Catálogo visual de productos
        // =========================
        private void ConstruirCatalogoProductos()
        {
            if (flpCatalogoProductos == null) return;

            flpCatalogoProductos.SuspendLayout();
            flpCatalogoProductos.Controls.Clear();

            // 1) Intento principal via EF
            var productos = ProductoCln.listar();

            // 2) Fallback: si no hay productos, intento vía SP y mapeo
            if (productos == null || productos.Count == 0)
            {
                var listaPa = ProductoCln.listarPa("");
                if (listaPa != null && listaPa.Count > 0)
                {
                    productos = listaPa
                        .Select(x => ProductoCln.obtenerUno(x.id))
                        .Where(x => x != null && x.estado != -1)
                        .ToList();
                }
            }

            if (productos != null && productos.Count > 0)
            {
                foreach (var p in productos.OrderBy(p => p.nombre))
                {
                    var card = CrearCardProducto(p);
                    flpCatalogoProductos.Controls.Add(card);
                }
            }
            else
            {
                // Mensaje amigable cuando no hay datos
                var lbl = new Label
                {
                    Text = "No hay productos activos para mostrar.",
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    ForeColor = Color.DimGray
                };
                flpCatalogoProductos.Controls.Add(lbl);
            }

            flpCatalogoProductos.ResumeLayout();
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

            var lblPrecio = new Label
            {
                Text = "Precio: " + p.precioVenta.ToString("0.00"),
                Location = new Point(10, 155),
                Width = 75,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray,
                AutoSize = false
            };

            var lblStock = new Label
            {
                Text = "Stock: " + p.saldo,
                Location = new Point(85, 155),
                Width = 65,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.TopRight,
                AutoSize = false
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
                ReadOnly = true // Solo flechas/rueda; bloquea tipeo y pegado
            };

            // Mantén solo ValueChanged (el Max y esta validación cubren el stock)
            nudCantidad.ValueChanged += NudCantidad_ValueChanged;

            panel.Controls.Add(pb);
            panel.Controls.Add(lblNombre);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(lblStock);
            panel.Controls.Add(nudCantidad);

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

            // Seguridad extra (el Max ya lo impide, pero validamos igual)
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
                    existente.precioUnitario = producto.precioVenta; // por si cambió
                    existente.total = cantidad * producto.precioVenta;
                }
            }

            RefrescarDetalle();
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