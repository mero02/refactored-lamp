using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;
using Newtonsoft;

namespace TurApp.Views
{
    public partial class FrmListadoTipoActividad : FormBase
    {
        public FrmListadoTipoActividad()
        {
            InitializeComponent();
        }

        private void FrmListadoTipoActividad_Load(object sender, EventArgs e)
        {
            this.TipoActividadGrd.AutoGenerateColumns = false;
            var TipoActividades = TipoActividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var TipoActividadesBindingList = new BindingList<TipoActividad>(TipoActividades);
            var TipoActividadesBindingSource = new BindingSource(TipoActividadesBindingList, null);
            this.TipoActividadGrd.DataSource = TipoActividadesBindingSource;

            this.ExportarBtn.Enabled = true;

            this.TipoActividadGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(TipoActividadesGrd_ColumnHeaderMouseClick);
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.NombreChk.Checked && this.NombreChk != null)
            {
                criterio = String.Format("Nombre = '{0}'", NombreTxt.Text);
            }

            this.TipoActividadGrd.DataSource = TipoActividad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
        }


        private void TipoActividadesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TipoActividadGrd.Tag != null)
                sortOrderGrid = TipoActividadGrd.Tag.ToString();

            DataGridViewColumn newColumn = TipoActividadGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden actual
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los tipo paquetes desde el DataSource
            var bindingSource = TipoActividadGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var TipoActividades = bindingSource.List.Cast<TipoActividad>().ToList();

            // Ordenar los tipo paquetes según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    TipoActividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "NombreCol":
                    TipoActividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;

                case "DescripcionCol":
                    TipoActividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Descripcion.CompareTo(t2.Descripcion) : t2.Descripcion.CompareTo(t1.Descripcion));
                    break;

                case "DuracionCol":
                    TipoActividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Duracion.CompareTo(t2.Duracion) : t2.Duracion.CompareTo(t1.Duracion));
                    break;

                case "NivelCol":
                    TipoActividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel));
                    break;
            }

            // Cambiar la dirección de orden para la próxima vez
            direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Actualizar la etiqueta de dirección de orden
            TipoActividadGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<TipoActividad>(TipoActividades);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(TipoActividadGrd, sfd.FileName);
                }
            }
        }
        private void ExportToCsv(DataGridView dgv, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Escribir encabezados
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();

                    // Escribir datos
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            sw.Write(dgv.Rows[i].Cells[j].Value);
                            if (j < dgv.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Datos exportados con éxito.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TipoActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTipoActividadAM frmpac = new FrmTipoActividadAM();
            TipoActividad pac = (this.TipoActividadGrd.SelectedRows[0].DataBoundItem as TipoActividad);
            frmpac.ShowModificarTipoActividad(pac);
        }

        
    }
}
