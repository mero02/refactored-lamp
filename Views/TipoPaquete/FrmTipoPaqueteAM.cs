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
    [Permiso(ClaseBaseForm = "Tipo Paquete", FuncionPermiso = "AltaTipoPaquete,ModificaTipoPaquete,ConsultaTipoPaquete", RolUsuario = "administrador,operadorTurno,consulta,operador")]
    public partial class FrmTipoPaqueteAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private TipoPaquete _Tipo_Paquete_modif = null;
        private string TipoPaqueteLog = "";

        public FrmTipoPaqueteAM()
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
                    this.Text = "Ingreso de nuevo Tipo Paquete...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Tipo Paquete...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Tipo Paquete...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }


        public void ShowModificarTipoPaquete(FormBase Invoker, TipoPaquete Tipq_modif)
        {
            ShowInfoTipoPaqueteInForm(Tipq_modif, Invoker);
        }
        public void ShowModificarTipoPaquete(TipoPaquete Tipq_modif)
        {
            ShowInfoTipoPaqueteInForm(Tipq_modif, null);
        }
        private void ShowInfoTipoPaqueteInForm(TipoPaquete Tipq_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Tipo_Paquete_modif = Tipq_modif;
            TipoPaqueteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Tipo_Paquete_modif);
                      
            FormBase.ShowDataFromModel(this, Tipq_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoTipoPaquete(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoTipoPaquete()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            //Implementar
        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            //Implementar
        }

        private void ActividadedsGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           /* for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadesGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as Actividad).Codigo;
            }
            for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadesGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as Actividad).TipoActividadObj.Nombre;
            }*/

        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DuracionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Implementar
        }

        private void NivelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }

        private void FrmTipoPaqueteAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default; 
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            TipoPaquete TipoPaquete = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre de tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }
            if (DescripcionTxt.Text == "")
            {
                MessageBox.Show("Ingrese descripcion de tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTxt.Focus();
                return;
            }

            if (DuracionTxt.Text == "")
            {
                MessageBox.Show("Ingrese duracion de tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DuracionTxt.Focus();
                return;
            }
            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel de tipo paqueted", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                TipoPaquete = new TipoPaquete();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.

            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                TipoPaquete = _Tipo_Paquete_modif;
                detalleLog = "OBJ-Antes:" + TipoPaqueteLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, TipoPaquete, OperacionForm);
            /*
            Turista.NroDocumento = Convert.ToInt32(DniTxt.Text);
            Turista.Nombre = NombreTxt.Text;            
            Turista.Domicilio = DomicilioTxt.Text;
            Turista.CodPais= Convert.ToInt32(PaisCbo.SelectedValue);
            Turista.Observaciones = ObservacionesTxt.Text;
            Turista.Telefono = TelefonoTxt.Text;
             * */
            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(TipoPaquete);
            // intentar guardar en la Base de datos.
            try
            {
                TipoPaquete.SaveObj();
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
                    DoCompleteOperationForm(TipoPaquete, new EventArgDom { ObjProcess = TipoPaquete, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(TipoPaquete, new EventArgDom { ObjProcess = TipoPaquete, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        private void FrmTipoPaqueteAM_Load(object sender, EventArgs e)
        {
            this.GuardarBtn.Enabled = true;
            this.ActividadesGrd.AutoGenerateColumns = false;
            //this.TuristasGrd.DataSource = Turista.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            var actividades = Actividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var actividadesBindingList = new BindingList<Actividad>(actividades);
            var actividadesBindingSource = new BindingSource(actividadesBindingList, null);
            this.ActividadesGrd.DataSource = actividadesBindingSource;


            //this.ActividadesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(TuristasGrd_ColumnHeaderMouseClick);
        }

    }
}
