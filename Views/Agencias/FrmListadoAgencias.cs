using System;
using System.IO; //agregada para exportar
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
    public partial class FrmListadoAgencias : FormBase
    {
        public FrmListadoAgencias()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoAgencias_Load(object sender, EventArgs e)
        {
            LoadComboBox(Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.LocCbo, addSeleccion: true);

            this.AgenciasGrd.AutoGenerateColumns = false;
            var agencias = Agencia.FindAllStatic(null, (p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            var agenciasBindingList = new BindingList<Agencia>(agencias);
            var agenciasBindingSource = new BindingSource(agenciasBindingList, null);
            this.AgenciasGrd.DataSource = agenciasBindingSource;

            this.ExportarBtn.Enabled = true;
            this.AgenciasGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(AgenciasGrd_ColumnHeaderMouseClick);
        }

        private void AgenciasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            this.AgenciasGrd.DataBindingComplete -= AgenciasGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.AgenciasGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.AgenciasGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as Agencia).Codigo;
                    item.Cells[6].Value = (item.DataBoundItem as Agencia).LocalidadObj.Nombre;
                }
            }
            finally
            {
                this.AgenciasGrd.DataBindingComplete += AgenciasGrd_DataBindingComplete;
            }
        }

        private void AgenciasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    ExportToCsv(AgenciasGrd, sfd.FileName);
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

        private void AgenciasGrd_DoubleClick(object sender, EventArgs e)
        {
            Agencia Agencia = (Agencia)this.AgenciasGrd.CurrentRow.DataBoundItem;
            FrmAgenciaAM frm = new FrmAgenciaAM();
            frm.ShowModificarAgencia(this, Agencia);
        }

        private void AgenciasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (AgenciasGrd.Tag != null)
                sortOrderGrid = AgenciasGrd.Tag.ToString();

            DataGridViewColumn newColumn = AgenciasGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden
            ListSortDirection direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = AgenciasGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource is not a BindingSource.");
                return;
            }

            var agencias = bindingSource.List.Cast<Agencia>().ToList();

            // Ordenar las agencias según la columna seleccionada
            switch (newColumn.Name)
            {
                case "NombreCol":
                    agencias.Sort((a1, a2) => direction == ListSortDirection.Ascending ? a1.Nombre.CompareTo(a2.Nombre) : a2.Nombre.CompareTo(a1.Nombre));
                    break;
                case "NroAgenciaCol":
                    agencias.Sort((a1, a2) => direction == ListSortDirection.Ascending ? a1.Codigo.CompareTo(a2.Codigo) : a2.Codigo.CompareTo(a1.Codigo));
                    break;
                case "LocCol":
                    agencias.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.LocalidadObj.Nombre.CompareTo(t2.LocalidadObj.Nombre) : t2.LocalidadObj.Nombre.CompareTo(t1.LocalidadObj.Nombre));
                    break;
                default:
                    MessageBox.Show("Columna no manejada.");
                    return;

            }

            // Actualizar la etiqueta de dirección de orden
            AgenciasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<Agencia>(agencias);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;


            if (this.NombreChk.Checked && this.NombreTxt != null)
            {
                criterio = String.Format("nombre = '{0}'", NombreTxt.Text);
            }

            if (this.LocChk.Checked && this.LocCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and codigo_postal = " + (LocCbo.SelectedValue as Localidad).Codigo;
                }
                else
                    criterio = "codigo_postal = " + (LocCbo.SelectedValue as Localidad).Codigo;
            }

            this.AgenciasGrd.DataSource = Agencia.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));

        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocCbo.Enabled = LocChk.Checked;
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }
    }
}
