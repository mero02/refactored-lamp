namespace TurApp.Views
{
    partial class FrmListPaqAgen
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
            this.PaquetesGrd = new System.Windows.Forms.DataGridView();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPaqueteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgenciaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniTuristaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).BeginInit();
            this.SuspendLayout();
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
            this.PaquetesGrd.Location = new System.Drawing.Point(11, 11);
            this.PaquetesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PaquetesGrd.MultiSelect = false;
            this.PaquetesGrd.Name = "PaquetesGrd";
            this.PaquetesGrd.ReadOnly = true;
            this.PaquetesGrd.RowTemplate.Height = 24;
            this.PaquetesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaquetesGrd.ShowEditingIcon = false;
            this.PaquetesGrd.Size = new System.Drawing.Size(743, 226);
            this.PaquetesGrd.TabIndex = 1;
            this.PaquetesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PaquetesGrd_DataBindingComplete);
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
            this.TipoPaqueteCol.HeaderText = "TipoPaquete";
            this.TipoPaqueteCol.Name = "TipoPaqueteCol";
            this.TipoPaqueteCol.ReadOnly = true;
            // 
            // AgenciaCol
            // 
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
            this.DestinoCol.HeaderText = "Destino";
            this.DestinoCol.Name = "DestinoCol";
            this.DestinoCol.ReadOnly = true;
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(670, 242);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(66, 32);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // FrmListPaqAgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 276);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.PaquetesGrd);
            this.MaximizeBox = false;
            this.Name = "FrmListPaqAgen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Paquetes en Agencia";
            this.Load += new System.EventHandler(this.FrmListPaqAgen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaquetesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PaquetesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPaqueteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgenciaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniTuristaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinoCol;
        private System.Windows.Forms.Button CerrarBtn;
    }
}