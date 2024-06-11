namespace TurApp.Views
{
    partial class FrmLocalidadAM
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CodPosLbl = new System.Windows.Forms.Label();
            this.NobreLbl = new System.Windows.Forms.Label();
            this.CodPosTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(34, 143);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(148, 143);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CodPosLbl
            // 
            this.CodPosLbl.AutoSize = true;
            this.CodPosLbl.Location = new System.Drawing.Point(31, 36);
            this.CodPosLbl.Name = "CodPosLbl";
            this.CodPosLbl.Size = new System.Drawing.Size(24, 13);
            this.CodPosLbl.TabIndex = 1;
            this.CodPosLbl.Text = "C.P";
            // 
            // NobreLbl
            // 
            this.NobreLbl.AutoSize = true;
            this.NobreLbl.Location = new System.Drawing.Point(31, 100);
            this.NobreLbl.Name = "NobreLbl";
            this.NobreLbl.Size = new System.Drawing.Size(44, 13);
            this.NobreLbl.TabIndex = 3;
            this.NobreLbl.Text = "Nombre";
            // 
            // CodPosTxt
            // 
            this.CodPosTxt.Location = new System.Drawing.Point(81, 33);
            this.CodPosTxt.Name = "CodPosTxt";
            this.CodPosTxt.Size = new System.Drawing.Size(61, 20);
            this.CodPosTxt.TabIndex = 2;
            this.CodPosTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodPosTxt_KeyPress);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(81, 97);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(133, 20);
            this.NombreTxt.TabIndex = 4;
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // FrmLocalidadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 220);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.CodPosTxt);
            this.Controls.Add(this.NobreLbl);
            this.Controls.Add(this.CodPosLbl);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "FrmLocalidadAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmLocalidadAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmLocalidadAM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label CodPosLbl;
        private System.Windows.Forms.Label NobreLbl;
        private System.Windows.Forms.TextBox CodPosTxt;
        private System.Windows.Forms.TextBox NombreTxt;
    }
}