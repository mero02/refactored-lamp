namespace TurApp.Views
{
    partial class FrmTipoPaqueteBusq
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
            this.TipoPaqueteCbo = new System.Windows.Forms.ComboBox();
            this.TipoPaqueteChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipoPaqueteCbo
            // 
            this.TipoPaqueteCbo.DisplayMember = "Nombre";
            this.TipoPaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPaqueteCbo.Enabled = false;
            this.TipoPaqueteCbo.FormattingEnabled = true;
            this.TipoPaqueteCbo.Location = new System.Drawing.Point(106, 59);
            this.TipoPaqueteCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteCbo.Name = "TipoPaqueteCbo";
            this.TipoPaqueteCbo.Size = new System.Drawing.Size(150, 21);
            this.TipoPaqueteCbo.TabIndex = 14;
            this.TipoPaqueteCbo.ValueMember = "Codigo";
            // 
            // TipoPaqueteChk
            // 
            this.TipoPaqueteChk.AutoSize = true;
            this.TipoPaqueteChk.Location = new System.Drawing.Point(12, 61);
            this.TipoPaqueteChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteChk.Name = "TipoPaqueteChk";
            this.TipoPaqueteChk.Size = new System.Drawing.Size(90, 17);
            this.TipoPaqueteChk.TabIndex = 13;
            this.TipoPaqueteChk.Text = "Tipo Paquete";
            this.TipoPaqueteChk.UseVisualStyleBackColor = true;
            this.TipoPaqueteChk.CheckedChanged += new System.EventHandler(this.TipoPaqueteChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(164, 117);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 16;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(63, 117);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 15;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FrmTipoPaqueteBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TipoPaqueteCbo);
            this.Controls.Add(this.TipoPaqueteChk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoPaqueteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Tipo Paquete";
            this.Activated += new System.EventHandler(this.FrmTipoPaqueteBusq_Activated);
            this.Load += new System.EventHandler(this.FrmTipoPaqueteBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoPaqueteCbo;
        private System.Windows.Forms.CheckBox TipoPaqueteChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
    }
}