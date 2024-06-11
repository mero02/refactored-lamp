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
    [Permiso(ClaseBaseForm = "Paquete", FuncionPermiso = "AltaPaquete,ModificaPaquete,ConsultaPaquete", RolUsuario = "administrador,operadorTurno,consulta,operador")]

    public partial class FrmPaqueteAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Paquete _Paquete_modif = null;
        private string PaqueteLog = "";

        public FrmPaqueteAM()
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

        private void FrmPaquetAM_Load(object sender, EventArgs e)
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
                    this.Text = "Ingreso de nuevo Paquete...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos del Paquete..";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos del Paquete..";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CodigoLbl_Click(object sender, EventArgs e)
        {

        }

        private void CodigoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodTipoPaqueteLbl_Click(object sender, EventArgs e)
        {

        }

        private void CodTipoPaqueteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodAgenciaLbl_Click(object sender, EventArgs e)
        {

        }

        private void CodAgenciaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NivelLbl_Click(object sender, EventArgs e)
        {

        }

        private void NivelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DniTuristaLbl_Click(object sender, EventArgs e)
        {

        }

        private void DniTuristaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodDestinoLbl_Click(object sender, EventArgs e)
        {

        }

        private void CodDestinoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Paquete Paquete = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (CodigoTxt.Text == "")
            {
                MessageBox.Show("Ingrese Codigo del paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodigoTxt.Focus();
                return;
            }

            if (CodTipoPaqueteTxt.Text == "")
            {
                MessageBox.Show("Ingrese codigo tipo paquete", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodTipoPaqueteTxt.Focus();
                return;
            }

            if (CodAgenciaTxt.Text == "")
            {
                MessageBox.Show("Ingrese codigo agencia", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodAgenciaTxt.Focus();
                return;
            }

            if (NivelTxt.Text == "")
            {
                MessageBox.Show("Ingrese el nivel", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NivelTxt.Focus();
                return;
            }

            if (FechaTxt.Text == "")
            {
                MessageBox.Show("Ingrese la fecha", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FechaTxt.Focus();
                return;
            }

            if (DniTuristaTxt.Text == "")
            {
                MessageBox.Show("Ingrese el dni del turisto", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DniTuristaTxt.Focus();
                return;
            }

            if (CodDestinoTxt.Text == "")
            {
                MessageBox.Show("Ingrese el Codigo de destino", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodDestinoTxt.Focus();
                return;
            }

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Paquete = new Paquete();
                operacionLog = "ALTA";
                // cargar la info de la Turista antes de dar de alta.
                /*Paquete.Codigo = int.Parse(CodigoTxt.Text);
                Paquete.CodTipoPaquete = int.Parse(CodTipoPaqueteTxt.Text);
                Paquete.CodAgencia = int.Parse(CodAgenciaTxt.Text);
                Paquete.Nivel = NivelTxt.Text;
                Paquete.Fecha = FechaTxt.Text;
                Paquete.DniTurista = DniTuristaTxt.Text;
                Paquete.CodDestino = CodDestinoTxt.Text;*/
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Paquete = _Paquete_modif;
                detalleLog = "OBJ-Antes:" + PaqueteLog + " - OBJ-MOD";
            }

            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }

            // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
            // leido desde un metodo.

            ReadDataFromForm(this, Paquete);

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Paquete);
            // intentar guardar en la Base de datos.
            try
            {
                Paquete.SaveObj();
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
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Paquete, new EventArgDom { ObjProcess = Paquete, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();

        }
        public void ShowModificarPaquete(FormBase Invoker, Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, Invoker);
        }
        public void ShowModificarPaquete(Paquete Paq_modif)
        {
            ShowInfoPaqueteInForm(Paq_modif, null);
        }

        private void ShowInfoPaqueteInForm(Paquete Paq_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Paquete_modif = Paq_modif;
            PaqueteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Paquete_modif);
            // cargar cada control con informacion del Paquete....  
            FormBase.ShowDataFromModel(this, Paq_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }

        public void ShowIngresoPaquete(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoPaquete()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void CodigoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void FrmPaqueteAm_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

      
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FechaLbl_Click(object sender, EventArgs e)
        {

        }

        private void FechaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        internal void ShowIngresoPaquete(MainView mainView)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
