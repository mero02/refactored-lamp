namespace TurApp.Views
{
    partial class FrmFacturaAM
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
            this.FormaPagoCbo = new System.Windows.Forms.ComboBox();
            this.DetallePagoTxt = new System.Windows.Forms.TextBox();
            this.FechaFacturaTime = new System.Windows.Forms.DateTimePicker();
            this.FormaPagolbl = new System.Windows.Forms.Label();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.NumeroLbl = new System.Windows.Forms.Label();
            this.DniTuristaCbo = new System.Windows.Forms.ComboBox();
            this.DniTuristaLbl = new System.Windows.Forms.Label();
            this.FechaLbl = new System.Windows.Forms.Label();
            this.LetraTxt = new System.Windows.Forms.TextBox();
            this.LetraLbl = new System.Windows.Forms.Label();
            this.SerieTxt = new System.Windows.Forms.TextBox();
            this.SerieLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormaPagoCbo);
            this.groupBox1.Controls.Add(this.DetallePagoTxt);
            this.groupBox1.Controls.Add(this.FechaFacturaTime);
            this.groupBox1.Controls.Add(this.FormaPagolbl);
            this.groupBox1.Controls.Add(this.NumeroTxt);
            this.groupBox1.Controls.Add(this.NumeroLbl);
            this.groupBox1.Controls.Add(this.DniTuristaCbo);
            this.groupBox1.Controls.Add(this.DniTuristaLbl);
            this.groupBox1.Controls.Add(this.FechaLbl);
            this.groupBox1.Controls.Add(this.LetraTxt);
            this.groupBox1.Controls.Add(this.LetraLbl);
            this.groupBox1.Controls.Add(this.SerieTxt);
            this.groupBox1.Controls.Add(this.SerieLbl);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FormaPagoCbo
            // 
            this.FormaPagoCbo.DisplayMember = "Forma";
            this.FormaPagoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagoCbo.FormattingEnabled = true;
            this.FormaPagoCbo.Location = new System.Drawing.Point(93, 187);
            this.FormaPagoCbo.Margin = new System.Windows.Forms.Padding(2);
            this.FormaPagoCbo.Name = "FormaPagoCbo";
            this.FormaPagoCbo.Size = new System.Drawing.Size(157, 21);
            this.FormaPagoCbo.TabIndex = 19;
            this.FormaPagoCbo.Tag = "CodFormaPago";
            this.FormaPagoCbo.ValueMember = "Id";
            this.FormaPagoCbo.SelectedIndexChanged += new System.EventHandler(this.FormaPagoCbo_SelectedIndexChanged);
            // 
            // DetallePagoTxt
            // 
            this.DetallePagoTxt.Location = new System.Drawing.Point(13, 222);
            this.DetallePagoTxt.Multiline = true;
            this.DetallePagoTxt.Name = "DetallePagoTxt";
            this.DetallePagoTxt.Size = new System.Drawing.Size(268, 83);
            this.DetallePagoTxt.TabIndex = 18;
            this.DetallePagoTxt.Tag = "DetallePago";
            // 
            // FechaFacturaTime
            // 
            this.FechaFacturaTime.CustomFormat = "yyyy-mm-dd";
            this.FechaFacturaTime.Location = new System.Drawing.Point(74, 120);
            this.FechaFacturaTime.Name = "FechaFacturaTime";
            this.FechaFacturaTime.Size = new System.Drawing.Size(200, 20);
            this.FechaFacturaTime.TabIndex = 17;
            this.FechaFacturaTime.Tag = "Fecha";
            // 
            // FormaPagolbl
            // 
            this.FormaPagolbl.AutoSize = true;
            this.FormaPagolbl.Location = new System.Drawing.Point(10, 190);
            this.FormaPagolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormaPagolbl.Name = "FormaPagolbl";
            this.FormaPagolbl.Size = new System.Drawing.Size(79, 13);
            this.FormaPagolbl.TabIndex = 14;
            this.FormaPagolbl.Text = "&Forma de Pago";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(74, 22);
            this.NumeroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NumeroTxt.MaxLength = 15;
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(80, 20);
            this.NumeroTxt.TabIndex = 0;
            this.NumeroTxt.Tag = "Nro";
            this.NumeroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroTxt_KeyPress);
            // 
            // NumeroLbl
            // 
            this.NumeroLbl.AutoSize = true;
            this.NumeroLbl.Location = new System.Drawing.Point(10, 22);
            this.NumeroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroLbl.Name = "NumeroLbl";
            this.NumeroLbl.Size = new System.Drawing.Size(44, 13);
            this.NumeroLbl.TabIndex = 16;
            this.NumeroLbl.Text = "&Numero";
            // 
            // DniTuristaCbo
            // 
            this.DniTuristaCbo.DisplayMember = "Nombre";
            this.DniTuristaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DniTuristaCbo.FormattingEnabled = true;
            this.DniTuristaCbo.Location = new System.Drawing.Point(74, 150);
            this.DniTuristaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.DniTuristaCbo.Name = "DniTuristaCbo";
            this.DniTuristaCbo.Size = new System.Drawing.Size(157, 21);
            this.DniTuristaCbo.TabIndex = 4;
            this.DniTuristaCbo.Tag = "DniTurista";
            this.DniTuristaCbo.ValueMember = "Id";
            this.DniTuristaCbo.SelectedIndexChanged += new System.EventHandler(this.DniTuristaCbo_SelectedIndexChanged);
            // 
            // DniTuristaLbl
            // 
            this.DniTuristaLbl.AutoSize = true;
            this.DniTuristaLbl.Location = new System.Drawing.Point(10, 154);
            this.DniTuristaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniTuristaLbl.Name = "DniTuristaLbl";
            this.DniTuristaLbl.Size = new System.Drawing.Size(55, 13);
            this.DniTuristaLbl.TabIndex = 12;
            this.DniTuristaLbl.Text = "&DniTurista";
            // 
            // FechaLbl
            // 
            this.FechaLbl.AutoSize = true;
            this.FechaLbl.Location = new System.Drawing.Point(10, 120);
            this.FechaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaLbl.Name = "FechaLbl";
            this.FechaLbl.Size = new System.Drawing.Size(37, 13);
            this.FechaLbl.TabIndex = 10;
            this.FechaLbl.Text = "&Fecha";
            // 
            // LetraTxt
            // 
            this.LetraTxt.Location = new System.Drawing.Point(74, 86);
            this.LetraTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LetraTxt.Name = "LetraTxt";
            this.LetraTxt.Size = new System.Drawing.Size(166, 20);
            this.LetraTxt.TabIndex = 2;
            this.LetraTxt.Tag = "Letra";
            this.LetraTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LetraTxt_KeyPress);
            // 
            // LetraLbl
            // 
            this.LetraLbl.AutoSize = true;
            this.LetraLbl.Location = new System.Drawing.Point(10, 86);
            this.LetraLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LetraLbl.Name = "LetraLbl";
            this.LetraLbl.Size = new System.Drawing.Size(31, 13);
            this.LetraLbl.TabIndex = 8;
            this.LetraLbl.Text = "&Letra";
            // 
            // SerieTxt
            // 
            this.SerieTxt.Location = new System.Drawing.Point(74, 51);
            this.SerieTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SerieTxt.MaxLength = 90;
            this.SerieTxt.Name = "SerieTxt";
            this.SerieTxt.Size = new System.Drawing.Size(166, 20);
            this.SerieTxt.TabIndex = 1;
            this.SerieTxt.Tag = "Serie";
            this.SerieTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerieTxt_KeyPress);
            // 
            // SerieLbl
            // 
            this.SerieLbl.AutoSize = true;
            this.SerieLbl.Location = new System.Drawing.Point(10, 51);
            this.SerieLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerieLbl.Name = "SerieLbl";
            this.SerieLbl.Size = new System.Drawing.Size(31, 13);
            this.SerieLbl.TabIndex = 2;
            this.SerieLbl.Text = "&Serie";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(233, 342);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(146, 342);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmFacturaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 380);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmFacturaAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmFacturaAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumeroTxt;
        private System.Windows.Forms.Label NumeroLbl;
        private System.Windows.Forms.ComboBox DniTuristaCbo;
        private System.Windows.Forms.Label DniTuristaLbl;
        private System.Windows.Forms.Label FechaLbl;
        private System.Windows.Forms.TextBox LetraTxt;
        private System.Windows.Forms.Label LetraLbl;
        private System.Windows.Forms.TextBox SerieTxt;
        private System.Windows.Forms.Label SerieLbl;
        private System.Windows.Forms.DateTimePicker FechaFacturaTime;
        private System.Windows.Forms.Label FormaPagolbl;
        private System.Windows.Forms.TextBox DetallePagoTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox FormaPagoCbo;
    }
}