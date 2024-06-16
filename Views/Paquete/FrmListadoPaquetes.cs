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
    public partial class FrmListadoPaquetes : FormBase
    {
        public FrmListadoPaquetes()
        {
            InitializeComponent();
        }

        private void FrmListadoPaquetes_Load(object sender, EventArgs e)
        {
            this.PaquetesGrd.AutoGenerateColumns = false;
            // this.PaquetesGrd.DataSource = TipoPaquete.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            var Paquetes = Paquete.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var PaquetesBindingList = new BindingList<Paquete>(Paquetes);
            var PaquetesBindingSource = new BindingSource(PaquetesBindingList, null);
            this.PaquetesGrd.DataSource = PaquetesBindingSource;

            this.ExportarBtn.Enabled = true;

            this.PaquetesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(PaquetesGrd_ColumnHeaderMouseClick);

        }

        private void TipoPaqueteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoPaqueteTxt.Enabled = this.TipoPaqueteChk.Checked;

        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.TipoPaqueteChk.Checked && this.TipoPaqueteChk != null)
            {
                criterio = String.Format("cod_tipo_paquete = '{0}'", TipoPaqueteTxt.Text);
            }

            this.PaquetesGrd.DataSource = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.CodTipoPaquete).CompareTo(p2.CodTipoPaquete));

        }

        private void PaquetesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PaquetesGrd.DataBindingComplete -= PaquetesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as Paquete).Codigo;
                }
            }
            finally
            {
                this.PaquetesGrd.DataBindingComplete += PaquetesGrd_DataBindingComplete;
            }

        }

        private void PaquetesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmPaqueteAM frmpac = new FrmPaqueteAM();
            Paquete pac = (this.PaquetesGrd.SelectedRows[0].DataBoundItem as Paquete);
            frmpac.ShowModificarPaquete(pac);
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
                    ExportToCsv(PaquetesGrd, sfd.FileName);
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

        private void PaquetesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (PaquetesGrd.Tag != null)
                sortOrderGrid = PaquetesGrd.Tag.ToString();

            DataGridViewColumn newColumn = PaquetesGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden actual
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los tipo paquetes desde el DataSource
            var bindingSource = PaquetesGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var Paquete = bindingSource.List.Cast<Paquete>().ToList();

            // Ordenar los tipo paquetes según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "TipoPaqueteCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodTipoPaquete.CompareTo(t2.CodTipoPaquete) : t2.CodTipoPaquete.CompareTo(t1.CodTipoPaquete));
                    break;

                case "AgenciaCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodAgencia.CompareTo(t2.CodAgencia) : t2.CodAgencia.CompareTo(t1.CodAgencia));
                    break;

                case "FechaCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Fecha.CompareTo(t2.Fecha) : t2.Fecha.CompareTo(t1.Fecha));
                    break;

                case "DniTuristaCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.DniTurista.CompareTo(t2.DniTurista) : t2.DniTurista.CompareTo(t1.DniTurista));
                    break;

                case "NivelCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nivel.CompareTo(t2.Nivel) : t2.Nivel.CompareTo(t1.Nivel));
                    break;

                case "DestinoCol":
                    Paquete.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.CodDestino.CompareTo(t2.CodDestino) : t2.CodDestino.CompareTo(t1.CodDestino));
                    break;
            }

            // Cambiar la dirección de orden para la próxima vez
            direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Actualizar la etiqueta de dirección de orden
            PaquetesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Paquete>(Paquete);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }  
    }
}
