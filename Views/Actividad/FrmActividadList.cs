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
            if (this.ActividadGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmActividadAM frm = new FrmActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarActividad(this, (this.ActividadGrd.SelectedRows[0].DataBoundItem as Actividad));
            }
        }
        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                try
                {
                    // Guarda el índice seleccionado actualmente
                    int selAnt = ActividadGrd.SelectedRows[0].Index;

                    // Actualiza la fuente de datos
                    this.ActividadGrd.DataSource = Actividad.FindAllStatic(_criterio, delegate(Actividad e1, Actividad e2) { return e1.Codigo.CompareTo(e2.Codigo); });

                    // Verifica que el índice es válido antes de seleccionar la fila
                    if (selAnt >= 0 && selAnt < ActividadGrd.Rows.Count)
                    {
                        ActividadGrd.Rows[selAnt].Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje si ocurre una excepción
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Muestra el mensaje de éxito
                    MessageBox.Show("Paquete actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Cursor = Cursors.Default;
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

        private void ActividadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.ActividadGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadGrd.Rows[i];
                Actividad ag = item.DataBoundItem as Actividad;
                item.Cells[1].Value = ag.TransporteObj.Descripcion;
                item.Cells[3].Value = ag.TipoActividadObj.Nombre;
            }
        }
    }
}
