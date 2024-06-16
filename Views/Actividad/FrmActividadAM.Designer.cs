namespace TurApp.Views
{
    partial class FrmActividadAM
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
            this.TransporteCbo = new System.Windows.Forms.ComboBox();
            this.TransporteLbl = new System.Windows.Forms.Label();
            this.ImporteTxt = new System.Windows.Forms.TextBox();
            this.ImporteLbl = new System.Windows.Forms.Label();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.NivelLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TransporteCbo);
            this.groupBox1.Controls.Add(this.TransporteLbl);
            this.groupBox1.Controls.Add(this.ImporteTxt);
            this.groupBox1.Controls.Add(this.ImporteLbl);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // TransporteCbo
            // 
            this.TransporteCbo.DisplayMember = "Descripcion";
            this.TransporteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCbo.FormattingEnabled = true;
            this.TransporteCbo.Location = new System.Drawing.Point(115, 129);
            this.TransporteCbo.Name = "TransporteCbo";
            this.TransporteCbo.Size = new System.Drawing.Size(234, 28);
            this.TransporteCbo.TabIndex = 11;
            this.TransporteCbo.Tag = "Codigo";
            this.TransporteCbo.ValueMember = "Id";
            // 
            // TransporteLbl
            // 
            this.TransporteLbl.AutoSize = true;
            this.TransporteLbl.Location = new System.Drawing.Point(19, 132);
            this.TransporteLbl.Name = "TransporteLbl";
            this.TransporteLbl.Size = new System.Drawing.Size(86, 20);
            this.TransporteLbl.TabIndex = 10;
            this.TransporteLbl.Text = "Transporte";
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(115, 79);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(247, 26);
            this.ImporteTxt.TabIndex = 2;
            this.ImporteTxt.Tag = "Importe";
            // 
            // ImporteLbl
            // 
            this.ImporteLbl.AutoSize = true;
            this.ImporteLbl.Location = new System.Drawing.Point(19, 79);
            this.ImporteLbl.Name = "ImporteLbl";
            this.ImporteLbl.Size = new System.Drawing.Size(64, 20);
            this.ImporteLbl.TabIndex = 8;
            this.ImporteLbl.Text = "Importe";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(115, 25);
            this.NivelTxt.MaxLength = 90;
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(247, 26);
            this.NivelTxt.TabIndex = 1;
            this.NivelTxt.Tag = "Nivel";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(19, 25);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(42, 20);
            this.NivelLbl.TabIndex = 2;
            this.NivelLbl.Text = "&Nivel";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(356, 236);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(88, 42);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(226, 236);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(88, 42);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 300);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActividadAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActividadAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TransporteLbl;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label ImporteLbl;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox TransporteCbo;

    }
}