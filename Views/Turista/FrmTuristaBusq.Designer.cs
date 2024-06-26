namespace TurApp.Views
{
    partial class FrmTuristaBusq
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
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.PaisChk = new System.Windows.Forms.CheckBox();
            this.PaisCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(352, 19);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(182, 20);
            this.NombreTxt.TabIndex = 3;
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(277, 19);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 2;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombresChk_CheckedChanged);
            // 
            // DniTxt
            // 
            this.DniTxt.Enabled = false;
            this.DniTxt.Location = new System.Drawing.Point(74, 19);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(123, 20);
            this.DniTxt.TabIndex = 1;
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxt_KeyPress);
            // 
            // DniChk
            // 
            this.DniChk.AutoSize = true;
            this.DniChk.Location = new System.Drawing.Point(9, 18);
            this.DniChk.Margin = new System.Windows.Forms.Padding(2);
            this.DniChk.Name = "DniChk";
            this.DniChk.Size = new System.Drawing.Size(42, 17);
            this.DniChk.TabIndex = 0;
            this.DniChk.Text = "Dni";
            this.DniChk.UseVisualStyleBackColor = true;
            this.DniChk.CheckedChanged += new System.EventHandler(this.DniChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(441, 80);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 7;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(352, 80);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 6;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // PaisChk
            // 
            this.PaisChk.AutoSize = true;
            this.PaisChk.Location = new System.Drawing.Point(9, 57);
            this.PaisChk.Margin = new System.Windows.Forms.Padding(2);
            this.PaisChk.Name = "PaisChk";
            this.PaisChk.Size = new System.Drawing.Size(46, 17);
            this.PaisChk.TabIndex = 4;
            this.PaisChk.Text = "Pais";
            this.PaisChk.UseVisualStyleBackColor = true;
            this.PaisChk.CheckedChanged += new System.EventHandler(this.PaisChk_CheckedChanged);
            // 
            // PaisCbo
            // 
            this.PaisCbo.DisplayMember = "Nombre";
            this.PaisCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisCbo.Enabled = false;
            this.PaisCbo.FormattingEnabled = true;
            this.PaisCbo.Location = new System.Drawing.Point(74, 55);
            this.PaisCbo.Margin = new System.Windows.Forms.Padding(2);
            this.PaisCbo.Name = "PaisCbo";
            this.PaisCbo.Size = new System.Drawing.Size(206, 21);
            this.PaisCbo.TabIndex = 5;
            this.PaisCbo.ValueMember = "Codigo";
            // 
            // FrmTuristaBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 136);
            this.Controls.Add(this.PaisCbo);
            this.Controls.Add(this.PaisChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.DniTxt);
            this.Controls.Add(this.DniChk);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreChk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTuristaBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Turista...";
            this.Activated += new System.EventHandler(this.FrmTuristaBusq_Activated);
            this.Load += new System.EventHandler(this.FrmTuristaBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.CheckBox DniChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox PaisChk;
        private System.Windows.Forms.ComboBox PaisCbo;
    }
}