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
    public partial class FrmListadoLocalidades : FormBase
    {
        public FrmListadoLocalidades()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoLocalidades_Load(object sender, EventArgs e)
        {
            LoadComboBox(Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.LocalidadCbo, addSeleccion: true);
            this.LocalidadesGrd.AutoGenerateColumns = false;

            var localidades = Localidad.FindAllStatic(null, (p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            var localidadesBindingList = new BindingList<Localidad>(localidades);
            var localidadesBindingSource = new BindingSource(localidadesBindingList, null);
            this.LocalidadesGrd.DataSource = localidadesBindingSource;

            this.ExportarBtn.Enabled = true;

            this.LocalidadesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(LocalidadesGrd_ColumnHeaderMouseClick);

        }

        private void LocalidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as Localidad).Codigo;
            }

            foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as Localidad).Nombre;
            }
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
                    ExportToCsv(LocalidadesGrd, sfd.FileName);
                }
            }
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = NombreChk.Checked;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {

            string criterio = null;

            if (this.NombreChk.Checked && this.NombreTxt != null)
            {
                criterio = String.Format("nombre = '{0}'", NombreTxt.Text);
            }

            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_postal = " + (LocalidadCbo.SelectedValue as Localidad).Codigo;
                }
                else
                    criterio = "cod_postal = " + (LocalidadCbo.SelectedValue as Localidad).Codigo;
            }
            this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));


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

        private void LocalidadesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmLocalidadAM frmpac = new FrmLocalidadAM();
            Localidad pac = (this.LocalidadesGrd.SelectedRows[0].DataBoundItem as Localidad);
            frmpac.ShowModificarLocalidad(pac);
        }


    private void LocalidadesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        string sortOrderGrid = "";

        if (LocalidadesGrd.Tag != null)
            sortOrderGrid = LocalidadesGrd.Tag.ToString();

        DataGridViewColumn newColumn = LocalidadesGrd.Columns[e.ColumnIndex];

        // Determinar la dirección de orden actual
        ListSortDirection direction;
        if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
            direction = ListSortDirection.Ascending;
        else
            direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

        // Obtener las localidades desde el DataSource
        var bindingSource = LocalidadesGrd.DataSource as BindingSource;
        if (bindingSource == null)
        {
            MessageBox.Show("DataSource no es un BindingSource.");
            return;
        }

        var localidades = bindingSource.List.Cast<Localidad>().ToList();

        // Ordenar las localidades según la columna seleccionada
        switch (newColumn.Name)
        {
            case "CodPosCol":
                localidades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                break;
            case "NombreCol":
                localidades.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Nombre.CompareTo(t2.Nombre) : t2.Nombre.CompareTo(t1.Nombre));
                break;
        }

        // Cambiar la dirección de orden para la próxima vez
        direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

        // Actualizar la etiqueta de dirección de orden
        LocalidadesGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

        // Asignar los datos ordenados al DataSource
        bindingSource.DataSource = new BindingList<Localidad>(localidades);

        // Mostrar la dirección de orden en el encabezado de la columna
        newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
    }
  }
}
