namespace TurApp.Views
{
    partial class FrmActividadList
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
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.ActividadGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTransporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(275, 111);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(77, 27);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // ActividadGrd
            // 
            this.ActividadGrd.AllowUserToAddRows = false;
            this.ActividadGrd.AllowUserToDeleteRows = false;
            this.ActividadGrd.AllowUserToResizeColumns = false;
            this.ActividadGrd.AllowUserToResizeRows = false;
            this.ActividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.codTransporteCol,
            this.NivelCol,
            this.TipoActividadCol,
            this.ImporteCol});
            this.ActividadGrd.Location = new System.Drawing.Point(22, 19);
            this.ActividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ActividadGrd.MultiSelect = false;
            this.ActividadGrd.Name = "ActividadGrd";
            this.ActividadGrd.ReadOnly = true;
            this.ActividadGrd.RowTemplate.Height = 24;
            this.ActividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadGrd.ShowEditingIcon = false;
            this.ActividadGrd.Size = new System.Drawing.Size(597, 88);
            this.ActividadGrd.TabIndex = 1;
            this.ActividadGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActividadGrd_CellContentClick_1);
            this.ActividadGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ActividadGrd_ColumnHeaderMouseClick);
            this.ActividadGrd.DoubleClick += new System.EventHandler(this.ActividadGrd_DoubleClick);
            // 
            // CodigoCol
            // 
            this.CodigoCol.DataPropertyName = "Codigo";
            this.CodigoCol.HeaderText = "Codigo";
            this.CodigoCol.Name = "CodigoCol";
            this.CodigoCol.ReadOnly = true;
            // 
            // codTransporteCol
            // 
            this.codTransporteCol.DataPropertyName = "CodTransporte";
            this.codTransporteCol.HeaderText = "Transporte";
            this.codTransporteCol.Name = "codTransporteCol";
            this.codTransporteCol.ReadOnly = true;
            this.codTransporteCol.Width = 150;
            // 
            // NivelCol
            // 
            this.NivelCol.DataPropertyName = "Nivel";
            this.NivelCol.HeaderText = "Nivel";
            this.NivelCol.Name = "NivelCol";
            this.NivelCol.ReadOnly = true;
            // 
            // TipoActividadCol
            // 
            this.TipoActividadCol.DataPropertyName = "CodTipoActividad";
            this.TipoActividadCol.HeaderText = "Tipo Actividad";
            this.TipoActividadCol.Name = "TipoActividadCol";
            this.TipoActividadCol.ReadOnly = true;
            // 
            // ImporteCol
            // 
            this.ImporteCol.DataPropertyName = "Importe";
            this.ImporteCol.HeaderText = "Importe";
            this.ImporteCol.Name = "ImporteCol";
            this.ImporteCol.ReadOnly = true;
            // 
            // FrmActividadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 147);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.ActividadGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActividadList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Actividades";
            this.Load += new System.EventHandler(this.FrmActividadList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView ActividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTransporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
    }
}