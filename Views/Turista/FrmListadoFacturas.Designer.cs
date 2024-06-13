namespace TurApp.Views
{
    partial class FrmListadoFacturas
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
            this.FacturasGrd = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBoxFac = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGrd)).BeginInit();
            this.groupBoxFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturasGrd
            // 
            this.FacturasGrd.AllowUserToAddRows = false;
            this.FacturasGrd.AllowUserToDeleteRows = false;
            this.FacturasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.serie,
            this.letra,
            this.fecha,
            this.dni,
            this.fromaPago,
            this.detPago});
            this.FacturasGrd.Location = new System.Drawing.Point(22, 24);
            this.FacturasGrd.MultiSelect = false;
            this.FacturasGrd.Name = "FacturasGrd";
            this.FacturasGrd.ReadOnly = true;
            this.FacturasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FacturasGrd.ShowEditingIcon = false;
            this.FacturasGrd.Size = new System.Drawing.Size(744, 272);
            this.FacturasGrd.TabIndex = 0;
            this.FacturasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FacturasTuristaGrd_DataBindingComplete);
            // 
            // nro
            // 
            this.nro.HeaderText = "NroFactura";
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            // 
            // letra
            // 
            this.letra.HeaderText = "Letra";
            this.letra.Name = "letra";
            this.letra.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // fromaPago
            // 
            this.fromaPago.HeaderText = "Forma de Pago";
            this.fromaPago.Name = "fromaPago";
            this.fromaPago.ReadOnly = true;
            // 
            // detPago
            // 
            this.detPago.HeaderText = "Detalle del pago";
            this.detPago.Name = "detPago";
            this.detPago.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(723, 348);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(66, 32);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerra";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBoxFac
            // 
            this.groupBoxFac.Controls.Add(this.FacturasGrd);
            this.groupBoxFac.Location = new System.Drawing.Point(23, 14);
            this.groupBoxFac.Name = "groupBoxFac";
            this.groupBoxFac.Size = new System.Drawing.Size(793, 311);
            this.groupBoxFac.TabIndex = 2;
            this.groupBoxFac.TabStop = false;
            this.groupBoxFac.Text = "Facturas Turista";
            // 
            // FrmListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 392);
            this.Controls.Add(this.groupBoxFac);
            this.Controls.Add(this.CerrarBtn);
            this.Name = "FrmListadoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.FrmListadoFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGrd)).EndInit();
            this.groupBoxFac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FacturasGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn detPago;
        private System.Windows.Forms.GroupBox groupBoxFac;
    }
}