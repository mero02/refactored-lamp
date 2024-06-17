namespace TurApp.Views
{
    partial class FrmTipoActividadAM
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(103, 26);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.MaxLength = 15;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(80, 20);
            this.NombreTxt.TabIndex = 25;
            this.NombreTxt.Tag = "Nombre";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(39, 26);
            this.NombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 32;
            this.NombreLbl.Text = "&Nombre";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(103, 123);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(166, 20);
            this.NivelTxt.TabIndex = 28;
            this.NivelTxt.Tag = "Nivel";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(39, 124);
            this.NivelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(31, 13);
            this.NivelLbl.TabIndex = 31;
            this.NivelLbl.Text = "&Nivel";
            // 
            // DuracionTxt
            // 
            this.DuracionTxt.Location = new System.Drawing.Point(103, 90);
            this.DuracionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DuracionTxt.Name = "DuracionTxt";
            this.DuracionTxt.Size = new System.Drawing.Size(166, 20);
            this.DuracionTxt.TabIndex = 27;
            this.DuracionTxt.Tag = "Duracion";
            // 
            // DuracionLbl
            // 
            this.DuracionLbl.AutoSize = true;
            this.DuracionLbl.Location = new System.Drawing.Point(39, 90);
            this.DuracionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DuracionLbl.Name = "DuracionLbl";
            this.DuracionLbl.Size = new System.Drawing.Size(50, 13);
            this.DuracionLbl.TabIndex = 30;
            this.DuracionLbl.Text = "&Duracion";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(103, 55);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTxt.MaxLength = 90;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(166, 20);
            this.DescripcionTxt.TabIndex = 26;
            this.DescripcionTxt.Tag = "Descripcion";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(39, 55);
            this.DescripcionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLbl.TabIndex = 29;
            this.DescripcionLbl.Text = "&Descripcion";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(120, 166);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(61, 27);
            this.GuardarBtn.TabIndex = 33;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(208, 166);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 34;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmTipoActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 223);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.NivelTxt);
            this.Controls.Add(this.NivelLbl);
            this.Controls.Add(this.DuracionTxt);
            this.Controls.Add(this.DuracionLbl);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.DescripcionLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoActividadAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso nuevo Tipo Actividad";
            this.Load += new System.EventHandler(this.FrmTipoActividadAM_Load);
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
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}