namespace CpCafeteria
{
    partial class FrmCategoria
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
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.lblListaCategorias = new System.Windows.Forms.Label();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnSalirCat = new System.Windows.Forms.Button();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.erpNombreCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Peru;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.Location = new System.Drawing.Point(331, 118);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCat.TabIndex = 0;
            this.btnAgregarCat.Text = "AGREGAR";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(302, 83);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(140, 20);
            this.txtNombreCat.TabIndex = 1;
            this.txtNombreCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCat_KeyPress);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNombreCategoria.Location = new System.Drawing.Point(231, 84);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(65, 17);
            this.lblNombreCategoria.TabIndex = 2;
            this.lblNombreCategoria.Text = "NOMBRE:";
            // 
            // lblListaCategorias
            // 
            this.lblListaCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategorias.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblListaCategorias.Location = new System.Drawing.Point(23, 9);
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Size = new System.Drawing.Size(157, 32);
            this.lblListaCategorias.TabIndex = 3;
            this.lblListaCategorias.Text = "LISTA DE CATEGORIAS";
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.Chocolate;
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCat.Location = new System.Drawing.Point(59, 201);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 5;
            this.btnEliminarCat.Text = "ELIMINAR";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnSalirCat
            // 
            this.btnSalirCat.BackColor = System.Drawing.Color.Red;
            this.btnSalirCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCat.Location = new System.Drawing.Point(331, 201);
            this.btnSalirCat.Name = "btnSalirCat";
            this.btnSalirCat.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCat.TabIndex = 7;
            this.btnSalirCat.Text = "SALIR";
            this.btnSalirCat.UseVisualStyleBackColor = false;
            this.btnSalirCat.Click += new System.EventHandler(this.btnSalirCat_Click);
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCategoria.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(299, 27);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(143, 33);
            this.lblAgregarCategoria.TabIndex = 8;
            this.lblAgregarCategoria.Text = "AGREGAR CATEGORIA";
            // 
            // lstCategorias
            // 
            this.lstCategorias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCategorias.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategorias.ForeColor = System.Drawing.Color.Black;
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 16;
            this.lstCategorias.Location = new System.Drawing.Point(32, 44);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(128, 132);
            this.lstCategorias.TabIndex = 9;
            // 
            // erpNombreCategoria
            // 
            this.erpNombreCategoria.ContainerControl = this;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(480, 247);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.btnSalirCat);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.lblListaCategorias);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.btnAgregarCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Categorias :::";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblListaCategorias;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnSalirCat;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.ErrorProvider erpNombreCategoria;
    }
}