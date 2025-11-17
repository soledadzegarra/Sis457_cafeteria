using System;
using System.Linq;
using System.Windows.Forms;
using CadCafeteria;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmDetallePedido : Form
    {
        private readonly int _idPedido;

        public FrmDetallePedido(int idPedido)
        {
            InitializeComponent();
            _idPedido = idPedido;
            Load += FrmDetallePedido_Load;
        }

        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            CargarPedido(_idPedido);
        }

        private void CargarPedido(int idPedido)
        {
            var pedido = PedidoCln.obtenerUno(idPedido);
            if (pedido == null)
            {
                MessageBox.Show("No se encontró la cabecera del pedido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            var cliente = ClientesCln.obtenerUno(pedido.idCliente);
            var detalles = DetallePedidoCln.listarPorPedido(idPedido);

            // Cabecera
            lblTransaccion.Text = pedido.numeroTransaccion;
            lblCliente.Text = cliente != null
                ? $"{cliente.nombres} {cliente.apellidos} ({cliente.cedulaIdentidad})"
                : "(Cliente no disponible)";
            // Muestra el usuario que registró en cabecera (evita cargar navegación)
            lblUsuario.Text = pedido.usuarioRegistro;
            lblFecha.Text = pedido.fechaRegistro.ToString("dd/MM/yyyy HH:mm");

            // Detalle
            var filas = detalles.Select(d =>
            {
                var prod = ProductoCln.obtenerUno(d.idProducto);
                var nombre = prod != null ? prod.nombre : $"#{d.idProducto}";
                return new
                {
                    Producto = nombre,
                    Cantidad = d.cantidad,
                    Precio = d.precioUnitario,
                    Importe = d.total
                };
            }).ToList();

            dgvDetalle.AutoGenerateColumns = true; // si ya definiste columnas, ponlo en false
            dgvDetalle.DataSource = filas;

            var total = detalles.Sum(x => x.total);
            lblTotal.Text = total.ToString("0.00");
        }
    }
}