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
    public partial class FrmTipoPaqueteList : FormBase
    {
        private string _criterio = null;
        private List<TipoPaquete> _listado;

        public FrmTipoPaqueteList()
        {
            InitializeComponent();
        }

        public void ShowListado(List<TipoPaquete> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoPaquetesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<TipoPaquete>(listado);
            var source = new BindingSource(bindingList, null);
            this.TipoPaquetesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmTipoPaqueteList_Load(object sender, EventArgs e)
        {

        }
        private void CerrarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoPaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TipoPaquetesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoPaqueteAM frm = new FrmTipoPaqueteAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTipoPaquete(this, (this.TipoPaquetesGrd.SelectedRows[0].DataBoundItem as TipoPaquete));
            }

        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TipoPaquetesGrd.SelectedRows[0].Index;
                this.TipoPaquetesGrd.DataSource = TipoPaquete.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                TipoPaquetesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo Paquete actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TipoPaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.TipoPaquetesGrd.DataBindingComplete -= TipoPaquetesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.TipoPaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.TipoPaquetesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as TipoPaquete).Nombre;
                }
            }

            finally
            {
                this.TipoPaquetesGrd.DataBindingComplete += TipoPaquetesGrd_DataBindingComplete;
            }
        }
    }
}

