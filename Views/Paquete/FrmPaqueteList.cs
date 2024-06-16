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
    public partial class FrmPaqueteList : FormBase
    {
        private string _criterio = null;
        private List<Paquete> _listado;
        
        public FrmPaqueteList()
        {
            InitializeComponent();
        }

        public void ShowListado(List<Paquete> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.PaquetesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Paquete>(listado);
            var source = new BindingSource(bindingList, null);
            this.PaquetesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmPaqueteList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.PaquetesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmPaqueteAM frm = new FrmPaqueteAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarPaquete(this, (this.PaquetesGrd.SelectedRows[0].DataBoundItem as Paquete));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = PaquetesGrd.SelectedRows[0].Index;
                this.PaquetesGrd.DataSource = Paquete.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                PaquetesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Paquete actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PaquetesGrd.DataBindingComplete -= PaquetesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as Paquete).Codigo;
                }

                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as Paquete).TipoPaqueteObj.Nombre;
                }

                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[2].Value = (item.DataBoundItem as Paquete).AgenciaObj.Nombre;
                }

                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[6].Value = (item.DataBoundItem as Paquete).DestinoObj.Nombre;
                }
            }

            finally
            {
                this.PaquetesGrd.DataBindingComplete += PaquetesGrd_DataBindingComplete;
            }
        }
    }
}
