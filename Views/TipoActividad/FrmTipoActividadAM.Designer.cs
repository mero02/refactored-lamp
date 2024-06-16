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
            this.NombreTxt.Location = new System.Drawing.Point(154, 40);
            this.NombreTxt.MaxLength = 15;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(118, 26);
            this.NombreTxt.TabIndex = 25;
            this.NombreTxt.Tag = "Nombre";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(58, 40);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(65, 20);
            this.NombreLbl.TabIndex = 32;
            this.NombreLbl.Text = "&Nombre";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(154, 189);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(247, 26);
            this.NivelTxt.TabIndex = 28;
            this.NivelTxt.Tag = "Nivel";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(58, 191);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(42, 20);
            this.NivelLbl.TabIndex = 31;
            this.NivelLbl.Text = "&Nivel";
            // 
            // DuracionTxt
            // 
            this.DuracionTxt.Location = new System.Drawing.Point(154, 139);
            this.DuracionTxt.Name = "DuracionTxt";
            this.DuracionTxt.Size = new System.Drawing.Size(247, 26);
            this.DuracionTxt.TabIndex = 27;
            this.DuracionTxt.Tag = "Duracion";
            // 
            // DuracionLbl
            // 
            this.DuracionLbl.AutoSize = true;
            this.DuracionLbl.Location = new System.Drawing.Point(58, 139);
            this.DuracionLbl.Name = "DuracionLbl";
            this.DuracionLbl.Size = new System.Drawing.Size(73, 20);
            this.DuracionLbl.TabIndex = 30;
            this.DuracionLbl.Text = "&Duracion";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(154, 85);
            this.DescripcionTxt.MaxLength = 90;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(247, 26);
            this.DescripcionTxt.TabIndex = 26;
            this.DescripcionTxt.Tag = "Descripcion";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(58, 85);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(92, 20);
            this.DescripcionLbl.TabIndex = 29;
            this.DescripcionLbl.Text = "&Descripcion";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(180, 255);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(92, 42);
            this.GuardarBtn.TabIndex = 33;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(312, 255);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(88, 42);
            this.CancelarBtn.TabIndex = 34;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmTipoActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 343);
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
            this.Name = "FrmTipoActividadAM";
            this.Text = "FrmTipoActividadAM";
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