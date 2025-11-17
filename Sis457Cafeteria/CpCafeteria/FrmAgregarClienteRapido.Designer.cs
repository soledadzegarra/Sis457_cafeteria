namespace CpCafeteria
{
    partial class FrmAgregarClienteRapido
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erpCI = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(135, 118);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(230, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(135, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(230, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(135, 38);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(230, 20);
            this.txtCI.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Peru;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(135, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(266, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpCI
            // 
            this.erpCI.ContainerControl = this;
            // 
            // erpNombres
            // 
            this.erpNombres.ContainerControl = this;
            // 
            // erpApellidos
            // 
            this.erpApellidos.ContainerControl = this;
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAgregarCliente.Location = new System.Drawing.Point(160, 9);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(181, 26);
            this.lblAgregarCliente.TabIndex = 9;
            this.lblAgregarCliente.Text = "AGREGAR CLIENTE";
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNombres.Location = new System.Drawing.Point(51, 81);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(78, 17);
            this.lblNombres.TabIndex = 10;
            this.lblNombres.Text = "NOMBRES:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "APELLIDOS:";
            // 
            // lblCI
            // 
            this.lblCI.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCI.Location = new System.Drawing.Point(96, 41);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(33, 17);
            this.lblCI.TabIndex = 12;
            this.lblCI.Text = "CI:";
            // 
            // FrmAgregarClienteRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(480, 247);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblAgregarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarClienteRapido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Agregar Cliente :::";
            ((System.ComponentModel.ISupportInitialize)(this.erpCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erpCI;
        private System.Windows.Forms.ErrorProvider erpNombres;
        private System.Windows.Forms.ErrorProvider erpApellidos;
        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombres;
    }
}