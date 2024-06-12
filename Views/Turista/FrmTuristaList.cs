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

        private void TuristasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

            if (TuristasGrd.Tag != null)
                sortOrderGrid = TuristasGrd.Tag.ToString();

            DataGridViewColumn newColumn = TuristasGrd.Columns[e.ColumnIndex];

            // Verificar si la columna es no ordenable
            if (newColumn.Name == "Domicilio")
                return;

            // Determinar la dirección de orden
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = TuristasGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var turistas = bindingSource.List.Cast<Turista>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "Nombre":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;
                case "Dni":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.NroDocumento.CompareTo(t2.NroDocumento) : t2.NroDocumento.CompareTo(t1.NroDocumento));
                    break;
                case "Pais":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.PaisObj.Nombre.CompareTo(t2.PaisObj.Nombre) : t2.PaisObj.Nombre.CompareTo(t1.PaisObj.Nombre));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            TuristasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Turista>(turistas);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
