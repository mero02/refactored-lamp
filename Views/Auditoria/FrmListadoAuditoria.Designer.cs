namespace TurApp.Views
{
    partial class FrmListadoAuditoria
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
            this.AuditoriasGrd = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(751, 443);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 14;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // AuditoriasGrd
            // 
            this.AuditoriasGrd.AllowUserToAddRows = false;
            this.AuditoriasGrd.AllowUserToDeleteRows = false;
            this.AuditoriasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuditoriasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.objeto,
            this.fecha,
            this.operacion,
            this.detalle});
            this.AuditoriasGrd.Location = new System.Drawing.Point(17, 24);
            this.AuditoriasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.AuditoriasGrd.MultiSelect = false;
            this.AuditoriasGrd.Name = "AuditoriasGrd";
            this.AuditoriasGrd.ReadOnly = true;
            this.AuditoriasGrd.RowTemplate.Height = 24;
            this.AuditoriasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuditoriasGrd.ShowEditingIcon = false;
            this.AuditoriasGrd.Size = new System.Drawing.Size(826, 414);
            this.AuditoriasGrd.TabIndex = 13;
            this.AuditoriasGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuditoriasGrd_CellContentClick);
            this.AuditoriasGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AuditoriasGrd_ColumnHeaderMouseClick);
            this.AuditoriasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AuditoriasGrd_DataBindingComplete);
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // objeto
            // 
            this.objeto.HeaderText = "Objeto";
            this.objeto.Name = "objeto";
            this.objeto.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // operacion
            // 
            this.operacion.HeaderText = "Operacion";
            this.operacion.Name = "operacion";
            this.operacion.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            // 
            // FrmListadoAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 493);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.AuditoriasGrd);
            this.MaximizeBox = false;
            this.Name = "FrmListadoAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoAuditoria";
            this.Load += new System.EventHandler(this.FrmListadoAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriasGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridView AuditoriasGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn objeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
    }
}