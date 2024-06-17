namespace TurApp.Views
{
    partial class FrmActividadBusq
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
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CodigoChk = new System.Windows.Forms.CheckBox();
            this.ActividadCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(115, 115);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 9;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(189, 115);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 16;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CodigoChk
            // 
            this.CodigoChk.AutoSize = true;
            this.CodigoChk.Location = new System.Drawing.Point(20, 32);
            this.CodigoChk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodigoChk.Name = "CodigoChk";
            this.CodigoChk.Size = new System.Drawing.Size(70, 17);
            this.CodigoChk.TabIndex = 17;
            this.CodigoChk.Text = "Actividad";
            this.CodigoChk.UseVisualStyleBackColor = true;
            this.CodigoChk.CheckedChanged += new System.EventHandler(this.CodigoChk_CheckedChanged);
            // 
            // ActividadCbo
            // 
            this.ActividadCbo.DisplayMember = "Nombre";
            this.ActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActividadCbo.Enabled = false;
            this.ActividadCbo.FormattingEnabled = true;
            this.ActividadCbo.Location = new System.Drawing.Point(90, 31);
            this.ActividadCbo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActividadCbo.Name = "ActividadCbo";
            this.ActividadCbo.Size = new System.Drawing.Size(150, 21);
            this.ActividadCbo.TabIndex = 18;
            this.ActividadCbo.Tag = "CodTipoActividad";
            this.ActividadCbo.ValueMember = "Codigo";
            // 
            // FrmActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 155);
            this.Controls.Add(this.ActividadCbo);
            this.Controls.Add(this.CodigoChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActividadBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Actividad";
            this.Load += new System.EventHandler(this.FrmActividadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.CheckBox CodigoChk;
        private System.Windows.Forms.ComboBox ActividadCbo;
    }
}