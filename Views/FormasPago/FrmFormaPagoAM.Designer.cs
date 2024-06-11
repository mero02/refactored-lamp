namespace TurApp.Views
{
    partial class FrmFormaPagoAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FormaPagoTxt = new System.Windows.Forms.TextBox();
            this.FormaPagoLbl = new System.Windows.Forms.Label();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormaPagoTxt);
            this.groupBox1.Controls.Add(this.FormaPagoLbl);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FormaPagoTxt
            // 
            this.FormaPagoTxt.Location = new System.Drawing.Point(74, 22);
            this.FormaPagoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoTxt.MaxLength = 15;
            this.FormaPagoTxt.Name = "FormaPagoTxt";
            this.FormaPagoTxt.Size = new System.Drawing.Size(160, 20);
            this.FormaPagoTxt.TabIndex = 0;
            this.FormaPagoTxt.Tag = "FormaPago";
            // 
            // FormaPagoLbl
            // 
            this.FormaPagoLbl.AutoSize = true;
            this.FormaPagoLbl.Location = new System.Drawing.Point(10, 22);
            this.FormaPagoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormaPagoLbl.Name = "FormaPagoLbl";
            this.FormaPagoLbl.Size = new System.Drawing.Size(61, 13);
            this.FormaPagoLbl.TabIndex = 16;
            this.FormaPagoLbl.Text = "&FormaPago";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(132, 98);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 12;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(219, 98);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 13;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmFormaPagoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 148);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFormaPagoAM";
            this.Deactivate += new System.EventHandler(this.FrmFormaPagoAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmFormaPagoAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FormaPagoTxt;
        private System.Windows.Forms.Label FormaPagoLbl;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}