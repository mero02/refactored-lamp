namespace TurApp.Views
{
    partial class FrmListadoAgencias
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
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.AgenciasGrd = new System.Windows.Forms.DataGridView();
            this.NroAgenciaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PisoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DptoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocCbo = new System.Windows.Forms.ComboBox();
            this.LocChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgenciasGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(717, 22);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 3;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            // 
            // AgenciasGrd
            // 
            this.AgenciasGrd.AllowUserToAddRows = false;
            this.AgenciasGrd.AllowUserToDeleteRows = false;
            this.AgenciasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgenciasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroAgenciaCol,
            this.NombreCol,
            this.CalleCol,
            this.NroCol,
            this.PisoCol,
            this.DptoCol,
            this.LocCol,
            this.TelCol1,
            this.TelCol});
            this.AgenciasGrd.Location = new System.Drawing.Point(11, 74);
            this.AgenciasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.AgenciasGrd.MultiSelect = false;
            this.AgenciasGrd.Name = "AgenciasGrd";
            this.AgenciasGrd.ReadOnly = true;
            this.AgenciasGrd.RowTemplate.Height = 24;
            this.AgenciasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgenciasGrd.ShowEditingIcon = false;
            this.AgenciasGrd.Size = new System.Drawing.Size(826, 366);
            this.AgenciasGrd.TabIndex = 4;
            this.AgenciasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgenciasGrd_CellContentClick);
            // 
            // NroAgenciaCol
            // 
            this.NroAgenciaCol.DataPropertyName = "NroAgencia";
            this.NroAgenciaCol.HeaderText = "Nro Agencia";
            this.NroAgenciaCol.Name = "NroAgenciaCol";
            this.NroAgenciaCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombre";
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 80;
            // 
            // CalleCol
            // 
            this.CalleCol.DataPropertyName = "Calle";
            this.CalleCol.HeaderText = "Calle";
            this.CalleCol.Name = "CalleCol";
            this.CalleCol.ReadOnly = true;
            this.CalleCol.Width = 80;
            // 
            // NroCol
            // 
            this.NroCol.DataPropertyName = "Nro";
            this.NroCol.HeaderText = "Nro";
            this.NroCol.Name = "NroCol";
            this.NroCol.ReadOnly = true;
            this.NroCol.Width = 80;
            // 
            // PisoCol
            // 
            this.PisoCol.DataPropertyName = "Piso";
            this.PisoCol.HeaderText = "Piso";
            this.PisoCol.Name = "PisoCol";
            this.PisoCol.ReadOnly = true;
            this.PisoCol.Width = 80;
            // 
            // DptoCol
            // 
            this.DptoCol.DataPropertyName = "Dpto";
            this.DptoCol.HeaderText = "Dpto";
            this.DptoCol.Name = "DptoCol";
            this.DptoCol.ReadOnly = true;
            this.DptoCol.Width = 80;
            // 
            // LocCol
            // 
            this.LocCol.DataPropertyName = "Localidad";
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            this.LocCol.Width = 80;
            // 
            // TelCol1
            // 
            this.TelCol1.DataPropertyName = "Telefono1";
            this.TelCol1.HeaderText = "Telefono1";
            this.TelCol1.Name = "TelCol1";
            this.TelCol1.ReadOnly = true;
            this.TelCol1.Width = 80;
            // 
            // TelCol
            // 
            this.TelCol.DataPropertyName = "Telefono2";
            this.TelCol.HeaderText = "Telefono2";
            this.TelCol.Name = "TelCol";
            this.TelCol.ReadOnly = true;
            this.TelCol.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.NombreChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(69, 15);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(146, 20);
            this.NombreTxt.TabIndex = 1;
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocCbo);
            this.groupBox3.Controls.Add(this.LocChk);
            this.groupBox3.Location = new System.Drawing.Point(273, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 41);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // LocCbo
            // 
            this.LocCbo.DisplayMember = "Id";
            this.LocCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocCbo.Enabled = false;
            this.LocCbo.FormattingEnabled = true;
            this.LocCbo.Location = new System.Drawing.Point(90, 15);
            this.LocCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocCbo.Name = "LocCbo";
            this.LocCbo.Size = new System.Drawing.Size(115, 21);
            this.LocCbo.TabIndex = 1;
            this.LocCbo.ValueMember = "Nombre";
            this.LocCbo.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // LocChk
            // 
            this.LocChk.AutoSize = true;
            this.LocChk.Location = new System.Drawing.Point(10, 15);
            this.LocChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocChk.Name = "LocChk";
            this.LocChk.Size = new System.Drawing.Size(72, 17);
            this.LocChk.TabIndex = 0;
            this.LocChk.Text = "Localidad";
            this.LocChk.UseVisualStyleBackColor = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(728, 445);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 8;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoAgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 478);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AgenciasGrd);
            this.Controls.Add(this.FiltroBtn);
            this.Name = "FrmListadoAgencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Agencias";
            this.Load += new System.EventHandler(this.FrmListadoAgencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgenciasGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.DataGridView AgenciasGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocCbo;
        private System.Windows.Forms.CheckBox LocChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAgenciaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PisoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DptoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCol;
        private System.Windows.Forms.Button ExportarBtn;
    }
}