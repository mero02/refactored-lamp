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
    [Permiso(ClaseBaseForm = "Actividad", FuncionPermiso = "AltaActividad,ModificaActividad,ConsultaActividad", RolUsuario = "administrador,operadorTurno,operador")]
    public partial class FrmActividadAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Actividad _Actividad_modif = null;
        private string ActividadLog = "";

        public FrmActividadAM()
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
                    this.Text = "Ingreso de nueva Actividad...";

                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Actividad...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Actividad...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void ShowModificarActividad(FormBase invoker, Actividad For_modif)
        {
            ShowInfoActividadInForm(For_modif, invoker);
        }
        
            


       

       
        public void ShowModificarActividad(Actividad For_modif)
        {
            ShowInfoActividadInForm(For_modif, null);
        }

        private void ShowInfoActividadInForm(Actividad For_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Actividad_modif = For_modif;
            ActividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Actividad_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, For_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoActividad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoActividad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        private void LoadCombos()
        {
            
            this.TransporteCbo.DataSource = Transporte.FindAllStatic(null, (pa1, pa2) => pa1.Codigo.CompareTo(pa2.Codigo));


            
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Actividad Actividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (CodigoTxt.Text == "")
            {
                MessageBox.Show("Ingrese codigo", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoTxt.Focus();
                return;
            }
            // validar...
            //.....
            //....
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Actividad = new Actividad();
                operacionLog = "ALTA";

            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Actividad = _Actividad_modif;
                detalleLog = "OBJ-Antes:" + ActividadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }


            ReadDataFromForm(this, Actividad);

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Actividad);

            try
            {
                Actividad.SaveObj();
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
                    DoCompleteOperationForm(Actividad, new EventArgDom { ObjProcess = Actividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Actividad, new EventArgDom { ObjProcess = Actividad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();

        }
    }
}
