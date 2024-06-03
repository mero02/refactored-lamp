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
    public partial class FrmTuristaList : FormBase
    {
        private string _criterio = null;
        private List<Turista> _listado;
        
        public FrmTuristaList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Turista> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TuristasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Turista>(listado);
            var source = new BindingSource(bindingList, null);
            //this.TuristasGrd.DataSource = listado;
            this.TuristasGrd.DataSource =  source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmTuristaList_Load(object sender, EventArgs e)
        {
            
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for( int i=0;i<this.TuristasGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.TuristasGrd.Rows[i];
                item.Cells[3].Value = (item.DataBoundItem as Turista).PaisObj.Nombre;
            }
        }

        private void TuristasGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.TuristasGrd.SelectedRows.Count>0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTuristaAM frm = new FrmTuristaAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTurista (this, (this.TuristasGrd.SelectedRows[0].DataBoundItem as Turista));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TuristasGrd.SelectedRows[0].Index;
                this.TuristasGrd.DataSource = Turista.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                TuristasGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Turista actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TuristasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";
            
            if(TuristasGrd.Tag!=null)
                sortOrderGrid = TuristasGrd.Tag.ToString();
            DataGridViewColumn newColumn = TuristasGrd.Columns[e.ColumnIndex];
            if (newColumn.Name == "Domicilio") //columna no ordenable
                return; 
            ListSortDirection direction = ListSortDirection.Ascending;
            if (sortOrderGrid == "")
                direction = ListSortDirection.Ascending;
            else
            {
                if (sortOrderGrid.IndexOf("-") != -1)
                    direction = ListSortDirection.Ascending;
                else
                    direction = ListSortDirection.Descending;
            }
            var turistas = (TuristasGrd.DataSource as BindingSource).List.Cast<Turista>().ToList();
            sortOrderGrid = direction == ListSortDirection.Descending ? "-" : "" + newColumn.Name;
            if (newColumn.Name == "Nombre")
                turistas.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre)));
            if (newColumn.Name == "Dni")
                turistas.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.NroDocumento.CompareTo(t2.NroDocumento) : t2.NroDocumento.CompareTo(t1.NroDocumento)));
            if (newColumn.Name == "Pais")
                turistas.Sort((t1, t2) => (direction == ListSortDirection.Ascending ? t1.PaisObj.Nombre.CompareTo(t2.PaisObj.Nombre) : t2.PaisObj.Nombre.CompareTo(t1.PaisObj.Nombre)));
            TuristasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;
            TuristasGrd.DataSource = null;
            var bindingList = new BindingList<Turista>(turistas);
            var source = new BindingSource(bindingList, null);
            TuristasGrd.DataSource = source;
            TuristasGrd.Tag = sortOrderGrid;
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
