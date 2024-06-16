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
    [Permiso(ClaseBaseForm = "FacturaTurista", FuncionPermiso = "Facturar", RolUsuario = "administrador,operador")]
    public partial class FrmFacturaAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private FacturaTurista _Factura_modif = null;
        private string FacturaLog = "";
        public FrmFacturaAM()
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
        private void FrmFacturaAM_Load(object sender, EventArgs e)
        {
            this.GuardarBtn.Enabled = true;
            LoadComboBox(FormaPago.FindAllStatic(null, (l1, l2) => l1.Forma.CompareTo(l2.Forma)), this.FormaPagoCbo, addSeleccion: true);
            FechaFacturaTime.Format = DateTimePickerFormat.Custom;
            FechaFacturaTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void FrmFacturaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;   
        }

        private void NroTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }

        private void SerieTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }

        private void DniTuristaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LetraTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadCombos()
        {
            this.DniTuristaCbo.DataSource = Turista.FindAllStatic(null, (pa1, pa2) => pa1.Nombre.CompareTo(pa2.Nombre));
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
                    this.DniTuristaCbo.SelectedIndex = -1;
                    this.FormaPagoCbo.SelectedIndex = -1;
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

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            FacturaTurista FacturaTurista = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (NumeroTxt.Text == "")
            {
                MessageBox.Show("Ingrese numero", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NumeroTxt.Focus();
                return;
            }
            if (SerieTxt.Text == "")
            {
                MessageBox.Show("Ingrese serie", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SerieTxt.Focus();
                return;
            }
            if (LetraTxt.Text == "")
            {
                MessageBox.Show("Ingrese letra", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LetraTxt.Focus();
                return;
            }
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                FacturaTurista = new FacturaTurista();
                operacionLog = "ALTA";
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                FacturaTurista = _Factura_modif;
                detalleLog = "OBJ-Antes:" + FacturaLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.
            ReadDataFromForm(this, FacturaTurista, OperacionForm);

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(FacturaTurista);
            // intentar guardar en la Base de datos.
            try
            {
                FacturaTurista.SaveObj();
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
                    DoCompleteOperationForm(FacturaTurista, new EventArgDom { ObjProcess = FacturaTurista, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(FacturaTurista, new EventArgDom { ObjProcess = FacturaTurista, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarTurista(FormBase Invoker, FacturaTurista Fac_modif)
        {
            ShowInfoFacturaInForm(Fac_modif, Invoker);
        }
        public void ShowModificarTurista(FacturaTurista Fac_modif)
        {
            ShowInfoFacturaInForm(Fac_modif, null);
        }
        private void ShowInfoFacturaInForm(FacturaTurista Fac_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Factura_modif = Fac_modif;
            FacturaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Factura_modif);
            // cargar cada control con informacion del Turista....            
            FormBase.ShowDataFromModel(this, Fac_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoFactura(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoFactura()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FormaPagoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
