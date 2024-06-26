namespace TurApp.Views
{
    partial class FrmTipoActividadList
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
            this.TipoActividadGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(260, 220);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(129, 27);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // TipoActividadGrd
            // 
            this.TipoActividadGrd.AllowUserToAddRows = false;
            this.TipoActividadGrd.AllowUserToDeleteRows = false;
            this.TipoActividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoActividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.NombreCol,
            this.DescripcionCol,
            this.DuracionCol,
            this.NivelCol});
            this.TipoActividadGrd.Location = new System.Drawing.Point(14, 18);
            this.TipoActividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadGrd.MultiSelect = false;
            this.TipoActividadGrd.Name = "TipoActividadGrd";
            this.TipoActividadGrd.ReadOnly = true;
            this.TipoActividadGrd.RowTemplate.Height = 24;
            this.TipoActividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TipoActividadGrd.ShowEditingIcon = false;
            this.TipoActividadGrd.Size = new System.Drawing.Size(640, 191);
            this.TipoActividadGrd.TabIndex = 1;
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
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // DescripcionCol
            // 
            this.DescripcionCol.DataPropertyName = "Descripcion";
            this.DescripcionCol.HeaderText = "Descripcion";
            this.DescripcionCol.Name = "DescripcionCol";
            this.DescripcionCol.ReadOnly = true;
            this.DescripcionCol.Width = 150;
            // 
            // DuracionCol
            // 
            this.DuracionCol.DataPropertyName = "Duracion";
            this.DuracionCol.HeaderText = "Duracion";
            this.DuracionCol.Name = "DuracionCol";
            this.DuracionCol.ReadOnly = true;
            // 
            // NivelCol
            // 
            this.NivelCol.DataPropertyName = "Nivel";
            this.NivelCol.HeaderText = "Nivel";
            this.NivelCol.Name = "NivelCol";
            this.NivelCol.ReadOnly = true;
            // 
            // FrmTipoActividadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 270);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.TipoActividadGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmTipoActividadList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Tipo Actividad";
            this.Load += new System.EventHandler(this.FrmTipoActividadList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoActividadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView TipoActividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
    }
}