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
            var destinos = Destino.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            var destinosConcurridos = filtrarPaquetesPorDestino(destinos);
            var DestinosBindingList = new BindingList<DestinosConcurridos>(destinosConcurridos);
            var DestinosBindingSource = new BindingSource(DestinosBindingList, null);
            this.DestinosGrd.DataSource = DestinosBindingSource;

            this.ExportarBtn.Enabled = true;

            this.DestinosGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(DestinosGrd_ColumnHeaderMouseClick);
        }

        private class DestinosConcurridos
        {
            public int Codigo;
            public string Nombre;
            public string Descripcion;
            public int Cantidad;
        }

        private List<DestinosConcurridos> filtrarPaquetesPorDestino(List<Destino> Destinos)
        {
            var DestinosConcurridos = new List<DestinosConcurridos>();
            var Paquetes = Paquete.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));

            foreach (Destino destino in Destinos)
            {
                var codDestino = destino.Codigo;
                var count = 0;
                foreach (Paquete paquete in Paquetes)
                {
                    if (codDestino == paquete.CodDestino)
                    {
                        count++;
                    }
                }
                DestinosConcurridos.Add(new DestinosConcurridos { Codigo = destino.Codigo, Nombre = destino.Nombre, Descripcion = destino.Descripcion, Cantidad = count });
            }

            return DestinosConcurridos.OrderBy(p => p.Codigo).ToList();
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

            var destinos = bindingSource.List.Cast<DestinosConcurridos>().ToList();

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
                case "CantCol":
                    destinos.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t2.Cantidad.CompareTo(t1.Cantidad) : t1.Cantidad.CompareTo(t2.Cantidad));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            DestinosGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<DestinosConcurridos>(destinos);

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
                    item.Cells[0].Value = (item.DataBoundItem as DestinosConcurridos).Codigo;
                    item.Cells[1].Value = (item.DataBoundItem as DestinosConcurridos).Nombre;
                    item.Cells[2].Value = (item.DataBoundItem as DestinosConcurridos).Descripcion;
                    item.Cells[3].Value = (item.DataBoundItem as DestinosConcurridos).Cantidad;
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
            var destinos = Destino.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            this.DestinosGrd.DataSource = filtrarPaquetesPorDestino(destinos);
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
