namespace TurApp.Views
{
    partial class FrmLocalidadList
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
            this.LocalidadesGrd = new System.Windows.Forms.DataGridView();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalidadesGrd
            // 
            this.LocalidadesGrd.AllowUserToAddRows = false;
            this.LocalidadesGrd.AllowUserToDeleteRows = false;
            this.LocalidadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalidadCol,
            this.NombreCol});
            this.LocalidadesGrd.Location = new System.Drawing.Point(11, 23);
            this.LocalidadesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadesGrd.MultiSelect = false;
            this.LocalidadesGrd.Name = "LocalidadesGrd";
            this.LocalidadesGrd.ReadOnly = true;
            this.LocalidadesGrd.RowTemplate.Height = 24;
            this.LocalidadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalidadesGrd.ShowEditingIcon = false;
            this.LocalidadesGrd.Size = new System.Drawing.Size(294, 76);
            this.LocalidadesGrd.TabIndex = 8;
            this.LocalidadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LocalidadesGrd_DataBindingComplete);
            this.LocalidadesGrd.DoubleClick += new System.EventHandler(this.LocalidadesGrd_DoubleClick);
            // 
            // LocalidadCol
            // 
            this.LocalidadCol.DataPropertyName = "CodPos";
            this.LocalidadCol.HeaderText = "CodPos";
            this.LocalidadCol.Name = "LocalidadCol";
            this.LocalidadCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(126, 116);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 9;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FrmLocalidadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.LocalidadesGrd);
            this.Name = "FrmLocalidadList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Localidades";
            this.Activated += new System.EventHandler(this.FrmLocalidadList_Load);
            this.Load += new System.EventHandler(this.FrmLocalidadList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LocalidadesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.Button CerrarBtn;
    }
}