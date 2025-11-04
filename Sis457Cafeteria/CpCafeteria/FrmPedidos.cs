using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadCafeteria;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmPedidos : Form
    {
        private List<DetallePedido> detalles = new List<DetallePedido>();
        private Cliente clienteSeleccionado = null;

        public FrmPedidos()
        {
            InitializeComponent();
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
        }

        private void ConfigurarDgvDetalle()
        {
            dgvDetallePedido.Columns.Clear();
            dgvDetallePedido.Columns.Add("nombreProducto", "Producto");
            dgvDetallePedido.Columns.Add("cantidad", "Cantidad");
            dgvDetallePedido.Columns.Add("precioUnitario", "Precio Unitario");
            dgvDetallePedido.Columns.Add("total", "Total");
            dgvDetallePedido.Columns["nombreProducto"].DataPropertyName = "Nombre del Producto";
            dgvDetallePedido.Columns["cantidad"].DataPropertyName = "Cantidad";
            dgvDetallePedido.Columns["precioUnitario"].DataPropertyName = "Precio Unitario";
            dgvDetallePedido.Columns["total"].DataPropertyName = "Total";
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
                        existente.cantidad += detalle.cantidad;
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

            if (dgvDetallePedido.Columns.Count > 0)
            {
                dgvDetallePedido.Columns["nombreProducto"].HeaderText = "Producto";
                dgvDetallePedido.Columns["cantidad"].HeaderText = "Cantidad";
                dgvDetallePedido.Columns["precioUnitario"].HeaderText = "Precio Unitario";
                dgvDetallePedido.Columns["total"].HeaderText = "Total";
            }

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
        }
    }
}
