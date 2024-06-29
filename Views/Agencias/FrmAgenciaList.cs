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
    public partial class FrmAgenciaList : FormBase
    {
        private string _criterio = null;
        private List<Agencia> _listado;

        public FrmAgenciaList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowListado(List<Agencia> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.AgenciasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Agencia>(listado);
            var source = new BindingSource(bindingList, null);
            this.AgenciasGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmAgenciaList_Load(object sender, EventArgs e)
        {

        }

        private void AgenciasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.AgenciasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.AgenciasGrd.Rows[i];
                Agencia ag = item.DataBoundItem as Agencia;
                item.Cells[1].Value = ag.Calle + " " + ag.Nro + " " + ag.Piso + " " +ag.Dpto ;
                item.Cells[2].Value = ag.LocalidadObj.Nombre;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgenciasGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.AgenciasGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmAgenciaAM frm = new FrmAgenciaAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarAgencia(this, (this.AgenciasGrd.SelectedRows[0].DataBoundItem as Agencia));
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
                    int selAnt = AgenciasGrd.SelectedRows[0].Index;

                    // Actualiza la fuente de datos
                    this.AgenciasGrd.DataSource = Agencia.FindAllStatic(_criterio, delegate(Agencia e1, Agencia e2) { return e1.Codigo.CompareTo(e2.Codigo); });

                    // Verifica que el índice es válido antes de seleccionar la fila
                    if (selAnt >= 0 && selAnt < AgenciasGrd.Rows.Count)
                    {
                        AgenciasGrd.Rows[selAnt].Selected = true;
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
                    MessageBox.Show("Agencia actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void AgenciasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (AgenciasGrd.Tag != null)
                sortOrderGrid = AgenciasGrd.Tag.ToString();

            DataGridViewColumn newColumn = AgenciasGrd.Columns[e.ColumnIndex];

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
            var bindingSource = AgenciasGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var agencias = bindingSource.List.Cast<Agencia>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "Nombre":
                    agencias.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;
                case "Localidad":
                    agencias.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodPostal.CompareTo(t2.CodPostal) : t2.CodPostal.CompareTo(t1.CodPostal));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            AgenciasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Agencia>(agencias);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
