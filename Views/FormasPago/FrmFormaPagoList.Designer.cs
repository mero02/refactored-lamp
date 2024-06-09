namespace TurApp.Views
{
    partial class FrmFormaPagoList
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
            this.FormaPagosGrd = new System.Windows.Forms.DataGridView();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagosGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaPagosGrd
            // 
            this.FormaPagosGrd.AllowUserToAddRows = false;
            this.FormaPagosGrd.AllowUserToDeleteRows = false;
            this.FormaPagosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormaPagosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalidadCol,
            this.NombreCol});
            this.FormaPagosGrd.Location = new System.Drawing.Point(11, 21);
            this.FormaPagosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagosGrd.MultiSelect = false;
            this.FormaPagosGrd.Name = "FormaPagosGrd";
            this.FormaPagosGrd.ReadOnly = true;
            this.FormaPagosGrd.RowTemplate.Height = 24;
            this.FormaPagosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormaPagosGrd.ShowEditingIcon = false;
            this.FormaPagosGrd.Size = new System.Drawing.Size(294, 76);
            this.FormaPagosGrd.TabIndex = 9;
            this.FormaPagosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.FormaPagosGrd.DoubleClick += new System.EventHandler(this.FormaPagoGrd_DoubleClick);
            // 
            // LocalidadCol
            // 
            this.LocalidadCol.DataPropertyName = "Codigo";
            this.LocalidadCol.HeaderText = "Codigo";
            this.LocalidadCol.Name = "LocalidadCol";
            this.LocalidadCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Forma";
            this.NombreCol.HeaderText = "Forma";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(125, 116);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 10;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FrmFormaPagoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.FormaPagosGrd);
            this.Name = "FrmFormaPagoList";
            this.Text = "Lista Forma de Pago";
            this.Activated += new System.EventHandler(this.FrmFormaPagoList_Load);
            this.Load += new System.EventHandler(this.FrmFormaPagoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagosGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FormaPagosGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
    }
}