namespace TurApp.Views
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Turistas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TuristaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTuristaMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Agencias_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.AgenciaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarAgencia_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActividad_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActivAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTipoAct_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Localidades_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalidadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarLocalidad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Actividad_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarActividad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Paquetes_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.PaqueteAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarPaquete_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoPaquete_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoPaqueteAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTipoPaquete_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.FormaPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Listados_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TuristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ActividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FormaPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoActividadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturar_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDe_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusInfoUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Turistas_mnu_top,
            this.Agencias_mnu_top,
            this.TipoActividad_mnu_top,
            this.Localidades_mnu_top,
            this.Actividad_mnu_top,
            this.Paquetes_mnu_top,
            this.TipoPaquete_mnu_top,
            this.FormaPagoToolStripMenuItem,
            this.Listados_mnu_top,
            this.Facturar_mnu_top,
            this.AcercaDe_mnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1492, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Turistas_mnu_top
            // 
            this.Turistas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TuristaAM_mnu,
            this.BuscarTuristaMnu});
            this.Turistas_mnu_top.Name = "Turistas_mnu_top";
            this.Turistas_mnu_top.Size = new System.Drawing.Size(71, 24);
            this.Turistas_mnu_top.Tag = "AltaTurista,ModificaTurista,ConsultaTurista";
            this.Turistas_mnu_top.Text = "Turistas";
            this.Turistas_mnu_top.Click += new System.EventHandler(this.Turistas_mnu_top_Click);
            // 
            // TuristaAM_mnu
            // 
            this.TuristaAM_mnu.Name = "TuristaAM_mnu";
            this.TuristaAM_mnu.Size = new System.Drawing.Size(152, 24);
            this.TuristaAM_mnu.Tag = "AltaTurista";
            this.TuristaAM_mnu.Text = "Ingreso";
            this.TuristaAM_mnu.Click += new System.EventHandler(this.IngresoTuristaMnu_Click);
            // 
            // BuscarTuristaMnu
            // 
            this.BuscarTuristaMnu.Name = "BuscarTuristaMnu";
            this.BuscarTuristaMnu.Size = new System.Drawing.Size(152, 24);
            this.BuscarTuristaMnu.Tag = "ModificaTurista,ConsultaTurista";
            this.BuscarTuristaMnu.Text = "Buscar...";
            this.BuscarTuristaMnu.Click += new System.EventHandler(this.BuscarTuristaMnu_Click);
            // 
            // Agencias_mnu_top
            // 
            this.Agencias_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgenciaAM_mnu,
            this.BuscarAgencia_mnu});
            this.Agencias_mnu_top.Name = "Agencias_mnu_top";
            this.Agencias_mnu_top.Size = new System.Drawing.Size(81, 24);
            this.Agencias_mnu_top.Tag = "AltaAgencia,ModificaAgencia,ConsultaAgencia";
            this.Agencias_mnu_top.Text = "Agencias";
            // 
            // AgenciaAM_mnu
            // 
            this.AgenciaAM_mnu.Name = "AgenciaAM_mnu";
            this.AgenciaAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.AgenciaAM_mnu.Tag = "AltaAgencia";
            this.AgenciaAM_mnu.Text = "Ingreso";
            this.AgenciaAM_mnu.Click += new System.EventHandler(this.IngresoAgencia_Click);
            // 
            // BuscarAgencia_mnu
            // 
            this.BuscarAgencia_mnu.Name = "BuscarAgencia_mnu";
            this.BuscarAgencia_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarAgencia_mnu.Tag = "ModificaAgencia,ConsultaAgencia";
            this.BuscarAgencia_mnu.Text = "Buscar";
            this.BuscarAgencia_mnu.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // TipoActividad_mnu_top
            // 
            this.TipoActividad_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoActivAM_mnu,
            this.BuscarTipoAct_mnu});
            this.TipoActividad_mnu_top.Name = "TipoActividad_mnu_top";
            this.TipoActividad_mnu_top.Size = new System.Drawing.Size(138, 24);
            this.TipoActividad_mnu_top.Tag = "AltaTipoActividad,ModificaTipoActividad,ConsultaTipoActividad";
            this.TipoActividad_mnu_top.Text = "Tipos Actividades";
            // 
            // TipoActivAM_mnu
            // 
            this.TipoActivAM_mnu.Name = "TipoActivAM_mnu";
            this.TipoActivAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.TipoActivAM_mnu.Tag = "AltaTipoActividad";
            this.TipoActivAM_mnu.Text = "Ingreso";
            // 
            // BuscarTipoAct_mnu
            // 
            this.BuscarTipoAct_mnu.Name = "BuscarTipoAct_mnu";
            this.BuscarTipoAct_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarTipoAct_mnu.Tag = "ModificaTipoActividad,ConsultaTipoActividad";
            this.BuscarTipoAct_mnu.Text = "Buscar";
            // 
            // Localidades_mnu_top
            // 
            this.Localidades_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalidadAM_mnu,
            this.BuscarLocalidad_mnu});
            this.Localidades_mnu_top.Name = "Localidades_mnu_top";
            this.Localidades_mnu_top.Size = new System.Drawing.Size(100, 24);
            this.Localidades_mnu_top.Tag = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad";
            this.Localidades_mnu_top.Text = "Localidades";
            // 
            // LocalidadAM_mnu
            // 
            this.LocalidadAM_mnu.Name = "LocalidadAM_mnu";
            this.LocalidadAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.LocalidadAM_mnu.Tag = "AltaLocalidad";
            this.LocalidadAM_mnu.Text = "Ingreso";
            // 
            // BuscarLocalidad_mnu
            // 
            this.BuscarLocalidad_mnu.Name = "BuscarLocalidad_mnu";
            this.BuscarLocalidad_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarLocalidad_mnu.Tag = "ModificaLocalidad,ConsultaLocalidad";
            this.BuscarLocalidad_mnu.Text = "Buscar";
            // 
            // Actividad_mnu_top
            // 
            this.Actividad_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActividadAM_mnu,
            this.BuscarActividad_mnu});
            this.Actividad_mnu_top.Name = "Actividad_mnu_top";
            this.Actividad_mnu_top.Size = new System.Drawing.Size(98, 24);
            this.Actividad_mnu_top.Tag = "AltaActividad,ModificaActividad,ConsultaActividad";
            this.Actividad_mnu_top.Text = "Actividades";
            // 
            // ActividadAM_mnu
            // 
            this.ActividadAM_mnu.Name = "ActividadAM_mnu";
            this.ActividadAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.ActividadAM_mnu.Tag = "AltaActividad";
            this.ActividadAM_mnu.Text = "Ingreso";
            this.ActividadAM_mnu.Click += new System.EventHandler(this.ActividadAM_mnu_Click);
            // 
            // BuscarActividad_mnu
            // 
            this.BuscarActividad_mnu.Name = "BuscarActividad_mnu";
            this.BuscarActividad_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarActividad_mnu.Tag = "ModificaActividad,ConsultaActividad";
            this.BuscarActividad_mnu.Text = "Buscar";
            // 
            // Paquetes_mnu_top
            // 
            this.Paquetes_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaqueteAM_mnu,
            this.BuscarPaquete_mnu});
            this.Paquetes_mnu_top.Name = "Paquetes_mnu_top";
            this.Paquetes_mnu_top.Size = new System.Drawing.Size(80, 24);
            this.Paquetes_mnu_top.Tag = "AltaPaquete,ModificaPaquete,ConsultaPaquete";
            this.Paquetes_mnu_top.Text = "Paquetes";
            // 
            // PaqueteAM_mnu
            // 
            this.PaqueteAM_mnu.Name = "PaqueteAM_mnu";
            this.PaqueteAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.PaqueteAM_mnu.Tag = "AltaPaquete";
            this.PaqueteAM_mnu.Text = "Ingreso";
            // 
            // BuscarPaquete_mnu
            // 
            this.BuscarPaquete_mnu.Name = "BuscarPaquete_mnu";
            this.BuscarPaquete_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarPaquete_mnu.Tag = "ModificaPaquete,ConsultaPaquete";
            this.BuscarPaquete_mnu.Text = "Buscar";
            // 
            // TipoPaquete_mnu_top
            // 
            this.TipoPaquete_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoPaqueteAM_mnu,
            this.BuscarTipoPaquete_mnu});
            this.TipoPaquete_mnu_top.Name = "TipoPaquete_mnu_top";
            this.TipoPaquete_mnu_top.Size = new System.Drawing.Size(114, 24);
            this.TipoPaquete_mnu_top.Tag = "AltaTipoPaquete,ModificaTipoPaquete,ConsultaTipoPaquete";
            this.TipoPaquete_mnu_top.Text = "Tipos Paquete";
            // 
            // TipoPaqueteAM_mnu
            // 
            this.TipoPaqueteAM_mnu.Name = "TipoPaqueteAM_mnu";
            this.TipoPaqueteAM_mnu.Size = new System.Drawing.Size(127, 24);
            this.TipoPaqueteAM_mnu.Tag = "AltaTipoPaquete";
            this.TipoPaqueteAM_mnu.Text = "Ingreso";
            // 
            // BuscarTipoPaquete_mnu
            // 
            this.BuscarTipoPaquete_mnu.Name = "BuscarTipoPaquete_mnu";
            this.BuscarTipoPaquete_mnu.Size = new System.Drawing.Size(127, 24);
            this.BuscarTipoPaquete_mnu.Tag = "ModificaTipoPaquete,ConsultaTipoPaquete";
            this.BuscarTipoPaquete_mnu.Text = "Buscar";
            // 
            // FormaPagoToolStripMenuItem
            // 
            this.FormaPagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.FormaPagoToolStripMenuItem.Name = "FormaPagoToolStripMenuItem";
            this.FormaPagoToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.FormaPagoToolStripMenuItem.Tag = "AltaFormaPago,ModificaFormaPago,ConsultaFormaPago";
            this.FormaPagoToolStripMenuItem.Text = "Forma Pago";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.ingresoToolStripMenuItem.Tag = "AltaFormaPago";
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.buscarToolStripMenuItem.Tag = "ModificaFormaPago,ConsultaFormaPago";
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // Listados_mnu_top
            // 
            this.Listados_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TuristasToolStripMenuItem,
            this.AgenciasToolStripMenuItem,
            this.localidadesToolStripMenuItem1,
            this.ActividadesToolStripMenuItem1,
            this.FormaPagosToolStripMenuItem,
            this.auditoriaToolStripMenuItem,
            this.PaqueteToolStripMenuItem,
            this.TipoActividadToolStripMenuItem1});
            this.Listados_mnu_top.Name = "Listados_mnu_top";
            this.Listados_mnu_top.Size = new System.Drawing.Size(75, 24);
            this.Listados_mnu_top.Tag = "Listados";
            this.Listados_mnu_top.Text = "Listados";
            // 
            // TuristasToolStripMenuItem
            // 
            this.TuristasToolStripMenuItem.Name = "TuristasToolStripMenuItem";
            this.TuristasToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.TuristasToolStripMenuItem.Tag = "ConsultaTurista";
            this.TuristasToolStripMenuItem.Text = "Turistas";
            this.TuristasToolStripMenuItem.Click += new System.EventHandler(this.ListadoTuristaMnu_Click);
            // 
            // AgenciasToolStripMenuItem
            // 
            this.AgenciasToolStripMenuItem.Name = "AgenciasToolStripMenuItem";
            this.AgenciasToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.AgenciasToolStripMenuItem.Tag = "ConsultaAgencia";
            this.AgenciasToolStripMenuItem.Text = "Agencia";
            this.AgenciasToolStripMenuItem.Click += new System.EventHandler(this.ListadoAgencias_Click);
            // 
            // localidadesToolStripMenuItem1
            // 
            this.localidadesToolStripMenuItem1.Name = "localidadesToolStripMenuItem1";
            this.localidadesToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.localidadesToolStripMenuItem1.Tag = "ConsultaLocalidad";
            this.localidadesToolStripMenuItem1.Text = "Localidades";
            // 
            // ActividadesToolStripMenuItem1
            // 
            this.ActividadesToolStripMenuItem1.Name = "ActividadesToolStripMenuItem1";
            this.ActividadesToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.ActividadesToolStripMenuItem1.Tag = "ConsultaActividad";
            this.ActividadesToolStripMenuItem1.Text = "Actividades";
            // 
            // FormaPagosToolStripMenuItem
            // 
            this.FormaPagosToolStripMenuItem.Name = "FormaPagosToolStripMenuItem";
            this.FormaPagosToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.FormaPagosToolStripMenuItem.Tag = "ConsultaFormaPago";
            this.FormaPagosToolStripMenuItem.Text = "FormaPagos";
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.auditoriaToolStripMenuItem.Tag = "ConsultaAuditoria";
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // PaqueteToolStripMenuItem
            // 
            this.PaqueteToolStripMenuItem.Name = "PaqueteToolStripMenuItem";
            this.PaqueteToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.PaqueteToolStripMenuItem.Tag = "ConsultaPaquete";
            this.PaqueteToolStripMenuItem.Text = "Paquete";
            // 
            // TipoActividadToolStripMenuItem1
            // 
            this.TipoActividadToolStripMenuItem1.Name = "TipoActividadToolStripMenuItem1";
            this.TipoActividadToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.TipoActividadToolStripMenuItem1.Tag = "ConsultaTipoActividad";
            this.TipoActividadToolStripMenuItem1.Text = "Tipo Actividad";
            // 
            // Facturar_mnu_top
            // 
            this.Facturar_mnu_top.Name = "Facturar_mnu_top";
            this.Facturar_mnu_top.Size = new System.Drawing.Size(73, 24);
            this.Facturar_mnu_top.Tag = "Facturar";
            this.Facturar_mnu_top.Text = "Facturar";
            // 
            // AcercaDe_mnu
            // 
            this.AcercaDe_mnu.Name = "AcercaDe_mnu";
            this.AcercaDe_mnu.Size = new System.Drawing.Size(96, 24);
            this.AcercaDe_mnu.Text = "Acerca de...";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfoUser});
            this.status.Location = new System.Drawing.Point(0, 785);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.status.Size = new System.Drawing.Size(1492, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // StatusInfoUser
            // 
            this.StatusInfoUser.Name = "StatusInfoUser";
            this.StatusInfoUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 807);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurApp: Registro de información";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem Turistas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TuristaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarTuristaMnu;
        private System.Windows.Forms.ToolStripMenuItem Agencias_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem AgenciaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarAgencia_mnu;
        private System.Windows.Forms.ToolStripMenuItem TipoActividad_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Localidades_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Paquetes_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TipoPaquete_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TipoActivAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem LocalidadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem PaqueteAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem TipoPaqueteAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem Listados_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TuristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarTipoAct_mnu;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ActividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FormaPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Facturar_mnu_top;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfoUser;
        private System.Windows.Forms.ToolStripMenuItem PaqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarLocalidad_mnu;
        private System.Windows.Forms.ToolStripMenuItem Actividad_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem ActividadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarActividad_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarPaquete_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarTipoPaquete_mnu;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe_mnu;
        private System.Windows.Forms.ToolStripMenuItem FormaPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoActividadToolStripMenuItem1;

    }
}