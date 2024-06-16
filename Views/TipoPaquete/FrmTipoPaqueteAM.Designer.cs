namespace TurApp.Views
{
    partial class FrmTipoPaqueteAM
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
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.NivelLbl = new System.Windows.Forms.Label();
            this.DuracionTxt = new System.Windows.Forms.TextBox();
            this.DuracionLbl = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.ActividadesGrupBox = new System.Windows.Forms.GroupBox();
            this.QuitarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ActividadesGrd = new System.Windows.Forms.DataGridView();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CodActCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadesGrupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(80, 43);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.MaxLength = 15;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(80, 20);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(16, 43);
            this.NombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 24;
            this.NombreLbl.Text = "&Nombre";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(80, 140);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(166, 20);
            this.NivelTxt.TabIndex = 4;
            this.NivelTxt.Tag = "Nivel";
            this.NivelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NivelTxt_KeyPress);
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(16, 141);
            this.NivelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(31, 13);
            this.NivelLbl.TabIndex = 23;
            this.NivelLbl.Text = "&Nivel";
            // 
            // DuracionTxt
            // 
            this.DuracionTxt.Location = new System.Drawing.Point(80, 107);
            this.DuracionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DuracionTxt.Name = "DuracionTxt";
            this.DuracionTxt.Size = new System.Drawing.Size(166, 20);
            this.DuracionTxt.TabIndex = 3;
            this.DuracionTxt.Tag = "Duracion";
            this.DuracionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DuracionTxt_KeyPress);
            // 
            // DuracionLbl
            // 
            this.DuracionLbl.AutoSize = true;
            this.DuracionLbl.Location = new System.Drawing.Point(16, 107);
            this.DuracionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DuracionLbl.Name = "DuracionLbl";
            this.DuracionLbl.Size = new System.Drawing.Size(50, 13);
            this.DuracionLbl.TabIndex = 22;
            this.DuracionLbl.Text = "&Duracion";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(80, 72);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTxt.MaxLength = 90;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(166, 20);
            this.DescripcionTxt.TabIndex = 2;
            this.DescripcionTxt.Tag = "Descripcion";
            this.DescripcionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTxt_KeyPress);
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(16, 72);
            this.DescripcionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLbl.TabIndex = 20;
            this.DescripcionLbl.Text = "&Descripcion";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(187, 267);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ActividadesGrupBox
            // 
            this.ActividadesGrupBox.Controls.Add(this.QuitarBtn);
            this.ActividadesGrupBox.Controls.Add(this.AgregarBtn);
            this.ActividadesGrupBox.Controls.Add(this.ActividadesGrd);
            this.ActividadesGrupBox.Location = new System.Drawing.Point(353, 5);
            this.ActividadesGrupBox.Name = "ActividadesGrupBox";
            this.ActividadesGrupBox.Size = new System.Drawing.Size(452, 320);
            this.ActividadesGrupBox.TabIndex = 27;
            this.ActividadesGrupBox.TabStop = false;
            this.ActividadesGrupBox.Text = "Actividades";
            // 
            // QuitarBtn
            // 
            this.QuitarBtn.Location = new System.Drawing.Point(233, 262);
            this.QuitarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuitarBtn.Name = "QuitarBtn";
            this.QuitarBtn.Size = new System.Drawing.Size(59, 27);
            this.QuitarBtn.TabIndex = 6;
            this.QuitarBtn.Text = "&Quitar";
            this.QuitarBtn.UseVisualStyleBackColor = true;
            this.QuitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(123, 262);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(59, 27);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Text = "&Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ActividadesGrd
            // 
            this.ActividadesGrd.AllowUserToAddRows = false;
            this.ActividadesGrd.AllowUserToDeleteRows = false;
            this.ActividadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodActCol,
            this.NombreActividadCol});
            this.ActividadesGrd.Location = new System.Drawing.Point(17, 26);
            this.ActividadesGrd.MultiSelect = false;
            this.ActividadesGrd.Name = "ActividadesGrd";
            this.ActividadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadesGrd.Size = new System.Drawing.Size(397, 216);
            this.ActividadesGrd.TabIndex = 0;
            this.ActividadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ActividadedsGrd_DataBindingComplete);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(99, 267);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(61, 27);
            this.GuardarBtn.TabIndex = 7;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CodActCol
            // 
            this.CodActCol.DataPropertyName = "Codigo";
            this.CodActCol.HeaderText = "Codigo";
            this.CodActCol.Name = "CodActCol";
            // 
            // NombreActividadCol
            // 
            this.NombreActividadCol.DataPropertyName = "Nombre";
            this.NombreActividadCol.HeaderText = "Nombre Actividad";
            this.NombreActividadCol.Name = "NombreActividadCol";
            this.NombreActividadCol.Width = 250;
            // 
            // FrmTipoPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 366);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.ActividadesGrupBox);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.NivelTxt);
            this.Controls.Add(this.NivelLbl);
            this.Controls.Add(this.DuracionTxt);
            this.Controls.Add(this.DuracionLbl);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.DescripcionLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoPaqueteAM";
            this.Text = "FrmTipoPaqueteAM";
            this.Deactivate += new System.EventHandler(this.FrmTipoPaqueteAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmTipoPaqueteAM_Load);
            this.ActividadesGrupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.TextBox DuracionTxt;
        private System.Windows.Forms.Label DuracionLbl;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.GroupBox ActividadesGrupBox;
        private System.Windows.Forms.DataGridView ActividadesGrd;
        private System.Windows.Forms.Button QuitarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodActCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreActividadCol;
    }
}