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
    public partial class FrmFormaPagoList : FormBase
    {
        private string _criterio = null;
        private List<FormaPago> _listado;

        public FrmFormaPagoList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowListado(List<FormaPago> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.FormaPagoGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<FormaPago>(listado);
            var source = new BindingSource(bindingList, null);
            this.FormaPagoGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmFormaPagoList_Load(object sender, EventArgs e)
        {

        }


        private void FormaPagoGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmFormaPagoAM frmpac = new FrmFormaPagoAM();
            FormaPago pac = (this.FormaPagoGrd.SelectedRows[0].DataBoundItem as FormaPago);
            frmpac.ShowModificarFormaPago(pac);
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaPagoGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.FormaPagoGrd.DataBindingComplete -= FormaPagoGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.FormaPagoGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.FormaPagoGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as FormaPago).Forma;
                }
            }
            finally
            {
                this.FormaPagoGrd.DataBindingComplete += FormaPagoGrd_DataBindingComplete;
            }
        }

        private void FormaPagoGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (FormaPagoGrd.Tag != null)
                sortOrderGrid = FormaPagoGrd.Tag.ToString();

            DataGridViewColumn newColumn = FormaPagoGrd.Columns[e.ColumnIndex];

            // Verificar si la columna es no ordenable
            if (newColumn.Name == "Forma")
                return;

            // Determinar la dirección de orden
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = FormaPagoGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var formas = bindingSource.List.Cast<FormaPago>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "Forma":
                    formas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Forma.CompareTo(t2.Forma) : t2.Forma.CompareTo(t1.Forma));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            FormaPagoGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<FormaPago>(formas);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
