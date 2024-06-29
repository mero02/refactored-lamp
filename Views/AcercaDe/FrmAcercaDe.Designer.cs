namespace TurApp.Views
{
    partial class FrmAcercaDe
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
            this.textBoxAcercaDe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxAcercaDe
            // 
            this.textBoxAcercaDe.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAcercaDe.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxAcercaDe.Location = new System.Drawing.Point(12, 12);
            this.textBoxAcercaDe.Name = "textBoxAcercaDe";
            this.textBoxAcercaDe.ReadOnly = true;
            this.textBoxAcercaDe.Size = new System.Drawing.Size(385, 265);
            this.textBoxAcercaDe.TabIndex = 0;
            this.textBoxAcercaDe.Text = "";
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 292);
            this.Controls.Add(this.textBoxAcercaDe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca De Nosotros";
            this.Load += new System.EventHandler(this.FrmAcercaDe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxAcercaDe;
    }
}