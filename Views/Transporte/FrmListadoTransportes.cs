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
    public partial class FrmListadoTransportes : FormBase
    {
        public FrmListadoTransportes()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoTransportes_Load(object sender, EventArgs e)
        {
            this.TransportesGrd.AutoGenerateColumns = false;
            var transportes = Transporte.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var localidadesBindingList = new BindingList<Transporte>(transportes);
            var turistasBindingSource = new BindingSource(localidadesBindingList, null);
            this.TransportesGrd.DataSource = turistasBindingSource;

            this.ExportarBtn.Enabled = true;

            this.TransportesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(TransportesGrd_ColumnHeaderMouseClick);

        }

        private void DominioChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DominioTxt.Enabled = this.DominioChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;


            if (this.DominioChk.Checked && this.DominioTxt != null)
            {
                criterio = String.Format("dominio = '{0}'", DominioTxt.Text);
            }

            this.TransportesGrd.DataSource = Transporte.FindAllStatic(criterio, (p1, p2) => (p1.Dominio).CompareTo(p2.Dominio));
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
                    ExportToCsv(TransportesGrd, sfd.FileName);
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

        private void TransportesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransportesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TransportesGrd.Tag != null)
                sortOrderGrid = TransportesGrd.Tag.ToString();

            DataGridViewColumn newColumn = TransportesGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden
            ListSortDirection direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

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

        private void TransportesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTransporteAm frmpac = new FrmTransporteAm();
            Transporte pac = (this.TransportesGrd.SelectedRows[0].DataBoundItem as Transporte);
            frmpac.ShowModificarTransporte(pac);
        }

    }
}
