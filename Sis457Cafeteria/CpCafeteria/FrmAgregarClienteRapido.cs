using System;
using System.Windows.Forms;
using CadCafeteria;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmAgregarClienteRapido : Form
    {
        public Cliente ClienteCreado { get; private set; }

        public FrmAgregarClienteRapido()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            erpCI.SetError(txtCI, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtApellidos, "");
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtCI.Text))
            {
                erpCI.SetError(txtCI, "CI obligatorio");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                erpNombres.SetError(txtNombres, "Nombres obligatorios");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                erpApellidos.SetError(txtApellidos, "Apellidos obligatorios");
                ok = false;
            }
            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var cliente = new Cliente
            {
                cedulaIdentidad = txtCI.Text.Trim(),
                nombres = txtNombres.Text.Trim(),
                apellidos = txtApellidos.Text.Trim(),
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };

            cliente.id = ClientesCln.insertar(cliente);
            ClienteCreado = cliente;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}