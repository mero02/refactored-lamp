namespace TurApp.Views
{
    partial class FrmPaqueteBusq
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
            this.TipoPaqueteCbo = new System.Windows.Forms.ComboBox();
            this.TipoPaqueteChk = new System.Windows.Forms.CheckBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.AgenciaCbo = new System.Windows.Forms.ComboBox();
            this.AgenciaChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TipoPaqueteCbo
            // 
            this.TipoPaqueteCbo.DisplayMember = "Nombre";
            this.TipoPaqueteCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPaqueteCbo.Enabled = false;
            this.TipoPaqueteCbo.FormattingEnabled = true;
            this.TipoPaqueteCbo.Location = new System.Drawing.Point(105, 58);
            this.TipoPaqueteCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteCbo.Name = "TipoPaqueteCbo";
            this.TipoPaqueteCbo.Size = new System.Drawing.Size(206, 21);
            this.TipoPaqueteCbo.TabIndex = 15;
            this.TipoPaqueteCbo.ValueMember = "Codigo";
            // 
            // TipoPaqueteChk
            // 
            this.TipoPaqueteChk.AutoSize = true;
            this.TipoPaqueteChk.Location = new System.Drawing.Point(11, 60);
            this.TipoPaqueteChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoPaqueteChk.Name = "TipoPaqueteChk";
            this.TipoPaqueteChk.Size = new System.Drawing.Size(90, 17);
            this.TipoPaqueteChk.TabIndex = 14;
            this.TipoPaqueteChk.Text = "Tipo Paquete";
            this.TipoPaqueteChk.UseVisualStyleBackColor = true;
            this.TipoPaqueteChk.CheckedChanged += new System.EventHandler(this.TipoPaqueteChk_CheckedChanged);
            // 
            // DniTxt
            // 
            this.DniTxt.Enabled = false;
            this.DniTxt.Location = new System.Drawing.Point(104, 22);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(123, 20);
            this.DniTxt.TabIndex = 13;
            // 
            // DniChk
            // 
            this.DniChk.AutoSize = true;
            this.DniChk.Location = new System.Drawing.Point(11, 21);
            this.DniChk.Margin = new System.Windows.Forms.Padding(2);
            this.DniChk.Name = "DniChk";
            this.DniChk.Size = new System.Drawing.Size(42, 17);
            this.DniChk.TabIndex = 12;
            this.DniChk.Tag = "Dni";
            this.DniChk.Text = "Dni";
            this.DniChk.UseVisualStyleBackColor = true;
            this.DniChk.CheckedChanged += new System.EventHandler(this.DniChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(182, 156);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(81, 156);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 16;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // AgenciaCbo
            // 
            this.AgenciaCbo.DisplayMember = "Nombre";
            this.AgenciaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgenciaCbo.Enabled = false;
            this.AgenciaCbo.FormattingEnabled = true;
            this.AgenciaCbo.Location = new System.Drawing.Point(105, 97);
            this.AgenciaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.AgenciaCbo.Name = "AgenciaCbo";
            this.AgenciaCbo.Size = new System.Drawing.Size(206, 21);
            this.AgenciaCbo.TabIndex = 19;
            this.AgenciaCbo.ValueMember = "Codigo";
            // 
            // AgenciaChk
            // 
            this.AgenciaChk.AutoSize = true;
            this.AgenciaChk.Location = new System.Drawing.Point(11, 99);
            this.AgenciaChk.Margin = new System.Windows.Forms.Padding(2);
            this.AgenciaChk.Name = "AgenciaChk";
            this.AgenciaChk.Size = new System.Drawing.Size(65, 17);
            this.AgenciaChk.TabIndex = 18;
            this.AgenciaChk.Text = "Agencia";
            this.AgenciaChk.UseVisualStyleBackColor = true;
            this.AgenciaChk.CheckedChanged += new System.EventHandler(this.CodAgenciaChk_CheckedChanged);
            // 
            // FrmPaqueteBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 194);
            this.Controls.Add(this.AgenciaCbo);
            this.Controls.Add(this.AgenciaChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TipoPaqueteCbo);
            this.Controls.Add(this.TipoPaqueteChk);
            this.Controls.Add(this.DniTxt);
            this.Controls.Add(this.DniChk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Paquete";
            this.Activated += new System.EventHandler(this.FrmPaqueteBusq_Activated);
            this.Load += new System.EventHandler(this.FrmPaqueteBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoPaqueteCbo;
        private System.Windows.Forms.CheckBox TipoPaqueteChk;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.CheckBox DniChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ComboBox AgenciaCbo;
        private System.Windows.Forms.CheckBox AgenciaChk;
    }
}