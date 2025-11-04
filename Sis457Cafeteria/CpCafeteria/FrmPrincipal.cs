using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CpCafeteria
{
    public partial class FrmPrincipal : Form
    {
        private Form activeForm;
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            paBarraTitulo.BackColor = Color.PapayaWhip;
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            this.frmAutenticacion = frmAutenticacion;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void AbrirFormulario(Form formulario)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(formulario);
            this.pnContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void pctCafeteriaLogo_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.PapayaWhip;
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.PapayaWhip;
            AbrirFormulario(new FrmProductos());
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.BurlyWood;
            AbrirFormulario(new FrmEmpleado());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.Wheat;
            AbrirFormulario(new FrmClientes());
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.NavajoWhite;
            AbrirFormulario(new FrmPedidos());
        }
        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.DarkKhaki;
            AbrirFormulario(new FrmListaPedidos());
        }

        private void btnDeslizar_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 250)
            {
                pnMenu.Width = 70;
            }
            else
                pnMenu.Width = 250;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void paBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void paBarraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
            }
        }
    }
}
