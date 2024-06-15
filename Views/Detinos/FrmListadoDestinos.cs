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
    public partial class FrmListadoDestinos : FormBase
    {
        public FrmListadoDestinos()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoDestinos_Load(object sender, EventArgs e)
        {
            this.DestinosGrd.AutoGenerateColumns = false;
            var Paquetes = Paquete.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var Destinos = new List<Destino>();
            foreach (Paquete paquete in Paquetes)
            {
                var destino = Destino.FindByKeyStatic(paquete.CodDestino);

                if (destino != null) {
                    Destinos.Add(destino);
                }
            }
            Destinos = Destinos.OrderBy(d => d.Codigo).ToList();
            var DestinosBindingList = new BindingList<Destino>(Destinos);
            var DestinosBindingSource = new BindingSource(DestinosBindingList, null);
            this.DestinosGrd.DataSource = DestinosBindingSource;

            this.ExportarBtn.Enabled = true;

            this.DestinosGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(DestinosGrd_ColumnHeaderMouseClick);

        }

        private void DestinosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (DestinosGrd.Tag != null)
                sortOrderGrid = DestinosGrd.Tag.ToString();

            DataGridViewColumn newColumn = DestinosGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden
            ListSortDirection direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = DestinosGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var destinos = bindingSource.List.Cast<Destino>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "NombreCol":
                    destinos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;
                case "CodigoCol":
                    destinos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "DescripcionCol":
                    destinos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Descripcion.CompareTo(t2.Descripcion) : t2.Descripcion.CompareTo(t1.Descripcion));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            DestinosGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Destino>(destinos);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void DestinosGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            this.DestinosGrd.DataBindingComplete -= DestinosGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.DestinosGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.DestinosGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as Destino).Nombre;
                }
            }
            finally
            {
                this.DestinosGrd.DataBindingComplete += DestinosGrd_DataBindingComplete;
            }
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;


            if (this.NombreChk.Checked && this.NombreTxt != null)
            {
                criterio = String.Format("nombre = '{0}'", NombreTxt.Text);
            }

            this.DestinosGrd.DataSource = Destino.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
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
                    ExportToCsv(DestinosGrd, sfd.FileName);
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

        private void DestinosGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
