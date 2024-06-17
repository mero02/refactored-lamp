namespace TurApp.Views
{
    partial class FrmTipoPaqueteList
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
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.TipoPaquetesGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TipoPaquetesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(253, 262);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(129, 27);
            this.CerrarBtn.TabIndex = 11;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click_1);
            // 
            // TipoPaquetesGrd
            // 
            this.TipoPaquetesGrd.AllowUserToAddRows = false;
            this.TipoPaquetesGrd.AllowUserToDeleteRows = false;
            this.TipoPaquetesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoPaquetesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCol,
            this.NombreCol,
            this.DescripcionCol,
            this.DuracionCol,
            this.NivelCol});
            this.TipoPaquetesGrd.Location = new System.Drawing.Point(11, 47);
            this.TipoPaquetesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaquetesGrd.MultiSelect = false;
            this.TipoPaquetesGrd.Name = "TipoPaquetesGrd";
            this.TipoPaquetesGrd.ReadOnly = true;
            this.TipoPaquetesGrd.RowTemplate.Height = 24;
            this.TipoPaquetesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TipoPaquetesGrd.ShowEditingIcon = false;
            this.TipoPaquetesGrd.Size = new System.Drawing.Size(640, 191);
            this.TipoPaquetesGrd.TabIndex = 10;
            this.TipoPaquetesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TipoPaquetesGrd_DataBindingComplete);
            this.TipoPaquetesGrd.DoubleClick += new System.EventHandler(this.TipoPaquetesGrd_DoubleClick);
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
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
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
            this.DescripcionCol.Width = 150;
            // 
            // DuracionCol
            // 
            this.DuracionCol.DataPropertyName = "Duracion";
            this.DuracionCol.HeaderText = "Duracion";
            this.DuracionCol.Name = "DuracionCol";
            this.DuracionCol.ReadOnly = true;
            // 
            // NivelCol
            // 
            this.NivelCol.DataPropertyName = "Nivel";
            this.NivelCol.HeaderText = "Nivel";
            this.NivelCol.Name = "NivelCol";
            this.NivelCol.ReadOnly = true;
            // 
            // FrmTipoPaqueteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 299);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.TipoPaquetesGrd);
            this.MaximizeBox = false;
            this.Name = "FrmTipoPaqueteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Tipo Paquete";
            this.Activated += new System.EventHandler(this.FrmTipoPaqueteList_Load);
            this.Load += new System.EventHandler(this.FrmTipoPaqueteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoPaquetesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView TipoPaquetesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
    }
}