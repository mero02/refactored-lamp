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
            this.CodTipoPaqueteCbo = new System.Windows.Forms.Label();
            this.CodAgenciaLbl = new System.Windows.Forms.Label();
            this.NivelLbl = new System.Windows.Forms.Label();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.DniTuristaLbl = new System.Windows.Forms.Label();
            this.CodDestinoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.FechaLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaPaqueteTime = new System.Windows.Forms.DateTimePicker();
            this.CodDestinoCbo = new System.Windows.Forms.ComboBox();
            this.DniTuristaCbo = new System.Windows.Forms.ComboBox();
            this.AgenciaCbo = new System.Windows.Forms.ComboBox();
            this.TipoPaqueteCbo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodTipoPaqueteCbo
            // 
            this.CodTipoPaqueteCbo.AutoSize = true;
            this.CodTipoPaqueteCbo.Location = new System.Drawing.Point(3, 63);
            this.CodTipoPaqueteCbo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodTipoPaqueteCbo.Name = "CodTipoPaqueteCbo";
            this.CodTipoPaqueteCbo.Size = new System.Drawing.Size(144, 20);
            this.CodTipoPaqueteCbo.TabIndex = 1;
            this.CodTipoPaqueteCbo.Text = "&Cod. Tipo Paquete:";
            // 
            // CodAgenciaLbl
            // 
            this.CodAgenciaLbl.AutoSize = true;
            this.CodAgenciaLbl.Location = new System.Drawing.Point(3, 112);
            this.CodAgenciaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodAgenciaLbl.Name = "CodAgenciaLbl";
            this.CodAgenciaLbl.Size = new System.Drawing.Size(108, 20);
            this.CodAgenciaLbl.TabIndex = 3;
            this.CodAgenciaLbl.Text = "Cod. Agencia:";
            this.CodAgenciaLbl.Click += new System.EventHandler(this.CodAgenciaLbl_Click);
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(3, 162);
            this.NivelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(46, 20);
            this.NivelLbl.TabIndex = 5;
            this.NivelLbl.Text = "Nivel:";
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(159, 157);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(222, 26);
            this.NivelTxt.TabIndex = 6;
            this.NivelTxt.Tag = "Nivel";
            // 
            // DniTuristaLbl
            // 
            this.DniTuristaLbl.AutoSize = true;
            this.DniTuristaLbl.Location = new System.Drawing.Point(3, 252);
            this.DniTuristaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DniTuristaLbl.Name = "DniTuristaLbl";
            this.DniTuristaLbl.Size = new System.Drawing.Size(85, 20);
            this.DniTuristaLbl.TabIndex = 9;
            this.DniTuristaLbl.Text = "DniTurista:";
            // 
            // CodDestinoLbl
            // 
            this.CodDestinoLbl.AutoSize = true;
            this.CodDestinoLbl.Location = new System.Drawing.Point(3, 297);
            this.CodDestinoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodDestinoLbl.Name = "CodDestinoLbl";
            this.CodDestinoLbl.Size = new System.Drawing.Size(105, 20);
            this.CodDestinoLbl.TabIndex = 11;
            this.CodDestinoLbl.Text = "Cod. Destino:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(320, 385);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(88, 42);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(159, 385);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(88, 42);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FechaLbl
            // 
            this.FechaLbl.AutoSize = true;
            this.FechaLbl.Location = new System.Drawing.Point(3, 206);
            this.FechaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLbl.Name = "FechaLbl";
            this.FechaLbl.Size = new System.Drawing.Size(58, 20);
            this.FechaLbl.TabIndex = 7;
            this.FechaLbl.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaPaqueteTime);
            this.groupBox1.Controls.Add(this.CodDestinoCbo);
            this.groupBox1.Controls.Add(this.DniTuristaCbo);
            this.groupBox1.Controls.Add(this.AgenciaCbo);
            this.groupBox1.Controls.Add(this.TipoPaqueteCbo);
            this.groupBox1.Controls.Add(this.FechaLbl);
            this.groupBox1.Controls.Add(this.CodDestinoLbl);
            this.groupBox1.Controls.Add(this.DniTuristaLbl);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Controls.Add(this.CodAgenciaLbl);
            this.groupBox1.Controls.Add(this.CodTipoPaqueteCbo);
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 377);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FechaPaqueteTime
            // 
            this.FechaPaqueteTime.CustomFormat = "yyyy-mm-dd";
            this.FechaPaqueteTime.Location = new System.Drawing.Point(159, 206);
            this.FechaPaqueteTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaPaqueteTime.Name = "FechaPaqueteTime";
            this.FechaPaqueteTime.Size = new System.Drawing.Size(298, 26);
            this.FechaPaqueteTime.TabIndex = 8;
            this.FechaPaqueteTime.Tag = "Fecha";
            // 
            // CodDestinoCbo
            // 
            this.CodDestinoCbo.DisplayMember = "Nombre";
            this.CodDestinoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodDestinoCbo.FormattingEnabled = true;
            this.CodDestinoCbo.Location = new System.Drawing.Point(159, 297);
            this.CodDestinoCbo.Name = "CodDestinoCbo";
            this.CodDestinoCbo.Size = new System.Drawing.Size(234, 28);
            this.CodDestinoCbo.TabIndex = 12;
            this.CodDestinoCbo.Tag = "CodDestino";
            this.CodDestinoCbo.ValueMember = "Id";
            // 
            // DniTuristaCbo
            // 
            this.DniTuristaCbo.DisplayMember = "NroDocumento";
            this.DniTuristaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DniTuristaCbo.FormattingEnabled = true;
            this.DniTuristaCbo.Location = new System.Drawing.Point(159, 245);
            this.DniTuristaCbo.Name = "DniTuristaCbo";
            this.DniTuristaCbo.Size = new System.Drawing.Size(234, 28);
            this.DniTuristaCbo.TabIndex = 10;
            this.DniTuristaCbo.Tag = "DniTurista";
            this.DniTuristaCbo.ValueMember = "Id";
            // 
            // AgenciaCbo
            // 
            this.AgenciaCbo.DisplayMember = "Nombre";
            this.AgenciaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgenciaCbo.FormattingEnabled = true;
            this.AgenciaCbo.Location = new System.Drawing.Point(159, 100);
            this.AgenciaCbo.Name = "AgenciaCbo";
            this.AgenciaCbo.Size = new System.Drawing.Size(224, 28);
            this.AgenciaCbo.TabIndex = 4;
            this.AgenciaCbo.Tag = "CodAgencia";
            this.AgenciaCbo.ValueMember = "Id";
            // 
            // TipoPaqueteCbo
            // 
            this.TipoPaqueteCbo.DisplayMember = "Nombre";
            this.TipoPaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPaqueteCbo.FormattingEnabled = true;
            this.TipoPaqueteCbo.Location = new System.Drawing.Point(159, 58);
            this.TipoPaqueteCbo.Name = "TipoPaqueteCbo";
            this.TipoPaqueteCbo.Size = new System.Drawing.Size(224, 28);
            this.TipoPaqueteCbo.TabIndex = 2;
            this.TipoPaqueteCbo.Tag = "CodTipoPaquete";
            this.TipoPaqueteCbo.ValueMember = "Id";
            // 
            // FrmPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Location = new System.Drawing.Point(9, 1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Paquete";
            this.Load += new System.EventHandler(this.FrmPaquetAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CodTipoPaqueteCbo;
        private System.Windows.Forms.Label CodAgenciaLbl;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.TextBox NivelTxt;
        private System.Windows.Forms.Label DniTuristaLbl;
        private System.Windows.Forms.Label CodDestinoLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label FechaLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TipoPaqueteCbo;
        private System.Windows.Forms.ComboBox CodDestinoCbo;
        private System.Windows.Forms.ComboBox DniTuristaCbo;
        private System.Windows.Forms.ComboBox AgenciaCbo;
        private System.Windows.Forms.DateTimePicker FechaPaqueteTime;
    }
}