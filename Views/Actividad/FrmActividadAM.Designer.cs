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
            this.TipoActividadCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.TipoActividadCbo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TransporteCbo);
            this.groupBox1.Controls.Add(this.TransporteLbl);
            this.groupBox1.Controls.Add(this.ImporteTxt);
            this.groupBox1.Controls.Add(this.ImporteLbl);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // TipoActividadCbo
            // 
            this.TipoActividadCbo.DisplayMember = "Descripcion";
            this.TipoActividadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActividadCbo.FormattingEnabled = true;
            this.TipoActividadCbo.Location = new System.Drawing.Point(88, 115);
            this.TipoActividadCbo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TipoActividadCbo.Name = "TipoActividadCbo";
            this.TipoActividadCbo.Size = new System.Drawing.Size(157, 21);
            this.TipoActividadCbo.TabIndex = 13;
            this.TipoActividadCbo.Tag = "Descripcion";
            this.TipoActividadCbo.ValueMember = "Id";
            this.TipoActividadCbo.SelectedIndexChanged += new System.EventHandler(this.TipoActividadCbo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Actividad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TransporteCbo
            // 
            this.TransporteCbo.DisplayMember = "Descripcion";
            this.TransporteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransporteCbo.FormattingEnabled = true;
            this.TransporteCbo.Location = new System.Drawing.Point(88, 84);
            this.TransporteCbo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransporteCbo.Name = "TransporteCbo";
            this.TransporteCbo.Size = new System.Drawing.Size(157, 21);
            this.TransporteCbo.TabIndex = 11;
            this.TransporteCbo.Tag = "Codigo";
            this.TransporteCbo.ValueMember = "Id";
            // 
            // TransporteLbl
            // 
            this.TransporteLbl.AutoSize = true;
            this.TransporteLbl.Location = new System.Drawing.Point(13, 86);
            this.TransporteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TransporteLbl.Name = "TransporteLbl";
            this.TransporteLbl.Size = new System.Drawing.Size(58, 13);
            this.TransporteLbl.TabIndex = 10;
            this.TransporteLbl.Text = "Transporte";
            // 
            // ImporteTxt
            // 
            this.ImporteTxt.Location = new System.Drawing.Point(88, 51);
            this.ImporteTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImporteTxt.Name = "ImporteTxt";
            this.ImporteTxt.Size = new System.Drawing.Size(166, 20);
            this.ImporteTxt.TabIndex = 2;
            this.ImporteTxt.Tag = "Importe";
            // 
            // ImporteLbl
            // 
            this.ImporteLbl.AutoSize = true;
            this.ImporteLbl.Location = new System.Drawing.Point(13, 51);
            this.ImporteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImporteLbl.Name = "ImporteLbl";
            this.ImporteLbl.Size = new System.Drawing.Size(42, 13);
            this.ImporteLbl.TabIndex = 8;
            this.ImporteLbl.Text = "Importe";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(88, 16);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NivelTxt.MaxLength = 90;
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(166, 20);
            this.NivelTxt.TabIndex = 1;
            this.NivelTxt.Tag = "Nivel";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(13, 16);
            this.NivelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(31, 13);
            this.NivelLbl.TabIndex = 2;
            this.NivelLbl.Text = "&Nivel";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(237, 188);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(162, 188);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 227);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActividadAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ComboBox TipoActividadCbo;
        private System.Windows.Forms.Label label1;

    }
}