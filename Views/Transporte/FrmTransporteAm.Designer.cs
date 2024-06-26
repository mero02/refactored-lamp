namespace TurApp.Views
{
    partial class FrmTransporteAm
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
            this.DominioTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DominioTxt
            // 
            this.DominioTxt.Location = new System.Drawing.Point(91, 40);
            this.DominioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DominioTxt.MaxLength = 15;
            this.DominioTxt.Name = "DominioTxt";
            this.DominioTxt.Size = new System.Drawing.Size(80, 20);
            this.DominioTxt.TabIndex = 2;
            this.DominioTxt.Tag = "Dominio";
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(27, 40);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(45, 13);
            this.DniLbl.TabIndex = 1;
            this.DniLbl.Text = "&Dominio";
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(91, 104);
            this.ImporteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(166, 20);
            this.ImporteTxt.TabIndex = 6;
            this.ImporteTxt.Tag = "Importe";
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(27, 104);
            this.DomicilioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(42, 13);
            this.DomicilioLbl.TabIndex = 5;
            this.DomicilioLbl.Text = "Importe";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(91, 69);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTxt.MaxLength = 90;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(166, 20);
            this.DescripcionTxt.TabIndex = 4;
            this.DescripcionTxt.Tag = "Descripcion";
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(27, 69);
            this.NombresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(63, 13);
            this.NombresLbl.TabIndex = 3;
            this.NombresLbl.Text = "&Descripcion";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CancelarBtn.Location = new System.Drawing.Point(155, 165);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GuardarBtn.Location = new System.Drawing.Point(68, 165);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 7;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = false;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmTransporteAm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.DominioTxt);
            this.Controls.Add(this.DniLbl);
            this.Controls.Add(this.ImporteTxt);
            this.Controls.Add(this.DomicilioLbl);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.NombresLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransporteAm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Transporte";
            this.Load += new System.EventHandler(this.FrmTransporteAm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DominioTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
    }
}