using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CpCafeteria
{
    public partial class FrmPrincipal : Form
    {
        private Form activeForm;
        private FrmAutenticacion frmAutenticacion;

        // Colores que ya usas en el contenido (no afectan al menú)
        private readonly Color gradientTopColor = Color.FromArgb(255, 245, 231);
        private Color gradientBottomColor = Color.FromArgb(246, 190, 124);

        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;

            // La barra usa el color inferior de autenticación
            paBarraTitulo.BackColor = gradientBottomColor;

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
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
            if (activeForm != null) activeForm.Close();
            activeForm = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnContenedor.Controls.Add(formulario);
            pnContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void pctCafeteriaLogo_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.FromArgb(246, 190, 124);
            gradientBottomColor = Color.FromArgb(246, 190, 124);
            pnContenedor.Invalidate();
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.FromArgb(246, 190, 124);
            gradientBottomColor = Color.FromArgb(246, 190, 124);
            pnContenedor.Invalidate();
            AbrirFormulario(new FrmProductos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.BurlyWood;
            gradientBottomColor = Color.BurlyWood;
            pnContenedor.Invalidate();
            AbrirFormulario(new FrmEmpleado());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.Wheat;
            gradientBottomColor = Color.Wheat;
            pnContenedor.Invalidate();
            AbrirFormulario(new FrmClientes());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.NavajoWhite;
            gradientBottomColor = Color.NavajoWhite;
            pnContenedor.Invalidate();
            AbrirFormulario(new FrmPedidos());
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            paBarraTitulo.BackColor = Color.DarkKhaki;
            gradientBottomColor = Color.DarkKhaki;
            pnContenedor.Invalidate();
            AbrirFormulario(new FrmListaPedidos());
        }

        private void btnDeslizar_Click(object sender, EventArgs e)
        {
            pnMenu.Width = pnMenu.Width == 250 ? 70 : 250;
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void paBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void paBarraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
            }
        }

        // Degradado SOLO en el menú lateral
        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
            var rect = pnMenu.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // Colores del menú: inferior = color actual, superior = un tono más claro (respetando la paleta)
            Color bottom = Color.FromArgb(156, 93, 40);    // color del menú que ya tienes
            Color top = Color.FromArgb(168, 112, 66);   // ligeramente más claro

            using (var brush = new LinearGradientBrush(rect, top, bottom, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        // Si aún existe este método en tu archivo, no pasa nada; solo asegúrate de NO suscribir el Paint de pnContenedor en el diseñador.
        private void pnContenedor_Paint(object sender, PaintEventArgs e) { /* sin uso */ }
    }
}