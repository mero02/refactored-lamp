namespace TurApp.Views
{
    partial class FrmDetalleFactura
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
            this.DetalleFacGrd = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.NroRengCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaqCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleFacGrd
            // 
            this.DetalleFacGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleFacGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroRengCol,
            this.PaqCol,
            this.ImporteCol});
            this.DetalleFacGrd.Location = new System.Drawing.Point(54, 32);
            this.DetalleFacGrd.Name = "DetalleFacGrd";
            this.DetalleFacGrd.Size = new System.Drawing.Size(584, 180);
            this.DetalleFacGrd.TabIndex = 0;
            this.DetalleFacGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DetalleFacGrd_DataBindingComplete);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(550, 223);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(61, 26);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // NroRengCol
            // 
            this.NroRengCol.HeaderText = "Nro Renglon";
            this.NroRengCol.Name = "NroRengCol";
            // 
            // PaqCol
            // 
            this.PaqCol.DataPropertyName = "CodPaquete";
            this.PaqCol.HeaderText = "Paquete";
            this.PaqCol.Name = "PaqCol";
            // 
            // ImporteCol
            // 
            this.ImporteCol.DataPropertyName = "Importe";
            this.ImporteCol.HeaderText = "Importe";
            this.ImporteCol.Name = "ImporteCol";
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 261);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.DetalleFacGrd);
            this.Name = "FrmDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleFactura";
            this.Load += new System.EventHandler(this.FrmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalleFacGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroRengCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaqCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
    }
}