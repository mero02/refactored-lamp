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
            LoadComboBox(TipoPaquete.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.TipoPaqueteCbo, addSeleccion: true);
            LoadComboBox(Agencia.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.AgenciaCbo, addSeleccion: true);
            //LoadComboBox(Turista.FindAllStatic(null, (l1, l2) => l1.NroDocumento.CompareTo(l2.NroDocumento)), this.DniTuristaCbo, addSeleccion: true);
            LoadComboBox(Destino.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.CodDestinoCbo, addSeleccion: true);

            this.DniTuristaCbo.DataSource = Turista.FindAllStatic(null, (pa1, pa2) => pa1.NroDocumento.CompareTo(pa2.NroDocumento));
            FechaPaqueteTime.Format = DateTimePickerFormat.Custom;
            FechaPaqueteTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
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

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Paquete Paquete = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Paquete = new Paquete();
                operacionLog = "ALTA";
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

            ReadDataFromForm(this, Paquete,OperacionForm);

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

        private void FrmPaqueteAm_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

       
        private void NivelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

    }
}
