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
    [Permiso(ClaseBaseForm = "Localidad", FuncionPermiso = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad", RolUsuario = "administrador,operadorTurno,consulta,operador")]
    public partial class FrmTransporteAm : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Transporte _Transporte_modif = null;
        private string TransporteLog = "";


        public FrmTransporteAm()
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


        private void FrmTransporteAm_Load(object sender, EventArgs e)
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
                    this.Text = "Ingreso de nuevo Transporte...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Transporte...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Transporte...";
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
            Transporte Transporte = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (DominioTxt.Text == "")
            {
                MessageBox.Show("Ingrese Dominio", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DominioTxt.Focus();
                return;
            }
            if (DescripcionTxt.Text == "")
            {
                MessageBox.Show("Ingrese Descripcion", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTxt.Focus();
                return;
            }

            if (ImporteTxt.Text == "")
            {
                MessageBox.Show("Ingrese Importe", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ImporteTxt.Focus();
                return;
            }

 
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Transporte = new Transporte();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Transporte = _Transporte_modif;
                detalleLog = "OBJ-Antes:" + TransporteLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, Transporte, OperacionForm);

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Transporte);
            // intentar guardar en la Base de datos.
            try
            {
                Transporte.SaveObj();
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
                    DoCompleteOperationForm(Transporte, new EventArgDom { ObjProcess = Transporte, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Transporte, new EventArgDom { ObjProcess = Transporte, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();

        }

        public void ShowModificarTransporte(FormBase Invoker, Transporte Transporte_modif)
        {
            ShowInfoTransporteInForm(Transporte_modif, Invoker);
        }
        public void ShowModificarTransporte(Transporte Transporte_modif)
        {
            ShowInfoTransporteInForm(Transporte_modif, null);
        }
        private void ShowInfoTransporteInForm(Transporte Transporte_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Transporte_modif = Transporte_modif;
            TransporteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Transporte_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Transporte_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoTransporte(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoTransporte()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void DominioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
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

        private void ImporteTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }
    }
}
