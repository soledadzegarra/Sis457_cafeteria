using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClnCafeteria;

namespace CpCafeteria
{
    public partial class FrmAutenticacion : Form
    {
        private const int FormRadius = 18;

        public FrmAutenticacion()
        {
            InitializeComponent();

            txtUsuario.Focus();

            // Aplicar región redondeada inicialmente y cada vez que se redimensione
            ApplyRoundedRegion(FormRadius);
            this.Resize += (s, e) => ApplyRoundedRegion(FormRadius);

            // Reducir parpadeo
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Aplica la misma forma redondeada al formulario
        private void ApplyRoundedRegion(int radius)
        {
            var rect = this.ClientRectangle;
            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                // Dispose de la región anterior si existe para evitar fugas
                var oldRegion = this.Region;
                this.Region = new Region(path);
                oldRegion?.Dispose();
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
            path.AddLine(rect.X + r, rect.Y, rect.Right - r, rect.Y);
            path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + r, rect.Right, rect.Bottom - r);
            path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
            path.AddLine(rect.Right - r, rect.Bottom, rect.X + r, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
            path.AddLine(rect.X, rect.Bottom - r, rect.X, rect.Y + r);
            path.CloseFigure();
            return path;
        }

        public class RoundedPanel : Panel
        {
            private int borderRadius = 18;
            private Color gradientTop = Color.FromArgb(255, 238, 210); // color superior por defecto
            private Color gradientBottom = Color.FromArgb(245, 193, 132); // color inferior por defecto

            [Category("Appearance")]
            [Description("Radio de las esquinas")]
            public int BorderRadius
            {
                get => borderRadius;
                set { borderRadius = Math.Max(0, value); Invalidate(); }
            }

            [Category("Appearance")]
            [Description("Color superior del degradado")]
            public Color GradientTopColor
            {
                get => gradientTop;
                set { gradientTop = value; Invalidate(); }
            }

            [Category("Appearance")]
            [Description("Color inferior del degradado")]
            public Color GradientBottomColor
            {
                get => gradientBottom;
                set { gradientBottom = value; Invalidate(); }
            }

            public RoundedPanel()
            {
                // habilitar doble buffer para reducir parpadeo
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
                BackColor = Color.Transparent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

                using (GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius))
                using (LinearGradientBrush brush = new LinearGradientBrush(rect, gradientTop, gradientBottom, LinearGradientMode.Vertical))
                using (Pen pen = new Pen(Color.FromArgb(200, Color.Black), 1f))
                {
                    e.Graphics.FillPath(brush, path);
                    // opcional: contorno sutil
                    e.Graphics.DrawPath(pen, path);
                }

                // establecer región para recibir clics y dar forma al control
                using (GraphicsPath pathRegion = GetRoundedRectanglePath(rect, borderRadius))
                {
                    Region = new Region(pathRegion);
                }
            }

            private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();
                int r = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

                path.StartFigure();
                path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
                path.AddLine(rect.X + r, rect.Y, rect.Right - r, rect.Y);
                path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
                path.AddLine(rect.Right, rect.Y + r, rect.Right, rect.Bottom - r);
                path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
                path.AddLine(rect.Right - r, rect.Bottom, rect.X + r, rect.Bottom);
                path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
                path.AddLine(rect.X, rect.Bottom - r, rect.X, rect.Y + r);
                path.CloseFigure();
                return path;
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "La contraseña es obligatoria");
                esValido = false;
            }

            return esValido;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Clear();
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Hide();
                    new FrmPrincipal(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "::: Cafeteria - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }

        private void pnlAutenticacion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}