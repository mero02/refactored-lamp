namespace TurApp.Views
{
    partial class FrmPaqueteAM
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
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CodTipoPaqueteLbl = new System.Windows.Forms.Label();
            this.CodTipoPaqueteTxt = new System.Windows.Forms.TextBox();
            this.CodAgenciaLbl = new System.Windows.Forms.Label();
            this.CodAgenciaTxt = new System.Windows.Forms.TextBox();
            this.NivelLbl = new System.Windows.Forms.Label();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.DniTuristaLbl = new System.Windows.Forms.Label();
            this.DniTuristaTxt = new System.Windows.Forms.TextBox();
            this.CodDestinoLbl = new System.Windows.Forms.Label();
            this.CodDestinoTxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.FechaLbl = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(2, 9);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(43, 13);
            this.CodigoLbl.TabIndex = 0;
            this.CodigoLbl.Text = "Codigo:";
            this.CodigoLbl.Click += new System.EventHandler(this.CodigoLbl_Click);
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(108, 7);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 20);
            this.CodigoTxt.TabIndex = 1;
            this.CodigoTxt.TextChanged += new System.EventHandler(this.CodigoTxt_TextChanged);
            // 
            // CodTipoPaqueteLbl
            // 
            this.CodTipoPaqueteLbl.AutoSize = true;
            this.CodTipoPaqueteLbl.Location = new System.Drawing.Point(2, 41);
            this.CodTipoPaqueteLbl.Name = "CodTipoPaqueteLbl";
            this.CodTipoPaqueteLbl.Size = new System.Drawing.Size(99, 13);
            this.CodTipoPaqueteLbl.TabIndex = 2;
            this.CodTipoPaqueteLbl.Text = "Cod. Tipo Paquete:";
            this.CodTipoPaqueteLbl.Click += new System.EventHandler(this.CodTipoPaqueteLbl_Click);
            // 
            // CodTipoPaqueteTxt
            // 
            this.CodTipoPaqueteTxt.Location = new System.Drawing.Point(108, 39);
            this.CodTipoPaqueteTxt.Name = "CodTipoPaqueteTxt";
            this.CodTipoPaqueteTxt.Size = new System.Drawing.Size(100, 20);
            this.CodTipoPaqueteTxt.TabIndex = 3;
            this.CodTipoPaqueteTxt.TextChanged += new System.EventHandler(this.CodTipoPaqueteTxt_TextChanged);
            // 
            // CodAgenciaLbl
            // 
            this.CodAgenciaLbl.AutoSize = true;
            this.CodAgenciaLbl.Location = new System.Drawing.Point(2, 73);
            this.CodAgenciaLbl.Name = "CodAgenciaLbl";
            this.CodAgenciaLbl.Size = new System.Drawing.Size(74, 13);
            this.CodAgenciaLbl.TabIndex = 4;
            this.CodAgenciaLbl.Text = "Cod. Agencia:";
            this.CodAgenciaLbl.Click += new System.EventHandler(this.CodAgenciaLbl_Click);
            // 
            // CodAgenciaTxt
            // 
            this.CodAgenciaTxt.Location = new System.Drawing.Point(108, 70);
            this.CodAgenciaTxt.Name = "CodAgenciaTxt";
            this.CodAgenciaTxt.Size = new System.Drawing.Size(100, 20);
            this.CodAgenciaTxt.TabIndex = 5;
            this.CodAgenciaTxt.TextChanged += new System.EventHandler(this.CodAgenciaTxt_TextChanged);
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(2, 105);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(34, 13);
            this.NivelLbl.TabIndex = 6;
            this.NivelLbl.Text = "Nivel:";
            this.NivelLbl.Click += new System.EventHandler(this.NivelLbl_Click);
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(108, 101);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(100, 20);
            this.NivelTxt.TabIndex = 7;
            this.NivelTxt.TextChanged += new System.EventHandler(this.NivelTxt_TextChanged);
            // 
            // DniTuristaLbl
            // 
            this.DniTuristaLbl.AutoSize = true;
            this.DniTuristaLbl.Location = new System.Drawing.Point(2, 164);
            this.DniTuristaLbl.Name = "DniTuristaLbl";
            this.DniTuristaLbl.Size = new System.Drawing.Size(58, 13);
            this.DniTuristaLbl.TabIndex = 8;
            this.DniTuristaLbl.Text = "DniTurista:";
            this.DniTuristaLbl.Click += new System.EventHandler(this.DniTuristaLbl_Click);
            // 
            // DniTuristaTxt
            // 
            this.DniTuristaTxt.Location = new System.Drawing.Point(108, 158);
            this.DniTuristaTxt.Name = "DniTuristaTxt";
            this.DniTuristaTxt.Size = new System.Drawing.Size(100, 20);
            this.DniTuristaTxt.TabIndex = 9;
            this.DniTuristaTxt.TextChanged += new System.EventHandler(this.DniTuristaTxt_TextChanged);
            // 
            // CodDestinoLbl
            // 
            this.CodDestinoLbl.AutoSize = true;
            this.CodDestinoLbl.Location = new System.Drawing.Point(2, 193);
            this.CodDestinoLbl.Name = "CodDestinoLbl";
            this.CodDestinoLbl.Size = new System.Drawing.Size(71, 13);
            this.CodDestinoLbl.TabIndex = 10;
            this.CodDestinoLbl.Text = "Cod. Destino:";
            this.CodDestinoLbl.Click += new System.EventHandler(this.CodDestinoLbl_Click);
            // 
            // CodDestinoTxt
            // 
            this.CodDestinoTxt.Location = new System.Drawing.Point(108, 190);
            this.CodDestinoTxt.Name = "CodDestinoTxt";
            this.CodDestinoTxt.Size = new System.Drawing.Size(100, 20);
            this.CodDestinoTxt.TabIndex = 11;
            this.CodDestinoTxt.TextChanged += new System.EventHandler(this.CodDestinoTxt_TextChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(151, 250);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 15;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(45, 250);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 14;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FechaLbl
            // 
            this.FechaLbl.AutoSize = true;
            this.FechaLbl.Location = new System.Drawing.Point(2, 134);
            this.FechaLbl.Name = "FechaLbl";
            this.FechaLbl.Size = new System.Drawing.Size(40, 13);
            this.FechaLbl.TabIndex = 16;
            this.FechaLbl.Text = "Fecha:";
            this.FechaLbl.Click += new System.EventHandler(this.FechaLbl_Click);
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(108, 130);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(100, 20);
            this.FechaTxt.TabIndex = 17;
            this.FechaTxt.TextChanged += new System.EventHandler(this.FechaTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaTxt);
            this.groupBox1.Controls.Add(this.FechaLbl);
            this.groupBox1.Controls.Add(this.CodDestinoTxt);
            this.groupBox1.Controls.Add(this.CodDestinoLbl);
            this.groupBox1.Controls.Add(this.DniTuristaTxt);
            this.groupBox1.Controls.Add(this.DniTuristaLbl);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Controls.Add(this.CodAgenciaTxt);
            this.groupBox1.Controls.Add(this.CodAgenciaLbl);
            this.groupBox1.Controls.Add(this.CodTipoPaqueteTxt);
            this.groupBox1.Controls.Add(this.CodTipoPaqueteLbl);
            this.groupBox1.Controls.Add(this.CodigoTxt);
            this.groupBox1.Controls.Add(this.CodigoLbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Location = new System.Drawing.Point(9, 1);
            this.Name = "FrmPaqueteAM";
            this.Text = "FrmPaquetAM";
            this.Load += new System.EventHandler(this.FrmPaquetAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label CodTipoPaqueteLbl;
        private System.Windows.Forms.TextBox CodTipoPaqueteTxt;
        private System.Windows.Forms.Label CodAgenciaLbl;
        private System.Windows.Forms.TextBox CodAgenciaTxt;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.Label DniTuristaLbl;
        private System.Windows.Forms.TextBox DniTuristaTxt;
        private System.Windows.Forms.Label CodDestinoLbl;
        private System.Windows.Forms.TextBox CodDestinoTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label FechaLbl;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}