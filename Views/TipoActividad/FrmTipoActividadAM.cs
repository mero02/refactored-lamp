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
    [Permiso(ClaseBaseForm = "TipoActividad", FuncionPermiso = "AltaTipoActividad,ModificaTipoActividad,ConsultaTipoActividad", RolUsuario = "administrador,operadorTurista,operadorTurno,consulta,operador")]
    public partial class FrmTipoActividadAM : FormBase{
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private TipoActividad _Tipo_Actividad_modif = null;
        private string TipoActividadLog = "";
    
        public FrmTipoActividadAM()
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
        public void ShowIngresoTipoActividad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoTipoActividad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowModificarTipoActividad(FormBase Invoker, TipoActividad Tipq_modif)
        {
            ShowInfoTipoActividadInForm(Tipq_modif, Invoker);
        }
        public void ShowModificarTipoActividad(TipoActividad Tipq_modif)
        {
            ShowInfoTipoActividadInForm(Tipq_modif, null);
        }
        private void ShowInfoTipoActividadInForm(TipoActividad Tipq_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Tipo_Actividad_modif = Tipq_modif;
            TipoActividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Tipo_Actividad_modif);

            FormBase.ShowDataFromModel(this, Tipq_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        private void FrmTipoActividadAM_Load(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            TipoActividad TipoActividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre del tipo de actividad", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }
            if (DescripcionTxt.Text == "")
            {
                MessageBox.Show("Ingrese descripcion del tipo de actividad", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTxt.Focus();
                return;
            }

            if (DuracionTxt.Text == "")
            {
                MessageBox.Show("Ingrese duracion del tipo actividad", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DuracionTxt.Focus();
                return;
            }
            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel de tipo actividad", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                TipoActividad = new TipoActividad();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.

            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                TipoActividad = _Tipo_Actividad_modif;
                detalleLog = "OBJ-Antes:" + TipoActividadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, TipoActividad, OperacionForm);
           
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(TipoActividad);
            // intentar guardar en la Base de datos.
            try
            {
                TipoActividad.SaveObj();
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
                    DoCompleteOperationForm(TipoActividad, new EventArgDom { ObjProcess = TipoActividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(TipoActividad, new EventArgDom { ObjProcess = TipoActividad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NivelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }  
        }

        private void DescripcionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
