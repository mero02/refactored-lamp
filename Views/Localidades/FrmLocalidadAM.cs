using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;

namespace TurApp.Views
{
     [Permiso(ClaseBaseForm = "Localidad", FuncionPermiso = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad", RolUsuario = "administrador,operadorTurno,consulta,operador")]
    public partial class FrmLocalidadAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Localidad _Localidad_modif = null;
        private string LocalidadLog = "";

        public FrmLocalidadAM()
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

        private void FrmLocalidadAM_Load(object sender, EventArgs e)
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
                    this.Text = "Ingreso de nueva Localidad...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Localidad...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Localidad...";
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
            Localidad Localidad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (CodPosTxt.Text == "")
            {
                MessageBox.Show("Ingrese Codigo postal", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodPosTxt.Focus();
                return;
            }
            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese Nombre de la localidad", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Localidad = new Localidad();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.
                Localidad.Codigo = int.Parse(CodPosTxt.Text);
                Localidad.Nombre = NombreTxt.Text;
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Localidad = _Localidad_modif;
                detalleLog = "OBJ-Antes:" + LocalidadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, Localidad,OperacionForm);
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Localidad);
            // intentar guardar en la Base de datos.
            try
            {
                Localidad.SaveObj();
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
                    DoCompleteOperationForm(Localidad, new EventArgDom { ObjProcess = Localidad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Localidad, new EventArgDom { ObjProcess = Localidad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
            
        }

        public void ShowModificarLocalidad(FormBase Invoker, Localidad Loc_modif)
        {
            ShowInfoLocalidadInForm(Loc_modif, Invoker);
        }
        public void ShowModificarLocalidad(Localidad Loc_modif)
        {
            ShowInfoLocalidadInForm(Loc_modif, null);
        }
        private void ShowInfoLocalidadInForm(Localidad Loc_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Localidad_modif = Loc_modif;
            LocalidadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Localidad_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Loc_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoLocalidad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoLocalidad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void CodPosTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }  
        }

        private void FrmLocalidadAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default; 
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
