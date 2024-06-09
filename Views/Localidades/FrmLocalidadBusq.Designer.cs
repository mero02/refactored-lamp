namespace TurApp.Views
{
    partial class FrmLocalidadBusq
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
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(11, 38);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 11;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(87, 36);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(150, 21);
            this.LocalidadCbo.TabIndex = 12;
            this.LocalidadCbo.ValueMember = "Codigo";
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(61, 121);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 13;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(162, 121);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FrmLocalidadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 180);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.LocalidadCbo);
            this.Controls.Add(this.LocalidadChk);
            this.Name = "FrmLocalidadBusq";
            this.Text = "Buscar Localidad";
            this.Activated += new System.EventHandler(this.FrmLocalidadBusq_Activated);
            this.Load += new System.EventHandler(this.FrmLocalidadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}