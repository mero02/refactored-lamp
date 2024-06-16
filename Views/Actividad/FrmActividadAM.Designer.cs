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
            this.CodigoCbo = new System.Windows.Forms.ComboBox();
            this.TransporteCbo = new System.Windows.Forms.ComboBox();
            this.CodigoLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.CodigoCbo);
            this.groupBox1.Controls.Add(this.TransporteCbo);
            this.groupBox1.Controls.Add(this.CodigoLbl);
            this.groupBox1.Controls.Add(this.TransporteLbl);
            this.groupBox1.Controls.Add(this.ImporteTxt);
            this.groupBox1.Controls.Add(this.ImporteLbl);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CodigoCbo
            // 
            this.CodigoCbo.DisplayMember = "Nombre";
            this.CodigoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodigoCbo.FormattingEnabled = true;
            this.CodigoCbo.Location = new System.Drawing.Point(111, 31);
            this.CodigoCbo.Name = "CodigoCbo";
            this.CodigoCbo.Size = new System.Drawing.Size(234, 28);
            this.CodigoCbo.TabIndex = 18;
            this.CodigoCbo.Tag = "CodActividad";
            this.CodigoCbo.ValueMember = "Id";
            // 
            // TransporteCbo
            // 
            this.TransporteCbo.DisplayMember = "Nombre";
            this.TransporteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCbo.FormattingEnabled = true;
            this.TransporteCbo.Location = new System.Drawing.Point(111, 182);
            this.TransporteCbo.Name = "TransporteCbo";
            this.TransporteCbo.Size = new System.Drawing.Size(234, 28);
            this.TransporteCbo.TabIndex = 17;
            this.TransporteCbo.Tag = "CodTransporte";
            this.TransporteCbo.ValueMember = "Id";
            this.TransporteCbo.SelectedIndexChanged += new System.EventHandler(this.label3_Click);
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(15, 34);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(59, 20);
            this.CodigoLbl.TabIndex = 16;
            this.CodigoLbl.Text = "&Codigo";
            // 
            // TransporteLbl
            // 
            this.TransporteLbl.AutoSize = true;
            this.TransporteLbl.Location = new System.Drawing.Point(15, 185);
            this.TransporteLbl.Name = "TransporteLbl";
            this.TransporteLbl.Size = new System.Drawing.Size(86, 20);
            this.TransporteLbl.TabIndex = 10;
            this.TransporteLbl.Text = "Transporte";
            this.TransporteLbl.Click += new System.EventHandler(this.TransporteLbl_Click);
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(111, 132);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(247, 26);
            this.ImporteTxt.TabIndex = 2;
            this.ImporteTxt.Tag = "Importe";
            // 
            // ImporteLbl
            // 
            this.ImporteLbl.AutoSize = true;
            this.ImporteLbl.Location = new System.Drawing.Point(15, 132);
            this.ImporteLbl.Name = "ImporteLbl";
            this.ImporteLbl.Size = new System.Drawing.Size(64, 20);
            this.ImporteLbl.TabIndex = 8;
            this.ImporteLbl.Text = "Importe";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(111, 78);
            this.NivelTxt.MaxLength = 90;
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(247, 26);
            this.NivelTxt.TabIndex = 1;
            this.NivelTxt.Tag = "Nivel";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(15, 78);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(42, 20);
            this.NivelLbl.TabIndex = 2;
            this.NivelLbl.Text = "&Nivel";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(357, 308);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(88, 42);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(227, 308);
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
            this.ClientSize = new System.Drawing.Size(456, 389);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActividadAM";
            this.Text = "FrmActividadAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.Label TransporteLbl;
        private System.Windows.Forms.TextBox ImporteTxt;
        private System.Windows.Forms.Label ImporteLbl;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.ComboBox TransporteCbo;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox CodigoCbo;

    }
}