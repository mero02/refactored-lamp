namespace TurApp.Views
{
    partial class FrmTuristaAM
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.PaisCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaTurista = new System.Windows.Forms.ErrorProvider(this.components);
            this.MisFactBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObservacionesTxt);
            this.groupBox1.Controls.Add(this.DniTxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.PaisCbo);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Controls.Add(this.DomicilioTxt);
            this.groupBox1.Controls.Add(this.DomicilioLbl);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ObservacionesTxt
            // 
            this.ObservacionesTxt.Location = new System.Drawing.Point(24, 231);
            this.ObservacionesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ObservacionesTxt.Multiline = true;
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Size = new System.Drawing.Size(356, 101);
            this.ObservacionesTxt.TabIndex = 10;
            this.ObservacionesTxt.Tag = "Observaciones";
            // 
            // DniTxt
            // 
            this.DniTxt.Location = new System.Drawing.Point(99, 27);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DniTxt.MaxLength = 15;
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(105, 22);
            this.DniTxt.TabIndex = 0;
            this.DniTxt.Tag = "NroDocumento";            
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxt_KeyPress);
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(13, 27);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(80, 17);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "&Documento";
            // 
            // PaisCbo
            // 
            this.PaisCbo.DisplayMember = "Nombre";
            this.PaisCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisCbo.FormattingEnabled = true;
            this.PaisCbo.Location = new System.Drawing.Point(99, 184);
            this.PaisCbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaisCbo.Name = "PaisCbo";
            this.PaisCbo.Size = new System.Drawing.Size(208, 24);
            this.PaisCbo.TabIndex = 4;
            this.PaisCbo.Tag = "CodPais";
            this.PaisCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            this.LocalidadLbl.AutoSize = true;
            this.LocalidadLbl.Location = new System.Drawing.Point(13, 190);
            this.LocalidadLbl.Name = "LocalidadLbl";
            this.LocalidadLbl.Size = new System.Drawing.Size(35, 17);
            this.LocalidadLbl.TabIndex = 12;
            this.LocalidadLbl.Text = "&Pais";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(99, 147);
            this.TelefonoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(220, 22);
            this.TelefonoTxt.TabIndex = 3;
            this.TelefonoTxt.Tag = "Telefono";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(13, 148);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(64, 17);
            this.TelefonoLbl.TabIndex = 10;
            this.TelefonoLbl.Text = "Telef&ono";
            // 
            // DomicilioTxt
            // 
            this.DomicilioTxt.Location = new System.Drawing.Point(99, 106);
            this.DomicilioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Size = new System.Drawing.Size(220, 22);
            this.DomicilioTxt.TabIndex = 2;
            this.DomicilioTxt.Tag = "Domicilio";
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(13, 106);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(64, 17);
            this.DomicilioLbl.TabIndex = 8;
            this.DomicilioLbl.Text = "Dom&icilio";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(99, 63);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreTxt.MaxLength = 90;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(220, 22);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(13, 63);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(58, 17);
            this.NombresLbl.TabIndex = 2;
            this.NombresLbl.Text = "No&mbre";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(313, 368);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(79, 33);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(197, 368);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(79, 33);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ErrorValidaTurista
            // 
            this.ErrorValidaTurista.ContainerControl = this;
            // 
            // MisFactBtn
            // 
            this.MisFactBtn.Location = new System.Drawing.Point(36, 368);
            this.MisFactBtn.Name = "MisFactBtn";
            this.MisFactBtn.Size = new System.Drawing.Size(107, 33);
            this.MisFactBtn.TabIndex = 13;
            this.MisFactBtn.Text = "Mis Facturas";
            this.MisFactBtn.UseVisualStyleBackColor = true;
            this.MisFactBtn.Click += new System.EventHandler(this.MisFactBtn_Click);
            // 
            // FrmTuristaAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 441);
            this.Controls.Add(this.MisFactBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTuristaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmTuristaAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmpTuristaAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.ComboBox PaisCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.ErrorProvider ErrorValidaTurista;
        private System.Windows.Forms.Button MisFactBtn;
    }
}