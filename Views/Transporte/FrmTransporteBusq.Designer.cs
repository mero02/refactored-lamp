namespace TurApp.Views
{
    partial class FrmTransporteBusq
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
            this.DominioCbo = new System.Windows.Forms.ComboBox();
            this.DominioChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DominioCbo
            // 
            this.DominioCbo.DisplayMember = "Dominio";
            this.DominioCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DominioCbo.Enabled = false;
            this.DominioCbo.FormattingEnabled = true;
            this.DominioCbo.Location = new System.Drawing.Point(79, 58);
            this.DominioCbo.Margin = new System.Windows.Forms.Padding(2);
            this.DominioCbo.Name = "DominioCbo";
            this.DominioCbo.Size = new System.Drawing.Size(206, 21);
            this.DominioCbo.TabIndex = 13;
            this.DominioCbo.ValueMember = "Codigo";
            // 
            // DominioChk
            // 
            this.DominioChk.AutoSize = true;
            this.DominioChk.Location = new System.Drawing.Point(11, 58);
            this.DominioChk.Margin = new System.Windows.Forms.Padding(2);
            this.DominioChk.Name = "DominioChk";
            this.DominioChk.Size = new System.Drawing.Size(64, 17);
            this.DominioChk.TabIndex = 12;
            this.DominioChk.Text = "Dominio";
            this.DominioChk.UseVisualStyleBackColor = true;
            this.DominioChk.CheckedChanged += new System.EventHandler(this.DominioChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(174, 119);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 15;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(85, 119);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 14;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FrmTransporteBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 199);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.DominioCbo);
            this.Controls.Add(this.DominioChk);
            this.Name = "FrmTransporteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransporteBusq";
            this.Activated += new System.EventHandler(this.FrmTransporteBusq_Activated);
            this.Load += new System.EventHandler(this.FrmTransporteBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DominioCbo;
        private System.Windows.Forms.CheckBox DominioChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
    }
}