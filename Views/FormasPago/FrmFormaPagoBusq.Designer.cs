namespace TurApp.Views
{
    partial class FrmFormaPagoBusq
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
            this.FormaPagoChk = new System.Windows.Forms.CheckBox();
            this.FormaPagoCbo = new System.Windows.Forms.ComboBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormaPagoChk
            // 
            this.FormaPagoChk.AutoSize = true;
            this.FormaPagoChk.Location = new System.Drawing.Point(11, 38);
            this.FormaPagoChk.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoChk.Name = "FormaPagoChk";
            this.FormaPagoChk.Size = new System.Drawing.Size(98, 17);
            this.FormaPagoChk.TabIndex = 1;
            this.FormaPagoChk.Text = "Forma de Pago";
            this.FormaPagoChk.UseVisualStyleBackColor = true;
            this.FormaPagoChk.CheckedChanged += new System.EventHandler(this.FormaPagoChk_CheckedChanged);
            // 
            // FormaPagoCbo
            // 
            this.FormaPagoCbo.DisplayMember = "Forma";
            this.FormaPagoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagoCbo.Enabled = false;
            this.FormaPagoCbo.FormattingEnabled = true;
            this.FormaPagoCbo.Location = new System.Drawing.Point(113, 38);
            this.FormaPagoCbo.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoCbo.Name = "FormaPagoCbo";
            this.FormaPagoCbo.Size = new System.Drawing.Size(150, 21);
            this.FormaPagoCbo.TabIndex = 2;
            this.FormaPagoCbo.ValueMember = "Codigo";
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(60, 120);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(159, 120);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 4;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmFormaPagoBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 180);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.FormaPagoCbo);
            this.Controls.Add(this.FormaPagoChk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFormaPagoBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Forma de Pago...";
            this.Activated += new System.EventHandler(this.FrmFormaPagoBusq_Activated);
            this.Load += new System.EventHandler(this.FrmFormaPagoBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FormaPagoChk;
        private System.Windows.Forms.ComboBox FormaPagoCbo;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}