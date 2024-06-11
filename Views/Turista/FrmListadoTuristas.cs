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
    public partial class FrmListadoTuristas : FormBase
    {
        public FrmListadoTuristas()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.NombreChk.Checked;
        }

        private void FrmListadoTuristas_Load(object sender, EventArgs e)
        {
            LoadComboBox(Pais.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.PaisCbo, addSeleccion: true);

            this.TuristasGrd.AutoGenerateColumns = false;
            //this.TuristasGrd.DataSource = Turista.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            var turistas = Turista.FindAllStatic(null, (p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            var localidadesBindingList = new BindingList<Turista>(turistas);
            var turistasBindingSource = new BindingSource(localidadesBindingList, null);
            this.TuristasGrd.DataSource = turistasBindingSource;

            this.ExportarBtn.Enabled = true;

            this.TuristasGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(TuristasGrd_ColumnHeaderMouseClick);

        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PaisCbo.Enabled = PaisChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.PaisChk.Checked && this.PaisCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_pais = " + PaisCbo.SelectedValue;
                }
                else
                    criterio = "cod_pais = " + PaisCbo.SelectedValue;
            }
            this.TuristasGrd.DataSource = Turista.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
        }

        private void TuristasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TuristasGrd.Rows)
            {
                rw.Cells[2].Value = (rw.DataBoundItem as Turista).PaisObj.Nombre;
            }

            foreach (DataGridViewRow rw in this.TuristasGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as Turista).Nombre;
            }
        }

        private void TuristasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TuristasGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTuristaAM frmpac = new FrmTuristaAM();
            Turista pac = (this.TuristasGrd.SelectedRows[0].DataBoundItem as Turista);
            frmpac.ShowModificarTurista(pac);
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
                    ExportToCsv(TuristasGrd, sfd.FileName);
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

        private void TuristasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (TuristasGrd.Tag != null)
                sortOrderGrid = TuristasGrd.Tag.ToString();

            DataGridViewColumn newColumn = TuristasGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden
            ListSortDirection direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = TuristasGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var turistas = bindingSource.List.Cast<Turista>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "NombreCol":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                    break;
                case "DniCol":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.NroDocumento.CompareTo(t2.NroDocumento) : t2.NroDocumento.CompareTo(t1.NroDocumento));
                    break;
                case "PaisCol":
                    turistas.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.PaisObj.Nombre.CompareTo(t2.PaisObj.Nombre) : t2.PaisObj.Nombre.CompareTo(t1.PaisObj.Nombre));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            TuristasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Turista>(turistas);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }
}
