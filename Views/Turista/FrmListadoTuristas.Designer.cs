namespace TurApp.Views
{
    partial class FrmListadoTuristas
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
            this.TuristasGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PaisCbo = new System.Windows.Forms.ComboBox();
            this.PaisChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TuristasGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TuristasGrd
            // 
            this.TuristasGrd.AllowUserToAddRows = false;
            this.TuristasGrd.AllowUserToDeleteRows = false;
            this.TuristasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TuristasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.NombreCol,
            this.PaisCol});
            this.TuristasGrd.Location = new System.Drawing.Point(9, 69);
            this.TuristasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TuristasGrd.MultiSelect = false;
            this.TuristasGrd.Name = "TuristasGrd";
            this.TuristasGrd.ReadOnly = true;
            this.TuristasGrd.RowTemplate.Height = 24;
            this.TuristasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TuristasGrd.ShowEditingIcon = false;
            this.TuristasGrd.Size = new System.Drawing.Size(826, 384);
            this.TuristasGrd.TabIndex = 0;
            this.TuristasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuristasGrd_CellContentClick);
            this.TuristasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TuristasGrd_DataBindingComplete);
            this.TuristasGrd.DoubleClick += new System.EventHandler(this.TuristasGrd_DoubleClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // PaisCol
            // 
            this.PaisCol.DataPropertyName = "Pais";
            this.PaisCol.HeaderText = "Pais";
            this.PaisCol.Name = "PaisCol";
            this.PaisCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.NombreChk);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(69, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(146, 20);
            this.ApellidoTxt.TabIndex = 1;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(4, 17);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 0;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(719, 18);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 2;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PaisCbo);
            this.groupBox3.Controls.Add(this.PaisChk);
            this.groupBox3.Location = new System.Drawing.Point(268, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // PaisCbo
            // 
            this.PaisCbo.DisplayMember = "Id";
            this.PaisCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisCbo.Enabled = false;
            this.PaisCbo.FormattingEnabled = true;
            this.PaisCbo.Location = new System.Drawing.Point(90, 15);
            this.PaisCbo.Margin = new System.Windows.Forms.Padding(2);
            this.PaisCbo.Name = "PaisCbo";
            this.PaisCbo.Size = new System.Drawing.Size(115, 21);
            this.PaisCbo.TabIndex = 1;
            this.PaisCbo.ValueMember = "Nombre";
            // 
            // PaisChk
            // 
            this.PaisChk.AutoSize = true;
            this.PaisChk.Location = new System.Drawing.Point(10, 15);
            this.PaisChk.Margin = new System.Windows.Forms.Padding(2);
            this.PaisChk.Name = "PaisChk";
            this.PaisChk.Size = new System.Drawing.Size(46, 17);
            this.PaisChk.TabIndex = 0;
            this.PaisChk.Text = "Pais";
            this.PaisChk.UseVisualStyleBackColor = true;
            this.PaisChk.CheckedChanged += new System.EventHandler(this.PaisChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(732, 458);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 9;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoTuristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TuristasGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTuristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Turistas";
            this.Load += new System.EventHandler(this.FrmListadoTuristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TuristasGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TuristasGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox PaisCbo;
        private System.Windows.Forms.CheckBox PaisChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisCol;
        private System.Windows.Forms.Button ExportarBtn;
    }
}