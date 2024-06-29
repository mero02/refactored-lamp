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
    [Permiso(ClaseBaseForm = "Agencia", FuncionPermiso = "AltaAgencia,ModificaAgencia,ConsultaAgencia", RolUsuario = "administrador,operadorAgencia,operadorTurno,consulta,operador")]
    public partial class FrmAgenciaAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Agencia _Agencia_modif = null;
        private string AgenciaLog = "";
        public string CodigoAgencia { get; set; }
        public FrmAgenciaAM()
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
        private void LoadCombos()
        {
            this.LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (pa1, pa2) => pa1.Nombre.CompareTo(pa2.Nombre));

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
                this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo Agencia...";
                    this.LocalidadCbo.SelectedIndex = -1;
                    MisPaquetesBtn.Enabled = false;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Agencia...";

                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Agencia...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarAgencia(FormBase Invoker, Agencia Pac_modif)
        {
            ShowInfoAgenciaInForm(Pac_modif, Invoker);
        }
        public void ShowModificarAgencia(Agencia Pac_modif)
        {
            ShowInfoAgenciaInForm(Pac_modif, null);
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowInfoAgenciaInForm(Agencia Cli_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Agencia_modif = Cli_modif;
            CodigoAgencia = Cli_modif.Codigo.ToString();
            AgenciaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Agencia_modif);
            FormBase.ShowDataFromModel(this, Cli_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoAgencia(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoAgencia()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Agencia Agencia = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }

            if (CalleTxt.Text == "")
            {
                MessageBox.Show("Ingrese Calle", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CalleTxt.Focus();
                return;
            }

            if (NroTxt.Text == "")
            {
                MessageBox.Show("Ingrese Numero", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NroTxt.Focus();
                return;
            }

            if (PisoTxt.Text == "")
            {
                MessageBox.Show("Ingrese Piso", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PisoTxt.Focus();
                return;
            }

            if (DptoTxt.Text == "")
            {
                MessageBox.Show("Ingrese Departamento", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DptoTxt.Focus();
                return;
            }

            if (LocalidadCbo.SelectedItem == null || string.IsNullOrEmpty(LocalidadCbo.SelectedItem.ToString()))
            {
                MessageBox.Show("Ingrese una Localidad", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LocalidadCbo.Focus();
                return;
            }

            if (Telefono1Txt.Text == "")
            {
                MessageBox.Show("Ingrese un Telefono", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Telefono1Txt.Focus();
                return;
            }

         

            
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Agencia = new Agencia();
                operacionLog = "ALTA";
                // cargar la info de la Agencia antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Agencia = _Agencia_modif;
                detalleLog = "OBJ-Antes:" + AgenciaLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }
            // validar los campos
            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, Agencia,OperacionForm);            
            // intentar guardar en la Base de datos.
            try
            {
                Agencia.SaveObj();
                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Agencia);
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
                    DoCompleteOperationForm(Agencia, new EventArgDom { ObjProcess = Agencia, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Agencia, new EventArgDom { ObjProcess = Agencia, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }

        private void DptoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }            
        }

        private void Telefono2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MisPaqBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (!string.IsNullOrEmpty(CodigoAgencia))
            {
                FrmListPaqAgen frm = new FrmListPaqAgen(CodigoAgencia);
                frm.ShowListPaqAgen(this);
            }
            else
            {
                MessageBox.Show("El código de la agencia no está disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MainView.Instance.Cursor = Cursors.Default;
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void CalleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void NroTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PisoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void Telefono1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Telefono2Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
