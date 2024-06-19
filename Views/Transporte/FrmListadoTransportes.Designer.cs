namespace TurApp.Views
{
    partial class FrmListadoTransportes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DominioTxt = new System.Windows.Forms.TextBox();
            this.DominioChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.TransportesGrd = new System.Windows.Forms.DataGridView();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.CodCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DominioTxt);
            this.groupBox1.Controls.Add(this.DominioChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DominioTxt
            // 
            this.DominioTxt.Enabled = false;
            this.DominioTxt.Location = new System.Drawing.Point(69, 15);
            this.DominioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DominioTxt.Name = "DominioTxt";
            this.DominioTxt.Size = new System.Drawing.Size(146, 20);
            this.DominioTxt.TabIndex = 1;
            // 
            // DominioChk
            // 
            this.DominioChk.AutoSize = true;
            this.DominioChk.Location = new System.Drawing.Point(4, 17);
            this.DominioChk.Margin = new System.Windows.Forms.Padding(2);
            this.DominioChk.Name = "DominioChk";
            this.DominioChk.Size = new System.Drawing.Size(64, 17);
            this.DominioChk.TabIndex = 0;
            this.DominioChk.Text = "Dominio";
            this.DominioChk.UseVisualStyleBackColor = true;
            this.DominioChk.CheckedChanged += new System.EventHandler(this.DominioChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(623, 14);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 3;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // TransportesGrd
            // 
            this.TransportesGrd.AllowUserToAddRows = false;
            this.TransportesGrd.AllowUserToDeleteRows = false;
            this.TransportesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCol,
            this.DomCol,
            this.DesCol,
            this.Importe});
            this.TransportesGrd.Location = new System.Drawing.Point(11, 57);
            this.TransportesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TransportesGrd.MultiSelect = false;
            this.TransportesGrd.Name = "TransportesGrd";
            this.TransportesGrd.ReadOnly = true;
            this.TransportesGrd.RowTemplate.Height = 24;
            this.TransportesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransportesGrd.ShowEditingIcon = false;
            this.TransportesGrd.Size = new System.Drawing.Size(718, 315);
            this.TransportesGrd.TabIndex = 4;
            this.TransportesGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransportesGrd_CellContentClick);
            this.TransportesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TransportesGrd_ColumnHeaderMouseClick);
            this.TransportesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TransportesGrd_DataBindingComplete);
            this.TransportesGrd.DoubleClick += new System.EventHandler(this.TransportesGrd_DoubleClick);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(623, 377);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 10;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // CodCol
            // 
            this.CodCol.DataPropertyName = "Codigo";
            this.CodCol.HeaderText = "Codigo";
            this.CodCol.Name = "CodCol";
            this.CodCol.ReadOnly = true;
            // 
            // DomCol
            // 
            this.DomCol.DataPropertyName = "Dominio";
            this.DomCol.HeaderText = "Dominio";
            this.DomCol.Name = "DomCol";
            this.DomCol.ReadOnly = true;
            // 
            // DesCol
            // 
            this.DesCol.DataPropertyName = "Descripcion";
            this.DesCol.HeaderText = "Descripcion";
            this.DesCol.Name = "DesCol";
            this.DesCol.ReadOnly = true;
            this.DesCol.Width = 300;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // FrmListadoTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.TransportesGrd);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTransportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Transportes";
            this.Load += new System.EventHandler(this.FrmListadoTransportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DominioTxt;
        private System.Windows.Forms.CheckBox DominioChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.DataGridView TransportesGrd;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}