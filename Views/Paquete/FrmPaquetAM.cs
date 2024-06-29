using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;
using Newtonsoft;


namespace TurApp.Views
{
    [Permiso(ClaseBaseForm = "Paquete", FuncionPermiso = "AltaPaquete,ModificaPaquete,ConsultaPaquete", RolUsuario = "administrador,operadorTurno,consulta,operador")]

    public partial class FrmPaqueteAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Paquete _Paquete_modif = null;
        private string PaqueteLog = "";

        public FrmPaqueteAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }

        private void FrmPaquetAM_Load(object sender, EventArgs e)
        {
            LoadComboBox(TipoPaquete.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.TipoPaqueteCbo, addSeleccion: true);
            LoadComboBox(Agencia.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.AgenciaCbo, addSeleccion: true);
            LoadComboBox(Destino.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.CodDestinoCbo, addSeleccion: true);

            this.DniTuristaCbo.DataSource = Turista.FindAllStatic(null, (pa1, pa2) => pa1.NroDocumento.CompareTo(pa2.NroDocumento));
            FechaPaqueteTime.Format = DateTimePickerFormat.Custom;
            FechaPaqueteTime.CustomFormat = "yyyy-MM-dd";
        }
       
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Paquete...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos del Paquete..";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos del Paquete..";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Paquete Paquete = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (TipoPaqueteCbo.SelectedItem == null || string.IsNullOrEmpty(TipoPaqueteCbo.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese un Tipo paquete", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TipoPaqueteCbo.Focus();
                return;
            }

            if (AgenciaCbo.SelectedItem == null || string.IsNullOrEmpty(AgenciaCbo.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese un Agencia", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AgenciaCbo.Focus();
                return;
            }

            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese Nivel", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }


            if (DniTuristaCbo.SelectedItem == null || string.IsNullOrEmpty(DniTuristaCbo.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese DNI del turista", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTuristaCbo.Focus();
                return;
            }

            if (CodDestinoCbo.SelectedItem == null || string.IsNullOrEmpty(CodDestinoCbo.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese Destino", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodDestinoCbo.Focus();
                return;
            }


            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Paquete = new Paquete();
                operacionLog = "ALTA";
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Paquete = _Paquete_modif;
                detalleLog = "OBJ-Antes:" + PaqueteLog + " - OBJ-MOD";
            }

            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.

            ReadDataFromForm(this, Paquete,OperacionForm);

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Paquete);
            // intentar guardar en la Base de datos.
            try
            {
                Paquete.SaveObj();

                var tipo_paqActdes = TipoPaqueteTipoActividad.FindAllStatic(null, (p1, p2) => p1.CodTipoPaquete.CompareTo(p2.CodTipoPaquete));

                foreach (TipoPaqueteTipoActividad tPaqAct in tipo_paqActdes)
                {
                    if (tPaqAct.CodTipoPaquete == Paquete.CodTipoPaquete)
                    {
                        var actividades = Actividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
                        foreach (Actividad actividad in actividades)
                        {
                            if (actividad.CodTipoActividad == tPaqAct.CodTipoActividad)
                            {
                                Transporte transporte = new Transporte();
                                transporte.FindbyKey(actividad.CodTransporte);
                                TipoPaquete tipoPaq = new TipoPaquete();
                                tipoPaq.FindbyKey(tPaqAct.CodTipoPaquete);

                                PaqueteActividad paqueteActividad = new PaqueteActividad();
                                paqueteActividad.CodPaquete = Paquete.Codigo; 
                                paqueteActividad.CodActividad = actividad.Codigo;
                                paqueteActividad.Importe = transporte.Importe + actividad.Importe;
                                paqueteActividad.FechaHoraDesde = Paquete.Fecha;
                                paqueteActividad.FechaHoraHasta = Convert.ToDateTime(tipoPaq.Duracion);
                                paqueteActividad.Detalle = actividad.TipoActividadObj.Descripcion;

                                //Cuando agregamos el agenciaTipoPaquete se rompen a la hora de tratar de modificar: Agencia, tipoPaquete y Paquete

                                /*AgenciaTipoPaquete agTipo = new AgenciaTipoPaquete();
                                agTipo.CodAgencia = Paquete.CodAgencia;
                                agTipo.CodTipoPaquete = Paquete.CodTipoPaquete;*/
                                try
                                {
                                    paqueteActividad.SaveObj();
                                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
                                    /*agTipo.SaveObj();
                                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);*/
                                }
                                catch (Exception ex)
                                {
                                    errMsj = "Error: " + ex.Message;
                                }
                            }
                        }
                    }
                }

                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }

            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }

            // si esta configurado, al form invoker enviarle evento de operacion completa

            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        public void ShowModificarPaquete(FormBase Invoker, Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, Invoker);
        }

        public void ShowModificarPaquete(Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, null);
        }

        private void ShowInfoPaqueteInForm(Paquete Paq_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Paquete_modif = Paq_modif;
            PaqueteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Paquete_modif);
            // cargar cada control con informacion del Paquete....  
            FormBase.ShowDataFromModel(this, Paq_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoPaquete(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoPaquete()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmPaqueteAm_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

       
        private void NivelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void CodAgenciaLbl_Click(object sender, EventArgs e)
        {

        }

    }
}
