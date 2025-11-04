namespace CpCafeteria
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnListaProductos = new System.Windows.Forms.Panel();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.dgvDetallePedido = new System.Windows.Forms.DataGridView();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.pnListaProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListaProductos
            // 
            this.pnListaProductos.BackColor = System.Drawing.Color.Peru;
            this.pnListaProductos.Controls.Add(this.lblPedidos);
            this.pnListaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnListaProductos.Location = new System.Drawing.Point(0, 0);
            this.pnListaProductos.Name = "pnListaProductos";
            this.pnListaProductos.Size = new System.Drawing.Size(1050, 42);
            this.pnListaProductos.TabIndex = 9;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(270, 38);
            this.lblPedidos.TabIndex = 5;
            this.lblPedidos.Text = "Registro Pedidos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(707, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(233, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(619, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 22);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtCedulaCliente);
            this.groupBox1.Controls.Add(this.lblCedulaIdentidad);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(86, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(247, 23);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(6, 77);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(77, 21);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Location = new System.Drawing.Point(86, 25);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(247, 23);
            this.txtCedulaCliente.TabIndex = 6;
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(41, 25);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(39, 21);
            this.lblCedulaIdentidad.TabIndex = 5;
            this.lblCedulaIdentidad.Text = "NIT:";
            // 
            // dgvDetallePedido
            // 
            this.dgvDetallePedido.AllowUserToAddRows = false;
            this.dgvDetallePedido.AllowUserToDeleteRows = false;
            this.dgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedido.Location = new System.Drawing.Point(30, 195);
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            this.dgvDetallePedido.ReadOnly = true;
            this.dgvDetallePedido.RowHeadersWidth = 51;
            this.dgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePedido.Size = new System.Drawing.Size(596, 247);
            this.dgvDetallePedido.TabIndex = 13;
            // 
            // txtCambio
            // 
            this.txtCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(803, 356);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(101, 20);
            this.txtCambio.TabIndex = 21;
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(689, 352);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(98, 24);
            this.lblCambio.TabIndex = 20;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEfectivo.Location = new System.Drawing.Point(803, 300);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(101, 20);
            this.txtEfectivo.TabIndex = 19;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(689, 296);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(98, 24);
            this.lblEfectivo.TabIndex = 18;
            this.lblEfectivo.Text = "Efectivo:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(803, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(724, 243);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 24);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gold;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Image = global::CpCafeteria.Properties.Resources.refresh_25dp_000000_FILL0_wght400_GRAD0_opsz2422;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(524, 540);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.btnActualizar.Size = new System.Drawing.Size(129, 30);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardarPedido.FlatAppearance.BorderSize = 0;
            this.btnGuardarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarPedido.Image = global::CpCafeteria.Properties.Resources.save_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPedido.Location = new System.Drawing.Point(374, 540);
            this.btnGuardarPedido.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnGuardarPedido.Size = new System.Drawing.Size(129, 30);
            this.btnGuardarPedido.TabIndex = 15;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPedido.UseVisualStyleBackColor = false;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarProducto.Image = global::CpCafeteria.Properties.Resources.add_shopping_cart_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(206, 460);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(180, 30);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Image = global::CpCafeteria.Properties.Resources.search_23dp_EAC452_FILL0_wght400_GRAD0_opsz24;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(352, 16);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBuscarCliente.Size = new System.Drawing.Size(47, 35);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvDetallePedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pnListaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.pnListaProductos.ResumeLayout(false);
            this.pnListaProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnListaProductos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.DataGridView dgvDetallePedido;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnActualizar;
    }
}