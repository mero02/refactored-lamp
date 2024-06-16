namespace TurApp.Views
{
    partial class FrmListadoPaises
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
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.PaisesGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PaisesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(745, 446);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 12;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // PaisesGrd
            // 
            this.PaisesGrd.AllowUserToAddRows = false;
            this.PaisesGrd.AllowUserToDeleteRows = false;
            this.PaisesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaisesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.NombreCol,
            this.CantidadCol});
            this.PaisesGrd.Location = new System.Drawing.Point(11, 27);
            this.PaisesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PaisesGrd.MultiSelect = false;
            this.PaisesGrd.Name = "PaisesGrd";
            this.PaisesGrd.ReadOnly = true;
            this.PaisesGrd.RowTemplate.Height = 24;
            this.PaisesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaisesGrd.ShowEditingIcon = false;
            this.PaisesGrd.Size = new System.Drawing.Size(826, 414);
            this.PaisesGrd.TabIndex = 11;
            this.PaisesGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaisesGrd_CellContentClick);
            this.PaisesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PaisesGrd_ColumnHeaderMouseClick);
            this.PaisesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PaisesGrd_DataBindingComplete);
            // 
            // CodigoCol
            // 
            this.CodigoCol.DataPropertyName = "Codigo";
            this.CodigoCol.HeaderText = "Codigo";
            this.CodigoCol.Name = "CodigoCol";
            this.CodigoCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombre";
            this.NombreCol.HeaderText = "Pais";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // CantidadCol
            // 
            this.CantidadCol.DataPropertyName = "Cantidad";
            this.CantidadCol.HeaderText = "Cantidad";
            this.CantidadCol.Name = "CantidadCol";
            this.CantidadCol.ReadOnly = true;
            // 
            // FrmListadoPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.PaisesGrd);
            this.Name = "FrmListadoPaises";
            this.Text = "FrmListadoPaises";
            this.Load += new System.EventHandler(this.FrmListadoPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaisesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridView PaisesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCol;

    }
}