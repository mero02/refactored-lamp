namespace TurApp.Views
{
    partial class FrmTransporteList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TransportesGrd = new System.Windows.Forms.DataGridView();
            this.CodCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(489, 301);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 8;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TransportesGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(563, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // TransportesGrd
            // 
            this.TransportesGrd.AllowUserToAddRows = false;
            this.TransportesGrd.AllowUserToDeleteRows = false;
            this.TransportesGrd.AllowUserToResizeColumns = false;
            this.TransportesGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransportesGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TransportesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCol,
            this.DomCol,
            this.DesCol,
            this.ImpCol});
            this.TransportesGrd.Location = new System.Drawing.Point(4, 17);
            this.TransportesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TransportesGrd.MultiSelect = false;
            this.TransportesGrd.Name = "TransportesGrd";
            this.TransportesGrd.ReadOnly = true;
            this.TransportesGrd.RowTemplate.Height = 24;
            this.TransportesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransportesGrd.Size = new System.Drawing.Size(551, 237);
            this.TransportesGrd.TabIndex = 0;
            this.TransportesGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransportesGrd_CellContentClick);
            this.TransportesGrd.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TransportesGrd_ColumnHeaderMouseClick);
            this.TransportesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TransportesGrd_DataBindingComplete);
            this.TransportesGrd.DoubleClick += new System.EventHandler(this.TransportesGrd_DoubleClick);
            // 
            // CodCol
            // 
            this.CodCol.DataPropertyName = "Codigo";
            this.CodCol.HeaderText = "Codigo";
            this.CodCol.Name = "CodCol";
            this.CodCol.ReadOnly = true;
            this.CodCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CodCol.Width = 130;
            // 
            // DomCol
            // 
            this.DomCol.DataPropertyName = "Dominio";
            this.DomCol.HeaderText = "Dominio";
            this.DomCol.Name = "DomCol";
            this.DomCol.ReadOnly = true;
            this.DomCol.Width = 80;
            // 
            // DesCol
            // 
            this.DesCol.DataPropertyName = "Descripcion";
            this.DesCol.HeaderText = "Descripcion";
            this.DesCol.Name = "DesCol";
            this.DesCol.ReadOnly = true;
            this.DesCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DesCol.Width = 150;
            // 
            // ImpCol
            // 
            this.ImpCol.DataPropertyName = "Importe";
            this.ImpCol.HeaderText = "Importe";
            this.ImpCol.Name = "ImpCol";
            this.ImpCol.ReadOnly = true;
            this.ImpCol.Width = 140;
            // 
            // FrmTransporteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CerrarBtn);
            this.MaximizeBox = false;
            this.Name = "FrmTransporteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransporteList";
            this.Load += new System.EventHandler(this.FrmTransporteList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransportesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TransportesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpCol;
    }
}