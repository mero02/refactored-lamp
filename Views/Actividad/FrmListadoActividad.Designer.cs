namespace TurApp.Views
{
    partial class FrmListadoActividad
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
            this.ActividadGrd = new System.Windows.Forms.DataGridView();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoActividadTxt = new System.Windows.Forms.TextBox();
            this.TipoActividadChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTransporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ActividadGrd.Location = new System.Drawing.Point(8, 59);
            this.ActividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ActividadGrd.MultiSelect = false;
            this.ActividadGrd.Name = "ActividadGrd";
            this.ActividadGrd.ReadOnly = true;
            this.ActividadGrd.RowTemplate.Height = 24;
            this.ActividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadGrd.ShowEditingIcon = false;
            this.ActividadGrd.Size = new System.Drawing.Size(576, 233);
            this.ActividadGrd.TabIndex = 4;
            this.ActividadGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ActividadGrd_ColumnHeaderMouseClick);
            this.ActividadGrd.DoubleClick += new System.EventHandler(this.ActividadGrd_DoubleClick);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(508, 9);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 3;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoActividadTxt);
            this.groupBox1.Controls.Add(this.TipoActividadChk);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(268, 42);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TipoActividadTxt
            // 
            this.TipoActividadTxt.Enabled = false;
            this.TipoActividadTxt.Location = new System.Drawing.Point(111, 15);
            this.TipoActividadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadTxt.Name = "TipoActividadTxt";
            this.TipoActividadTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoActividadTxt.TabIndex = 1;
            // 
            // TipoActividadChk
            // 
            this.TipoActividadChk.AutoSize = true;
            this.TipoActividadChk.Location = new System.Drawing.Point(4, 17);
            this.TipoActividadChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadChk.Name = "TipoActividadChk";
            this.TipoActividadChk.Size = new System.Drawing.Size(94, 17);
            this.TipoActividadChk.TabIndex = 1;
            this.TipoActividadChk.Text = "Tipo Actividad";
            this.TipoActividadChk.UseVisualStyleBackColor = true;
            this.TipoActividadChk.CheckedChanged += new System.EventHandler(this.TipoActividadChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(500, 313);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 5;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
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
            // FrmListadoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 361);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActividadGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Listado de Actividades";
            this.Load += new System.EventHandler(this.FrmListadoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActividadGrd;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TipoActividadTxt;
        private System.Windows.Forms.CheckBox TipoActividadChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTransporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
    }
}