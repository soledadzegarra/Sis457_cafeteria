namespace CpCafeteria
{
    partial class FrmEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.pnListaEmpleados = new System.Windows.Forms.Panel();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.btnCerrarAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAgregarEmpleados = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pctBuscarObscuro = new System.Windows.Forms.PictureBox();
            this.pctBuscar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnListaEmpleados.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListaEmpleados
            // 
            this.pnListaEmpleados.BackColor = System.Drawing.Color.Goldenrod;
            this.pnListaEmpleados.Controls.Add(this.lblEmpleados);
            this.pnListaEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnListaEmpleados.Location = new System.Drawing.Point(0, 0);
            this.pnListaEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.pnListaEmpleados.Name = "pnListaEmpleados";
            this.pnListaEmpleados.Size = new System.Drawing.Size(1400, 52);
            this.pnListaEmpleados.TabIndex = 8;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregar.Controls.Add(this.txtUsuario);
            this.pnlAgregar.Controls.Add(this.lblUsuario);
            this.pnlAgregar.Controls.Add(this.cbxCargo);
            this.pnlAgregar.Controls.Add(this.lblCargo);
            this.pnlAgregar.Controls.Add(this.txtCelular);
            this.pnlAgregar.Controls.Add(this.lblCelular);
            this.pnlAgregar.Controls.Add(this.txtDireccion);
            this.pnlAgregar.Controls.Add(this.txtSegundoApellido);
            this.pnlAgregar.Controls.Add(this.btnCerrarAgregar);
            this.pnlAgregar.Controls.Add(this.btnCancelar);
            this.pnlAgregar.Controls.Add(this.lblAgregarEmpleados);
            this.pnlAgregar.Controls.Add(this.lblDireccion);
            this.pnlAgregar.Controls.Add(this.lblSegundoApellido);
            this.pnlAgregar.Controls.Add(this.lblPrimerApellido);
            this.pnlAgregar.Controls.Add(this.lblNombres);
            this.pnlAgregar.Controls.Add(this.lblCedulaIdentidad);
            this.pnlAgregar.Controls.Add(this.txtCedulaIdentidad);
            this.pnlAgregar.Controls.Add(this.txtNombres);
            this.pnlAgregar.Controls.Add(this.txtPrimerApellido);
            this.pnlAgregar.Controls.Add(this.btnGuardar);
            this.pnlAgregar.Location = new System.Drawing.Point(447, 82);
            this.pnlAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(569, 643);
            this.pnlAgregar.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(253, 391);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(276, 22);
            this.txtUsuario.TabIndex = 42;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(156, 391);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario.TabIndex = 41;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cbxCargo
            // 
            this.cbxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Cocinero",
            "Mesero",
            "Practicante"});
            this.cbxCargo.Location = new System.Drawing.Point(253, 341);
            this.cbxCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(276, 24);
            this.cbxCargo.TabIndex = 40;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Moccasin;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCargo.Location = new System.Drawing.Point(165, 338);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(74, 22);
            this.lblCargo.TabIndex = 39;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(253, 294);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.MaxLength = 8;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(276, 22);
            this.txtCelular.TabIndex = 38;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Moccasin;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCelular.Location = new System.Drawing.Point(159, 292);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(79, 22);
            this.lblCelular.TabIndex = 37;
            this.lblCelular.Text = "Celular:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(253, 438);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(276, 112);
            this.txtDireccion.TabIndex = 36;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(253, 247);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundoApellido.MaxLength = 30;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(276, 22);
            this.txtSegundoApellido.TabIndex = 35;
            // 
            // btnCerrarAgregar
            // 
            this.btnCerrarAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarAgregar.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAgregar.FlatAppearance.BorderSize = 0;
            this.btnCerrarAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCerrarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAgregar.Image")));
            this.btnCerrarAgregar.Location = new System.Drawing.Point(523, 11);
            this.btnCerrarAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarAgregar.Name = "btnCerrarAgregar";
            this.btnCerrarAgregar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrarAgregar.TabIndex = 24;
            this.btnCerrarAgregar.UseVisualStyleBackColor = false;
            this.btnCerrarAgregar.Click += new System.EventHandler(this.btnCerrarAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = global::CpCafeteria.Properties.Resources.dangerous_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(315, 582);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 37);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAgregarEmpleados
            // 
            this.lblAgregarEmpleados.BackColor = System.Drawing.Color.Moccasin;
            this.lblAgregarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAgregarEmpleados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleados.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAgregarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.lblAgregarEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarEmpleados.Name = "lblAgregarEmpleados";
            this.lblAgregarEmpleados.Size = new System.Drawing.Size(567, 94);
            this.lblAgregarEmpleados.TabIndex = 30;
            this.lblAgregarEmpleados.Text = "AGREGAR EMPLEADOS";
            this.lblAgregarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Moccasin;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDireccion.Location = new System.Drawing.Point(133, 438);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(101, 22);
            this.lblDireccion.TabIndex = 28;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.BackColor = System.Drawing.Color.Moccasin;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSegundoApellido.Location = new System.Drawing.Point(56, 245);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(177, 22);
            this.lblSegundoApellido.TabIndex = 27;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.BackColor = System.Drawing.Color.Moccasin;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrimerApellido.Location = new System.Drawing.Point(83, 203);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(149, 22);
            this.lblPrimerApellido.TabIndex = 26;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Moccasin;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombres.Location = new System.Drawing.Point(141, 156);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(96, 22);
            this.lblNombres.TabIndex = 25;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.BackColor = System.Drawing.Color.Moccasin;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(23, 110);
            this.lblCedulaIdentidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(209, 22);
            this.lblCedulaIdentidad.TabIndex = 23;
            this.lblCedulaIdentidad.Text = "Cedula de Identidad:";
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(253, 110);
            this.txtCedulaIdentidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedulaIdentidad.MaxLength = 12;
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(276, 22);
            this.txtCedulaIdentidad.TabIndex = 22;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(253, 156);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(276, 22);
            this.txtNombres.TabIndex = 21;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(253, 203);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerApellido.MaxLength = 30;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(276, 22);
            this.txtPrimerApellido.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::CpCafeteria.Properties.Resources.save_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(120, 582);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEmpleados.Location = new System.Drawing.Point(4, 0);
            this.lblEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(395, 47);
            this.lblEmpleados.TabIndex = 5;
            this.lblEmpleados.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 138);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1371, 560);
            this.dgvEmpleados.TabIndex = 16;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(456, 106);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(268, 15);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpNombres
            // 
            this.erpNombres.ContainerControl = this;
            // 
            // erpApellidos
            // 
            this.erpApellidos.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // erpCargo
            // 
            this.erpCargo.ContainerControl = this;
            // 
            // erpDireccion
            // 
            this.erpDireccion.ContainerControl = this;
            // 
            // pctBuscarObscuro
            // 
            this.pctBuscarObscuro.Image = global::CpCafeteria.Properties.Resources.lupa1;
            this.pctBuscarObscuro.Location = new System.Drawing.Point(447, 94);
            this.pctBuscarObscuro.Margin = new System.Windows.Forms.Padding(4);
            this.pctBuscarObscuro.Name = "pctBuscarObscuro";
            this.pctBuscarObscuro.Size = new System.Drawing.Size(316, 37);
            this.pctBuscarObscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscarObscuro.TabIndex = 19;
            this.pctBuscarObscuro.TabStop = false;
            // 
            // pctBuscar
            // 
            this.pctBuscar.Image = global::CpCafeteria.Properties.Resources.lupa2;
            this.pctBuscar.Location = new System.Drawing.Point(447, 94);
            this.pctBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pctBuscar.Name = "pctBuscar";
            this.pctBuscar.Size = new System.Drawing.Size(316, 37);
            this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscar.TabIndex = 18;
            this.pctBuscar.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Image = global::CpCafeteria.Properties.Resources.edit_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(153, 94);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnEditar.Size = new System.Drawing.Size(129, 37);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Image = global::CpCafeteria.Properties.Resources.delete_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(291, 94);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 37);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Image = global::CpCafeteria.Properties.Resources.add_25dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(16, 94);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 37);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1400, 738);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pctBuscarObscuro);
            this.Controls.Add(this.pctBuscar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.pnListaEmpleados.ResumeLayout(false);
            this.pnListaEmpleados.PerformLayout();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnListaEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pctBuscarObscuro;
        private System.Windows.Forms.PictureBox pctBuscar;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Button btnCerrarAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAgregarEmpleados;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpNombres;
        private System.Windows.Forms.ErrorProvider erpApellidos;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.ErrorProvider erpCargo;
        private System.Windows.Forms.ErrorProvider erpDireccion;
    }
}