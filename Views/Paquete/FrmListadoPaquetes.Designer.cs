namespace TurApp.Views
{
    partial class FrmListadoPaquetes
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
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoPaqueteTxt = new System.Windows.Forms.TextBox();
            this.TipoPaqueteChk = new System.Windows.Forms.CheckBox();
            this.PaquetesGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPaqueteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgenciaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniTuristaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(560, 303);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 20;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(568, 11);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 19;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoPaqueteTxt);
            this.groupBox1.Controls.Add(this.TipoPaqueteChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(268, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // TipoPaqueteTxt
            // 
            this.TipoPaqueteTxt.Enabled = false;
            this.TipoPaqueteTxt.Location = new System.Drawing.Point(98, 15);
            this.TipoPaqueteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteTxt.Name = "TipoPaqueteTxt";
            this.TipoPaqueteTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoPaqueteTxt.TabIndex = 1;
            // 
            // TipoPaqueteChk
            // 
            this.TipoPaqueteChk.AutoSize = true;
            this.TipoPaqueteChk.Location = new System.Drawing.Point(4, 17);
            this.TipoPaqueteChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteChk.Name = "TipoPaqueteChk";
            this.TipoPaqueteChk.Size = new System.Drawing.Size(90, 17);
            this.TipoPaqueteChk.TabIndex = 0;
            this.TipoPaqueteChk.Text = "Tipo Paquete";
            this.TipoPaqueteChk.UseVisualStyleBackColor = true;
            this.TipoPaqueteChk.CheckedChanged += new System.EventHandler(this.TipoPaqueteChk_CheckedChanged);
            // 
            // PaquetesGrd
            // 
            this.PaquetesGrd.AllowUserToAddRows = false;
            this.PaquetesGrd.AllowUserToDeleteRows = false;
            this.PaquetesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaquetesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.TipoPaqueteCol,
            this.AgenciaCol,
            this.FechaCol,
            this.DniTuristaCol,
            this.NivelCol,
            this.DestinoCol});
            this.PaquetesGrd.Location = new System.Drawing.Point(0, 72);
            this.PaquetesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PaquetesGrd.MultiSelect = false;
            this.PaquetesGrd.Name = "PaquetesGrd";
            this.PaquetesGrd.ReadOnly = true;
            this.PaquetesGrd.RowTemplate.Height = 24;
            this.PaquetesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaquetesGrd.ShowEditingIcon = false;
            this.PaquetesGrd.Size = new System.Drawing.Size(743, 226);
            this.PaquetesGrd.TabIndex = 17;
            this.PaquetesGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaquetesGrd_CellContentClick);
            this.PaquetesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PaquetesGrd_ColumnHeaderMouseClick);
            this.PaquetesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PaquetesGrd_DataBindingComplete);
            this.PaquetesGrd.DoubleClick += new System.EventHandler(this.PaquetesGrd_DoubleClick);
            // 
            // CodigoCol
            // 
            this.CodigoCol.DataPropertyName = "Codigo";
            this.CodigoCol.HeaderText = "Codigo";
            this.CodigoCol.Name = "CodigoCol";
            this.CodigoCol.ReadOnly = true;
            // 
            // TipoPaqueteCol
            // 
            this.TipoPaqueteCol.DataPropertyName = "CodTipoPaquete";
            this.TipoPaqueteCol.HeaderText = "TipoPaquete";
            this.TipoPaqueteCol.Name = "TipoPaqueteCol";
            this.TipoPaqueteCol.ReadOnly = true;
            // 
            // AgenciaCol
            // 
            this.AgenciaCol.DataPropertyName = "CodAgencia";
            this.AgenciaCol.HeaderText = "Agencia";
            this.AgenciaCol.Name = "AgenciaCol";
            this.AgenciaCol.ReadOnly = true;
            // 
            // FechaCol
            // 
            this.FechaCol.DataPropertyName = "Fecha";
            this.FechaCol.HeaderText = "Fecha";
            this.FechaCol.Name = "FechaCol";
            this.FechaCol.ReadOnly = true;
            // 
            // DniTuristaCol
            // 
            this.DniTuristaCol.DataPropertyName = "DniTurista";
            this.DniTuristaCol.HeaderText = "Dni Turista";
            this.DniTuristaCol.Name = "DniTuristaCol";
            this.DniTuristaCol.ReadOnly = true;
            // 
            // NivelCol
            // 
            this.NivelCol.DataPropertyName = "Nivel";
            this.NivelCol.HeaderText = "Nivel";
            this.NivelCol.Name = "NivelCol";
            this.NivelCol.ReadOnly = true;
            // 
            // DestinoCol
            // 
            this.DestinoCol.DataPropertyName = "CodDestino";
            this.DestinoCol.HeaderText = "Destino";
            this.DestinoCol.Name = "DestinoCol";
            this.DestinoCol.ReadOnly = true;
            // 
            // FrmListadoPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 351);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PaquetesGrd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListadoPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Paquetes";
            this.Load += new System.EventHandler(this.FrmListadoPaquetes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TipoPaqueteTxt;
        private System.Windows.Forms.CheckBox TipoPaqueteChk;
        private System.Windows.Forms.DataGridView PaquetesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPaqueteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgenciaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniTuristaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinoCol;
    }
}