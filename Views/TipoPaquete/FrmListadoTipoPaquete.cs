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
    public partial class FrmListadoTipoPaquete : FormBase
    {
        public FrmListadoTipoPaquete()
        {
            InitializeComponent();
        }

        private void FrmListadoTipoPaquete_Load(object sender, EventArgs e)
        {
            this.TipoPaquetesGrd.AutoGenerateColumns = false;
            // this.TipoPaquetesGrd.DataSource = TipoPaquete.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            var TipoPaquetes = TipoPaquete .FindAllStatic(null, (p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            var TipoPaquetesBindingList = new BindingList<TipoPaquete>(TipoPaquetes);
            var TipoPaquetesBindingSource = new BindingSource(TipoPaquetesBindingList, null);
            this.TipoPaquetesGrd.DataSource = TipoPaquetesBindingSource;

            this.ExportarBtn.Enabled = true;

            this.TipoPaquetesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(TipoPaquetesGrd_ColumnHeaderMouseClick);
        }

        private void TipoPaqueteChk_CheckedChanged(object sender, EventArgs e)
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

            this.TipoPaquetesGrd.DataSource = TipoPaquete.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));

        }
        private void TipoPaquetesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TipoPaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.TipoPaquetesGrd.DataBindingComplete -= TipoPaquetesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.TipoPaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.TipoPaquetesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as TipoPaquete).Codigo;
                }
            }
            finally
            {
                this.TipoPaquetesGrd.DataBindingComplete += TipoPaquetesGrd_DataBindingComplete;
            }

        }

        private void TipoPaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTipoPaqueteAM frmpac = new FrmTipoPaqueteAM();
            TipoPaquete pac = (this.TipoPaquetesGrd.SelectedRows[0].DataBoundItem as TipoPaquete);
            frmpac.ShowModificarTipoPaquete(pac);
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
                    ExportToCsv(TipoPaquetesGrd, sfd.FileName);
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

        private void TipoPaquetesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TipoPaquetesGrd.Tag != null)
                sortOrderGrid = TipoPaquetesGrd.Tag.ToString();

            DataGridViewColumn newColumn = TipoPaquetesGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden actual
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los tipo paquetes desde el DataSource
            var bindingSource = TipoPaquetesGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var TipoPaquete = bindingSource.List.Cast<TipoPaquete>().ToList();

            // Ordenar los tipo paquetes según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    TipoPaquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "NombreCol":
                    TipoPaquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;

                case "DescripcionCol":
                    TipoPaquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Descripcion.CompareTo(t2.Descripcion) : t2.Descripcion.CompareTo(t1.Descripcion));
                    break;

                case "DuracionCol":
                    TipoPaquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Duracion.CompareTo(t2.Duracion) : t2.Duracion.CompareTo(t1.Duracion));
                    break;

                case "NivelCol":
                    TipoPaquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel));
                    break;
            }

            // Cambiar la dirección de orden para la próxima vez
            direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Actualizar la etiqueta de dirección de orden
            TipoPaquetesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<TipoPaquete>(TipoPaquete);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }   
    }
}
