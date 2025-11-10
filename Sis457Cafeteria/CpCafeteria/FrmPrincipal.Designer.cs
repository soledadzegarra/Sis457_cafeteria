namespace CpCafeteria
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pctCafeteriaLogo = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.paBarraTitulo = new System.Windows.Forms.Panel();
            this.btnDeslizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCafeteriaLogo)).BeginInit();
            this.paBarraTitulo.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(93)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.btnReportePedidos);
            this.pnMenu.Controls.Add(this.btnPedidos);
            this.pnMenu.Controls.Add(this.btnClientes);
            this.pnMenu.Controls.Add(this.btnEmpleados);
            this.pnMenu.Controls.Add(this.pctCafeteriaLogo);
            this.pnMenu.Controls.Add(this.btnProductos);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 63);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1400, 81);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // btnReportePedidos
            // 
            this.btnReportePedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnReportePedidos.FlatAppearance.BorderSize = 0;
            this.btnReportePedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReportePedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidos.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReportePedidos.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnReportePedidos.Image = global::CpCafeteria.Properties.Resources.area_chart_33dp_FFEFD5_FILL0_wght400_GRAD0_opsz40;
            this.btnReportePedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportePedidos.Location = new System.Drawing.Point(421, 4);
            this.btnReportePedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReportePedidos.Size = new System.Drawing.Size(169, 70);
            this.btnReportePedidos.TabIndex = 26;
            this.btnReportePedidos.Text = "Reportes";
            this.btnReportePedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportePedidos.UseVisualStyleBackColor = false;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnPedidos.Image = global::CpCafeteria.Properties.Resources.dine_in_33dp_FFEFD5_FILL0_wght400_GRAD0_opsz40;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidos.Location = new System.Drawing.Point(213, 4);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(197, 74);
            this.btnPedidos.TabIndex = 24;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClientes.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnClientes.Image = global::CpCafeteria.Properties.Resources.person_raised_hand_33dp_FFEFD5_FILL0_wght400_GRAD0_opsz40;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(1161, 4);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(164, 74);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEmpleados.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnEmpleados.Image = global::CpCafeteria.Properties.Resources.assignment_ind_33dp_FFEFD5_FILL0_wght400_GRAD0_opsz40;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(833, 4);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(212, 70);
            this.btnEmpleados.TabIndex = 15;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pctCafeteriaLogo
            // 
            this.pctCafeteriaLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctCafeteriaLogo.Image = global::CpCafeteria.Properties.Resources.book__1_;
            this.pctCafeteriaLogo.Location = new System.Drawing.Point(673, 4);
            this.pctCafeteriaLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctCafeteriaLogo.Name = "pctCafeteriaLogo";
            this.pctCafeteriaLogo.Size = new System.Drawing.Size(107, 76);
            this.pctCafeteriaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCafeteriaLogo.TabIndex = 0;
            this.pctCafeteriaLogo.TabStop = false;
            this.pctCafeteriaLogo.Click += new System.EventHandler(this.pctCafeteriaLogo_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnProductos.Image = global::CpCafeteria.Properties.Resources.menu_book_2_33dp_FFEFD5_FILL0_wght400_GRAD0_opsz40;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(56, 0);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(137, 78);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Menú";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // paBarraTitulo
            // 
            this.paBarraTitulo.BackColor = System.Drawing.Color.PapayaWhip;
            this.paBarraTitulo.Controls.Add(this.btnDeslizar);
            this.paBarraTitulo.Controls.Add(this.btnMaximizar);
            this.paBarraTitulo.Controls.Add(this.btnRestaurar);
            this.paBarraTitulo.Controls.Add(this.btnMinimizar);
            this.paBarraTitulo.Controls.Add(this.btnCerrar);
            this.paBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.paBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.paBarraTitulo.Name = "paBarraTitulo";
            this.paBarraTitulo.Size = new System.Drawing.Size(1400, 63);
            this.paBarraTitulo.TabIndex = 1;
            this.paBarraTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.paBarraTitulo_MouseDoubleClick);
            this.paBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paBarraTitulo_MouseDown);
            // 
            // btnDeslizar
            // 
            this.btnDeslizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslizar.FlatAppearance.BorderSize = 0;
            this.btnDeslizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslizar.Location = new System.Drawing.Point(4, 7);
            this.btnDeslizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeslizar.Name = "btnDeslizar";
            this.btnDeslizar.Size = new System.Drawing.Size(47, 43);
            this.btnDeslizar.TabIndex = 9;
            this.btnDeslizar.UseVisualStyleBackColor = true;
            this.btnDeslizar.Click += new System.EventHandler(this.btnDeslizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1312, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 31);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1312, 7);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 31);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1272, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1352, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnContenedor.Controls.Add(this.lblReloj);
            this.pnContenedor.Controls.Add(this.pictureBox1);
            this.pnContenedor.Controls.Add(this.pnMenu);
            this.pnContenedor.Controls.Add(this.paBarraTitulo);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(1400, 862);
            this.pnContenedor.TabIndex = 2;
            this.pnContenedor.Click += new System.EventHandler(this.pctCafeteriaLogo_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReloj.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblReloj.Location = new System.Drawing.Point(1086, 782);
            this.lblReloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(239, 71);
            this.lblReloj.TabIndex = 2;
            this.lblReloj.Text = "xxxx";
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CpCafeteria.Properties.Resources.logoCafe2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(359, 228);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 862);
            this.Controls.Add(this.pnContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCafeteriaLogo)).EndInit();
            this.paBarraTitulo.ResumeLayout(false);
            this.pnContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel paBarraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnDeslizar;
        private System.Windows.Forms.PictureBox pctCafeteriaLogo;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}