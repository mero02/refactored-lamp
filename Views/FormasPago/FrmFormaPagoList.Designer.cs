namespace TurApp.Views
{
    partial class FrmFormaPagoList
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
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaPagoGrd
            // 
            this.FormaPagoGrd.AllowUserToAddRows = false;
            this.FormaPagoGrd.AllowUserToDeleteRows = false;
            this.FormaPagoGrd.AllowUserToResizeColumns = false;
            this.FormaPagoGrd.AllowUserToResizeRows = false;
            this.FormaPagoGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormaPagoGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.FormaCol});
            this.FormaPagoGrd.Location = new System.Drawing.Point(11, 21);
            this.FormaPagoGrd.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoGrd.MultiSelect = false;
            this.FormaPagoGrd.Name = "FormaPagoGrd";
            this.FormaPagoGrd.ReadOnly = true;
            this.FormaPagoGrd.RowTemplate.Height = 24;
            this.FormaPagoGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FormaPagoGrd.ShowEditingIcon = false;
            this.FormaPagoGrd.Size = new System.Drawing.Size(294, 76);
            this.FormaPagoGrd.TabIndex = 1;
            this.FormaPagoGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FormaPagoGrd_ColumnHeaderMouseClick);
            this.FormaPagoGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FormaPagoGrd_DataBindingComplete);
            this.FormaPagoGrd.DoubleClick += new System.EventHandler(this.FormaPagoGrd_DoubleClick);
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
            this.FormaCol.HeaderText = "Forma";
            this.FormaCol.Name = "FormaCol";
            this.FormaCol.ReadOnly = true;
            this.FormaCol.Width = 150;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(125, 116);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FrmFormaPagoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.FormaPagoGrd);
            this.MaximizeBox = false;
            this.Name = "FrmFormaPagoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Formas de Pago";
            this.Activated += new System.EventHandler(this.FrmFormaPagoList_Load);
            this.Load += new System.EventHandler(this.FrmFormaPagoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormaPagoGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FormaPagoGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaCol;
    }
}