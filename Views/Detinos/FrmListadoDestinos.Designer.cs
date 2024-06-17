namespace TurApp.Views
{
    partial class FrmListadoDestinos
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
            this.DestinosGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DestinosGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestinosGrd
            // 
            this.DestinosGrd.AllowUserToAddRows = false;
            this.DestinosGrd.AllowUserToDeleteRows = false;
            this.DestinosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.NombreCol,
            this.DescripcionCol,
            this.CantCol});
            this.DestinosGrd.Location = new System.Drawing.Point(17, 65);
            this.DestinosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.DestinosGrd.MultiSelect = false;
            this.DestinosGrd.Name = "DestinosGrd";
            this.DestinosGrd.ReadOnly = true;
            this.DestinosGrd.RowTemplate.Height = 24;
            this.DestinosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DestinosGrd.ShowEditingIcon = false;
            this.DestinosGrd.Size = new System.Drawing.Size(826, 384);
            this.DestinosGrd.TabIndex = 1;
            this.DestinosGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestinosGrd_CellContentClick);
            this.DestinosGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DestinosGrd_ColumnHeaderMouseClick);
            this.DestinosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DestinosGrd_DataBindingComplete);
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
            this.NombreCol.HeaderText = "Nombre";
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
            this.DescripcionCol.Width = 400;
            // 
            // CantCol
            // 
            this.CantCol.DataPropertyName = "Cantidad";
            this.CantCol.HeaderText = "Cantidad";
            this.CantCol.Name = "CantCol";
            this.CantCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.NombreChk);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 2;
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
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(724, 18);
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
            this.ExportarBtn.Location = new System.Drawing.Point(740, 455);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 10;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // FrmListadoDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DestinosGrd);
            this.MaximizeBox = false;
            this.Name = "FrmListadoDestinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Destinos";
            this.Load += new System.EventHandler(this.FrmListadoDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DestinosGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DestinosGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCol;
    }
}