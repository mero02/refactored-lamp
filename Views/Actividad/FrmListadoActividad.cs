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

namespace TurApp.Views
{
    public partial class FrmListadoActividad : FormBase
    {
        public FrmListadoActividad()
        {
            InitializeComponent();
        }

        private void FrmListadoActividad_Load(object sender, EventArgs e)
        {
            this.ActividadGrd.AutoGenerateColumns = false;
            var Actividades = Actividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var ActividadesBindingList = new BindingList<Actividad>(Actividades);
            var ActividadesBindingSource = new BindingSource(ActividadesBindingList, null);
            this.ActividadGrd.DataSource = ActividadesBindingSource;

            this.ExportarBtn.Enabled = true;

            this.ActividadGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(ActividadGrd_ColumnHeaderMouseClick);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.TipoActividadChk.Checked && this.TipoActividadChk != null)
            {
                criterio = String.Format("Tipo Actividad = '{0}'", TipoActividadTxt.Text);
            }

            this.ActividadGrd.DataSource = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));

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
                    ExportToCsv(ActividadGrd, sfd.FileName);
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
        private void ActividadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        string sortOrderGrid = "";

            if (ActividadGrd.Tag != null)
                sortOrderGrid = ActividadGrd.Tag.ToString();

            DataGridViewColumn newColumn = ActividadGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden actual
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los tipo paquetes desde el DataSource
            var bindingSource = ActividadGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var Actividades = bindingSource.List.Cast<Actividad>().ToList();

            // Ordenar los tipo paquetes según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    Actividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "TipoActividadCol":
                    Actividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodTipoActividad.CompareTo(t2.CodTipoActividad) : t2.CodTipoActividad.CompareTo(t1.CodTipoActividad));
                    break;

                case "TransporteCol":
                    Actividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodTransporte.CompareTo(t2.CodTransporte) : t2.CodTransporte.CompareTo(t1.CodTransporte));
                    break;

                case "ImporteCol":
                    Actividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Importe.CompareTo(t2.Importe) : t2.Importe.CompareTo(t1.Importe));
                    break;


                case "NivelCol":
                    Actividades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel));
                    break;

                
            }

            // Cambiar la dirección de orden para la próxima vez
            direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Actualizar la etiqueta de dirección de orden
            ActividadGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Actividad>(Actividades);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void TipoActividadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoActividadTxt.Enabled = this.TipoActividadChk.Checked;
        }
        private void ActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmActividadAM frmpac = new FrmActividadAM();
            Actividad actividad = (this.ActividadGrd.SelectedRows[0].DataBoundItem as Actividad);
            frmpac.ShowModificarActividad(actividad);
        }
    }
}
