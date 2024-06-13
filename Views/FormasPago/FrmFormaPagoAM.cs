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
    [Permiso(ClaseBaseForm = "FormaPago", FuncionPermiso = "AltaFormaPago,ModificaFormaPago,ConsultaFormaPago", RolUsuario = "administrador,operadorTurno,operador")]
    public partial class FrmFormaPagoAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private FormaPago _FormaPago_modif = null;
        private string FormaPagoLog = "";
        public FrmFormaPagoAM()
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
        private void FrmFormaPagoAM_Load(object sender, EventArgs e)
        {

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
                    this.Text = "Ingreso de nueva Forma de Pago...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Forma de Pago...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Forma de Pago...";
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
            FormaPago FormaPago = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (FormaPagoTxt.Text == "")
            {
                MessageBox.Show("Ingrese Nombre de la Forma de pago", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FormaPagoTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                FormaPago = new FormaPago();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.
                FormaPago.Forma = FormaPagoTxt.Text;
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                FormaPago = _FormaPago_modif;
                detalleLog = "OBJ-Antes:" + FormaPagoLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, FormaPago,OperacionForm);
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(FormaPago);
            // intentar guardar en la Base de datos.
            try
            {
                FormaPago.SaveObj();
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
                    DoCompleteOperationForm(FormaPago, new EventArgDom { ObjProcess = FormaPago, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(FormaPago, new EventArgDom { ObjProcess = FormaPago, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();

        }

        public void ShowModificarFormaPago(FormBase Invoker, FormaPago For_modif)
        {
            ShowInfoFormaPagoInForm(For_modif, Invoker);
        }
        public void ShowModificarFormaPago(FormaPago For_modif)
        {
            ShowInfoFormaPagoInForm(For_modif, null);
        }
        private void ShowInfoFormaPagoInForm(FormaPago For_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _FormaPago_modif = For_modif;
            FormaPagoLog = Newtonsoft.Json.JsonConvert.SerializeObject(_FormaPago_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, For_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoFormaPago(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoFormaPago()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }


        private void FrmFormaPagoAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }
    }
}
