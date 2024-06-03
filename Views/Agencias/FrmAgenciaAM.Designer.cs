namespace TurApp.Views
{
    partial class FrmAgenciaAM
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CalleTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NroTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PisoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.Telefono1Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DptoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Telefono2Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(75, 10);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(192, 20);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            // 
            // CalleTxt
            // 
            this.CalleTxt.Location = new System.Drawing.Point(75, 43);
            this.CalleTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CalleTxt.Name = "CalleTxt";
            this.CalleTxt.Size = new System.Drawing.Size(192, 20);
            this.CalleTxt.TabIndex = 3;
            this.CalleTxt.Tag = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calle";
            // 
            // NroTxt
            // 
            this.NroTxt.Location = new System.Drawing.Point(75, 76);
            this.NroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NroTxt.Name = "NroTxt";
            this.NroTxt.Size = new System.Drawing.Size(94, 20);
            this.NroTxt.TabIndex = 5;
            this.NroTxt.Tag = "Nro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro";
            // 
            // PisoTxt
            // 
            this.PisoTxt.Location = new System.Drawing.Point(75, 107);
            this.PisoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PisoTxt.Name = "PisoTxt";
            this.PisoTxt.Size = new System.Drawing.Size(94, 20);
            this.PisoTxt.TabIndex = 7;
            this.PisoTxt.Tag = "Piso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Piso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Localidad";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(75, 172);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(174, 21);
            this.LocalidadCbo.TabIndex = 9;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Codigo";
            // 
            // Telefono1Txt
            // 
            this.Telefono1Txt.Location = new System.Drawing.Point(75, 209);
            this.Telefono1Txt.Margin = new System.Windows.Forms.Padding(2);
            this.Telefono1Txt.Name = "Telefono1Txt";
            this.Telefono1Txt.Size = new System.Drawing.Size(94, 20);
            this.Telefono1Txt.TabIndex = 10;
            this.Telefono1Txt.Tag = "Telefono1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono1";
            // 
            // DptoTxt
            // 
            this.DptoTxt.Location = new System.Drawing.Point(75, 139);
            this.DptoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DptoTxt.Name = "DptoTxt";
            this.DptoTxt.Size = new System.Drawing.Size(94, 20);
            this.DptoTxt.TabIndex = 8;
            this.DptoTxt.Tag = "Dpto";
            this.DptoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DptoTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dpto";
            // 
            // Telefono2Txt
            // 
            this.Telefono2Txt.Location = new System.Drawing.Point(75, 243);
            this.Telefono2Txt.Margin = new System.Windows.Forms.Padding(2);
            this.Telefono2Txt.Name = "Telefono2Txt";
            this.Telefono2Txt.Size = new System.Drawing.Size(94, 20);
            this.Telefono2Txt.TabIndex = 11;
            this.Telefono2Txt.Tag = "Telefono2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono2";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(253, 281);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 18;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(166, 281);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 17;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmAgenciaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 323);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.Telefono2Txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DptoTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Telefono1Txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LocalidadCbo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PisoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NroTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgenciaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox CalleTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NroTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PisoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.TextBox Telefono1Txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DptoTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Telefono2Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
    }
}