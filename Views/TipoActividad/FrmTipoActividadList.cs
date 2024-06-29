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
    public partial class FrmTipoActividadList : FormBase
    {
        private string _criterio = null;
        private List<TipoActividad> _listado;
        public FrmTipoActividadList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<TipoActividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoActividadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<TipoActividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.TipoActividadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
        private void FrmTipoActividadList_Load(object sender, EventArgs e)
        {

        }

       
        private void TipoActividadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.TipoActividadGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.TipoActividadGrd.Rows[i];
                item.Cells[3].Value = (item.DataBoundItem as TipoActividad).Duracion;
            }
        }
        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TipoActividadGrd.SelectedRows[0].Index;
                this.TipoActividadGrd.DataSource = TipoActividad.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                TipoActividadGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo actividad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TipoActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TipoActividadGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoActividadAM frm = new FrmTipoActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTipoActividad(this, (this.TipoActividadGrd.SelectedRows[0].DataBoundItem as TipoActividad));
            }

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
