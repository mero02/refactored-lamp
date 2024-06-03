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
    [Permiso(ClaseBaseForm="Turista", FuncionPermiso = "AltaTurista,ModificaTurista,ConsultaTurista", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmTuristaAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Turista _Turista_modif = null;
        private string TuristaLog = "";
        public FrmTuristaAM()
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
        private void FrmpTuristaAM_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCombos()
        {
            this.PaisCbo.DataSource =  Pais.FindAllStatic(null, (pa1, pa2) => pa1.Nombre.CompareTo(pa2.Nombre));

            //this.PaisCbo.DataSource = ORMDB<Localidad>.FindAll(null);
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
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Turista...";
                    this.PaisCbo.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Turista...";
                    
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Turista...";
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
            Turista Turista = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;                       
            
            if (DniTxt.Text == "")
            {
                MessageBox.Show("Ingrese dni", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Turista = new Turista();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.
            }
            
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Turista = _Turista_modif;
                detalleLog = "OBJ-Antes:" + TuristaLog + " - OBJ-MOD";                
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, Turista);
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Turista);
            // intentar guardar en la Base de datos.
            try
            {
                Turista.SaveObj();
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
                    DoCompleteOperationForm(Turista, new EventArgDom { ObjProcess = Turista, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Turista, new EventArgDom { ObjProcess = Turista, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarTurista(FormBase Invoker, Turista Tur_modif)
        {
            ShowInfoTuristaInForm(Tur_modif, Invoker);
        }
        public void ShowModificarTurista(Turista Tur_modif)
        {
            ShowInfoTuristaInForm(Tur_modif, null);
        }
        private void ShowInfoTuristaInForm(Turista Tur_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Turista_modif = Tur_modif;
            TuristaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Turista_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Tur_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click+=new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoTurista(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoTurista()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmTuristaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }


        private void MisFactBtn_Click(object sender, EventArgs e)
        {
            // debe mostrar un formulario con un listado de las facturas que se le han hecho al turista
        }

    }
}
