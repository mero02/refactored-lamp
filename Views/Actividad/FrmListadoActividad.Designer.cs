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
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTransporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoActividadCbo = new System.Windows.Forms.ComboBox();
            this.TipoActividadChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.ActividadGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ActividadesGrd_DataBindingComplete);
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
            this.codTransporteCol.DataPropertyName = "Transporte";
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
            this.TipoActividadCol.DataPropertyName = "TipoActividad";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoActividadCbo);
            this.groupBox3.Controls.Add(this.TipoActividadChk);
            this.groupBox3.Location = new System.Drawing.Point(20, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(252, 41);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // TipoActividadCbo
            // 
            this.TipoActividadCbo.DisplayMember = "Nombre";
            this.TipoActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActividadCbo.Enabled = false;
            this.TipoActividadCbo.FormattingEnabled = true;
            this.TipoActividadCbo.Location = new System.Drawing.Point(121, 13);
            this.TipoActividadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadCbo.Name = "TipoActividadCbo";
            this.TipoActividadCbo.Size = new System.Drawing.Size(115, 21);
            this.TipoActividadCbo.TabIndex = 3;
            this.TipoActividadCbo.ValueMember = "CodTipoActividad";
            // 
            // TipoActividadChk
            // 
            this.TipoActividadChk.AutoSize = true;
            this.TipoActividadChk.Location = new System.Drawing.Point(10, 15);
            this.TipoActividadChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadChk.Name = "TipoActividadChk";
            this.TipoActividadChk.Size = new System.Drawing.Size(93, 17);
            this.TipoActividadChk.TabIndex = 2;
            this.TipoActividadChk.Text = "Tipo actividad";
            this.TipoActividadChk.UseVisualStyleBackColor = true;
            this.TipoActividadChk.CheckedChanged += new System.EventHandler(this.TipoActividadChk_CheckedChanged);
            // 
            // FrmListadoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.ActividadGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Listado de Actividades";
            this.Load += new System.EventHandler(this.FrmListadoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActividadGrd;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTransporteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoActividadCbo;
        private System.Windows.Forms.CheckBox TipoActividadChk;
    }
}