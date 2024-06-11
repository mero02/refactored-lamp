namespace TurApp.Views
{
    partial class FrmListadoFormaPago
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
            this.FormaPagoGrd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FormaPagoTxt = new System.Windows.Forms.TextBox();
            this.FormaPagoChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormaPagoGrd
            // 
            this.FormaPagoGrd.AllowUserToAddRows = false;
            this.FormaPagoGrd.AllowUserToDeleteRows = false;
            this.FormaPagoGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormaPagoGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.FormaCol});
            this.FormaPagoGrd.Location = new System.Drawing.Point(17, 54);
            this.FormaPagoGrd.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoGrd.MultiSelect = false;
            this.FormaPagoGrd.Name = "FormaPagoGrd";
            this.FormaPagoGrd.ReadOnly = true;
            this.FormaPagoGrd.RowTemplate.Height = 24;
            this.FormaPagoGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormaPagoGrd.ShowEditingIcon = false;
            this.FormaPagoGrd.Size = new System.Drawing.Size(826, 384);
            this.FormaPagoGrd.TabIndex = 6;
            this.FormaPagoGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormaPagoGrd_CellContentClick);
            this.FormaPagoGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FormaPagoGrd_DataBindingComplete);
            this.FormaPagoGrd.DoubleClick += new System.EventHandler(this.FormaPagoGrd_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormaPagoTxt);
            this.groupBox1.Controls.Add(this.FormaPagoChk);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // FormaPagoTxt
            // 
            this.FormaPagoTxt.Enabled = false;
            this.FormaPagoTxt.Location = new System.Drawing.Point(106, 14);
            this.FormaPagoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoTxt.Name = "FormaPagoTxt";
            this.FormaPagoTxt.Size = new System.Drawing.Size(146, 20);
            this.FormaPagoTxt.TabIndex = 1;
            // 
            // FormaPagoChk
            // 
            this.FormaPagoChk.AutoSize = true;
            this.FormaPagoChk.Location = new System.Drawing.Point(4, 17);
            this.FormaPagoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoChk.Name = "FormaPagoChk";
            this.FormaPagoChk.Size = new System.Drawing.Size(98, 17);
            this.FormaPagoChk.TabIndex = 0;
            this.FormaPagoChk.Text = "Forma de Pago";
            this.FormaPagoChk.UseVisualStyleBackColor = true;
            this.FormaPagoChk.CheckedChanged += new System.EventHandler(this.FormaPagoChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(709, 11);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 8;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(724, 443);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 11;
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
            // FormaCol
            // 
            this.FormaCol.DataPropertyName = "Forma";
            this.FormaCol.HeaderText = "Forma de pago";
            this.FormaCol.Name = "FormaCol";
            this.FormaCol.ReadOnly = true;
            this.FormaCol.Width = 150;
            // 
            // FrmListadoFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FormaPagoGrd);
            this.Name = "FrmListadoFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Formas de Pago";
            this.Load += new System.EventHandler(this.FrmListadoFormasPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FormaPagoGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FormaPagoTxt;
        private System.Windows.Forms.CheckBox FormaPagoChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaCol;
    }
}