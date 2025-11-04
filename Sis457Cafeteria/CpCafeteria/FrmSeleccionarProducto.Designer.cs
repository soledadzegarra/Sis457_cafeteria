namespace CpCafeteria
{
    partial class FrmSeleccionarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarProducto));
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSeleccionarProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(186, 45);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(168, 21);
            this.cbxProducto.TabIndex = 0;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(186, 84);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(168, 20);
            this.nudCantidad.TabIndex = 1;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(186, 122);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(168, 20);
            this.txtPrecioUnitario.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(186, 162);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(168, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(75, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(252, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSeleccionarProducto
            // 
            this.lblSeleccionarProducto.AutoSize = true;
            this.lblSeleccionarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarProducto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSeleccionarProducto.Location = new System.Drawing.Point(12, 46);
            this.lblSeleccionarProducto.Name = "lblSeleccionarProducto";
            this.lblSeleccionarProducto.Size = new System.Drawing.Size(165, 16);
            this.lblSeleccionarProducto.TabIndex = 6;
            this.lblSeleccionarProducto.Text = "Seleccionar el Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCantidad.Location = new System.Drawing.Point(102, 84);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 16);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(72, 122);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(105, 16);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotal.Location = new System.Drawing.Point(134, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // FrmSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(410, 305);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblSeleccionarProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cbxProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":::Cafeteria - Seleccion de Productos:::";
            this.Load += new System.EventHandler(this.FrmSeleccionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSeleccionarProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTotal;
    }
}