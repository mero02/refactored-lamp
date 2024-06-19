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
    public partial class FrmTransporteList : FormBase
    {
        private string _criterio = null;
        private List<Transporte> _listado;

        public FrmTransporteList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        public void ShowListado(List<Transporte> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TransportesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Transporte>(listado);
            var source = new BindingSource(bindingList, null);
            this.TransportesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmTransporteList_Load(object sender, EventArgs e) { 
        
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransportesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TransportesGrd.Tag != null)
                sortOrderGrid = TransportesGrd.Tag.ToString();

            DataGridViewColumn newColumn = TransportesGrd.Columns[e.ColumnIndex];

            // Verificar si la columna es no ordenable
            if (newColumn.Name == "Dominio")
                return;

            // Determinar la dirección de orden
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = TransportesGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var transportes = bindingSource.List.Cast<Transporte>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodCol":
                    transportes.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "DomCol":
                    transportes.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Dominio.CompareTo(t2.Dominio) : t2.Dominio.CompareTo(t1.Dominio));
                    break;
                case "ImpCol":
                    transportes.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Importe.CompareTo(t2.Importe) : t2.Importe.CompareTo(t1.Importe));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            TransportesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Transporte>(transportes);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void TransportesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TransportesGrd.SelectedRows.Count > 0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTransporteAm frm = new FrmTransporteAm();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTransporte(this, (this.TransportesGrd.SelectedRows[0].DataBoundItem as Transporte));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TransportesGrd.SelectedRows[0].Index;
                this.TransportesGrd.DataSource = Transporte.FindAllStatic(_criterio, (e1, e2) => e1.Codigo.CompareTo(e2.Codigo));
                TransportesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Trasnporte actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TransportesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.TransportesGrd.DataBindingComplete -= TransportesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.TransportesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.TransportesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as Transporte).Dominio;
                }
            }
            finally
            {
                this.TransportesGrd.DataBindingComplete += TransportesGrd_DataBindingComplete;
            }
        }


        private void TransportesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
