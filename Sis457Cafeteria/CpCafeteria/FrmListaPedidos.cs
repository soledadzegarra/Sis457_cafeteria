using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmListaPedidos : Form
    {
        private System.Threading.Timer searchTimer;
        private const int SEARCH_DELAY = 500;
        public FrmListaPedidos()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var lista = PedidoCln.listarPa(txtBuscar.Text.Trim());
            dgvPedidos.DataSource = lista;
            dgvPedidos.Columns["id"].Visible = false;
            dgvPedidos.Columns["estado"].Visible = false;
            dgvPedidos.Columns["numeroTransaccion"].HeaderText = "Nro. Transacción";
            dgvPedidos.Columns["Cliente"].HeaderText = "Cliente";
            dgvPedidos.Columns["Usuario"].HeaderText = "Usuario";
            dgvPedidos.Columns["fechaRegistro"].HeaderText = "Fecha";
        }

        private void FrmListaPedidos_Load(object sender, EventArgs e)
        {
            listar();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            searchTimer?.Dispose();

            searchTimer = new System.Threading.Timer(_ =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    if (!string.IsNullOrWhiteSpace(txtBuscar.Text) || txtBuscar.Text == "")
                    {
                        listar();
                    }
                });
            }, null, SEARCH_DELAY, System.Threading.Timeout.Infinite);
        }
        private void FrmListaPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchTimer?.Dispose();
        }
    }
}
