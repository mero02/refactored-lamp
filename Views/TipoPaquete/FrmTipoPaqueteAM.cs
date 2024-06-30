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
        private BindingList<TipoActividad> tiposActividades = new BindingList<TipoActividad>();
        
        public override event FormEvent DoCompleteOperationForm;
        private TipoPaquete _Tipo_Paquete_modif = null;
        private string TipoPaqueteLog = "";

        public FrmTipoPaqueteAM()
        {
            InitializeComponent();
            ActividadesAgregadasGrd.Enabled = false;
        }

        public void Modificacion(TipoPaquete pac)
        {
            var Actividades = TipoPaqueteTipoActividad.FindAllStatic(null, (p1, p2) => p1.CodTipoPaquete.CompareTo(p2.CodTipoPaquete));
           
            foreach (TipoPaqueteTipoActividad itm in Actividades)
            {
                TipoActividad tipoAct = new TipoActividad();
                if (pac.Codigo == itm.CodTipoPaquete)
                {
                    tipoAct.FindbyKey(itm.CodTipoActividad);
                    tiposActividades.Add(tipoAct);
                }
            }
            this.ActividadesAgregadasGrd.AutoGenerateColumns = false;
            ActividadesAgregadasGrd.DataSource = null;
            ActividadesAgregadasGrd.DataSource = tiposActividades;
        }

        private void FrmTipoPaqueteAM_Load(object sender, EventArgs e)
        {
            
            this.ActividadesGrd.AutoGenerateColumns = false;
            this.ActividadesAgregadasGrd.AutoGenerateColumns = false;
            
            var TipoActividades = TipoActividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var TipoActividadesBindingList = new BindingList<TipoActividad>(TipoActividades);
            var TipoActividadesBindingSource = new BindingSource(TipoActividadesBindingList, null);
            this.ActividadesGrd.DataSource = TipoActividadesBindingSource;

            GuardarBtn.Enabled = false;

            DuracionTime.Format = DateTimePickerFormat.Custom;
            DuracionTime.CustomFormat = "hh:mm:ss";
            DuracionTime.ShowUpDown = true;
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
            if (string.IsNullOrEmpty(NombreTxt.Text))
            {
                MessageBox.Show("Ingrese Nombre", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(DescripcionTxt.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescripcionTxt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NivelTxt.Text))
            {
                MessageBox.Show("Ingrese Nivel", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }


            if (ActividadesGrd.SelectedRows.Count > 0) // Verifica que hay una fila seleccionada
            {
                DataGridViewRow selectedRow = ActividadesGrd.SelectedRows[0];

                // Extrae los datos de la fila seleccionada
                string codTipoAct = selectedRow.Cells["CodActCol"].Value.ToString();
                //codigos.Add(codTipoPaq); 
                TipoActividad tipoAct = new TipoActividad();
                tiposActividades.Add(tipoAct.FindbyKey(codTipoAct));
               
                ActividadesAgregadasGrd.DataSource = null;
                ActividadesAgregadasGrd.DataSource = tiposActividades;
                MessageBox.Show("Tipo actividad agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (ActividadesGrd.SelectedRows.Count > 0) // Verifica que hay una fila seleccionada
            {
                DataGridViewRow selectedRow = ActividadesGrd.SelectedRows[0];

                // Extrae los datos de la fila seleccionada
                string codTipoAct = selectedRow.Cells["CodActCol"].Value.ToString();
                TipoActividad tipoAct = tiposActividades.FirstOrDefault(t => t.Codigo == int.Parse(codTipoAct));

                if (tipoAct != null)
                {
                    tiposActividades.Remove(tipoAct);
                    if (tiposActividades.Count == 0)
                    {
                        GuardarBtn.Enabled = false;
                    }
                    MessageBox.Show("Tipo actividad quitado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El tipo de actividad seleccionado no se encuentra en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ActividadedsGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.ActividadesGrd.DataBindingComplete -= ActividadedsGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.ActividadesGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as TipoActividad).Codigo;
                    item.Cells[1].Value = (item.DataBoundItem as TipoActividad).Nombre;

                    string duracionString = (item.DataBoundItem as TipoActividad).Duracion;

                    DateTime duracion;
                    if (DateTime.TryParse(duracionString, out duracion))
                    {
                        item.Cells[2].Value = duracion.ToString("HH:mm");
                    }
                    else
                    {
                        item.Cells[2].Value = duracionString;
                    }
                }
            }
            finally
            {
                this.ActividadesGrd.DataBindingComplete += ActividadedsGrd_DataBindingComplete;
            }

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

            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese nivel de tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                TipoPaquete = new TipoPaquete();
                operacionLog = "ALTA";
                // cargar la info de la TipoPaquete antes de dar de alta.

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

            foreach (TipoActividad act in tiposActividades)
            {
                TipoPaqueteTipoActividad TipoPactipoAct = new TipoPaqueteTipoActividad();
                TipoPactipoAct.CodTipoPaquete = TipoPaquete.Codigo;
                TipoPactipoAct.CodTipoActividad = act.Codigo;
                try
                {
                    TipoPactipoAct.SaveObj();
                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
                }
                catch (Exception ex)
                {
                    errMsj = "Error: " + ex.Message;
                }
                
            }
            
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }



    }
}
