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
    
    public partial class FrmActividadList : FormBase
    {
        private string _criterio = null;
        private List<Actividad> _listado;
        public FrmActividadList()
        {
            InitializeComponent();
            
        }
        public void ShowListado(List<Actividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ActividadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Actividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.ActividadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
        private void FrmActividadList_Load(object sender, EventArgs e)
        {
            
        }
        private void ActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmActividadAM frmpac = new FrmActividadAM();
            Actividad pac = (this.ActividadGrd.SelectedRows[0].DataBoundItem as Actividad);
            frmpac.ShowModificarActividad(pac);
        }
       

        private void ActividadGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ActividadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (ActividadGrd.Tag != null)
                sortOrderGrid = ActividadGrd.Tag.ToString();

            DataGridViewColumn newColumn = ActividadGrd.Columns[e.ColumnIndex];

            // Verificar si la columna es no ordenable
            if (newColumn.Name == "Codigo")
                return;

            // Determinar la dirección de orden
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = ActividadGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var codigos = bindingSource.List.Cast<Actividad>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    codigos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "codTransporteCol":
                    codigos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodTransporte.CompareTo(t2.CodTransporte) : t2.CodTransporte.CompareTo(t1.CodTransporte));
                    break;
                case "NivelCol":
                    codigos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel));
                    break;
                case "ImporteCol":
                    codigos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Importe.CompareTo(t2.Importe) : t2.Importe.CompareTo(t1.Importe));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            ActividadGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Actividad>(codigos);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void ActividadGrd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
