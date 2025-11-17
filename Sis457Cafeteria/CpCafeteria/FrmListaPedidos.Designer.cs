namespace CpCafeteria
{
    partial class FrmListaPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnListaProductos = new System.Windows.Forms.Panel();
            this.lblReportePedidos = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.pctBuscarObscuro = new System.Windows.Forms.PictureBox();
            this.pctBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(10, 112);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1028, 455);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(18, 78);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 13);
            this.txtBuscar.TabIndex = 10;
            // 
            // pnListaProductos
            // 
            this.pnListaProductos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnListaProductos.Controls.Add(this.lblReportePedidos);
            this.pnListaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnListaProductos.Location = new System.Drawing.Point(0, 0);
            this.pnListaProductos.Name = "pnListaProductos";
            this.pnListaProductos.Size = new System.Drawing.Size(1050, 42);
            this.pnListaProductos.TabIndex = 13;
            // 
            // lblReportePedidos
            // 
            this.lblReportePedidos.AutoSize = true;
            this.lblReportePedidos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportePedidos.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblReportePedidos.Location = new System.Drawing.Point(3, 0);
            this.lblReportePedidos.Name = "lblReportePedidos";
            this.lblReportePedidos.Size = new System.Drawing.Size(318, 38);
            this.lblReportePedidos.TabIndex = 5;
            this.lblReportePedidos.Text = "Reporte de Pedidos";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Gold;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerDetalle.Image = global::CpCafeteria.Properties.Resources.frame_inspect_35dp_000000_FILL0_wght400_GRAD0_opsz40;
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalle.Location = new System.Drawing.Point(309, 68);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnVerDetalle.Size = new System.Drawing.Size(161, 30);
            this.btnVerDetalle.TabIndex = 16;
            this.btnVerDetalle.Text = "VER DETALLE";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // pctBuscarObscuro
            // 
            this.pctBuscarObscuro.Image = global::CpCafeteria.Properties.Resources.lupa1;
            this.pctBuscarObscuro.Location = new System.Drawing.Point(11, 68);
            this.pctBuscarObscuro.Name = "pctBuscarObscuro";
            this.pctBuscarObscuro.Size = new System.Drawing.Size(237, 30);
            this.pctBuscarObscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscarObscuro.TabIndex = 12;
            this.pctBuscarObscuro.TabStop = false;
            // 
            // pctBuscar
            // 
            this.pctBuscar.Image = global::CpCafeteria.Properties.Resources.lupa2;
            this.pctBuscar.Location = new System.Drawing.Point(11, 68);
            this.pctBuscar.Name = "pctBuscar";
            this.pctBuscar.Size = new System.Drawing.Size(237, 30);
            this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscar.TabIndex = 11;
            this.pctBuscar.TabStop = false;
            // 
            // FrmListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.pnListaProductos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pctBuscarObscuro);
            this.Controls.Add(this.pctBuscar);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaPedidos";
            this.Text = "FrmListaPedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FrmListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnListaProductos.ResumeLayout(false);
            this.pnListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarObscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pctBuscarObscuro;
        private System.Windows.Forms.PictureBox pctBuscar;
        private System.Windows.Forms.Panel pnListaProductos;
        private System.Windows.Forms.Label lblReportePedidos;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}