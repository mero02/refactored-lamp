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
    public partial class FrmLocalidadList : FormBase
    {
        private string _criterio = null;
        private List<Localidad> _listado;

        public FrmLocalidadList()
        {
            InitializeComponent();
        }

        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.LocalidadesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Localidad>(listado);
            var source = new BindingSource(bindingList, null);
            this.LocalidadesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmLocalidadList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.LocalidadesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmLocalidadAM frm = new FrmLocalidadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarLocalidad(this, (this.LocalidadesGrd.SelectedRows[0].DataBoundItem as Localidad));
            }

        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = LocalidadesGrd.SelectedRows[0].Index;
                this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                LocalidadesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Localidad actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocalidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.LocalidadesGrd.Rows.Count; ++i)
            {
                foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
                {
                    rw.Cells[0].Value = (rw.DataBoundItem as Localidad).Codigo;
                }

                foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
                {
                    rw.Cells[1].Value = (rw.DataBoundItem as Localidad).Nombre;
                }
            }
        }

    }
}
