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
    public partial class FrmListadoFormaPago : FormBase
    {

        public FrmListadoFormaPago()
        {
            InitializeComponent();
        }
        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoFormasPago_Load(object sender, EventArgs e)
        {
            this.FormaPagoGrd.AutoGenerateColumns = false;
           // this.FormaPagoGrd.DataSource = FormaPago.FindAllStatic(null, (p1, p2) => (p1.Forma).CompareTo(p2.Forma));
            var Formas = FormaPago.FindAllStatic(null, (p1, p2) => p1.Forma.CompareTo(p2.Forma));
            var FormasBindingList = new BindingList<FormaPago>(Formas);
            var FormasBindingSource = new BindingSource(FormasBindingList, null);
            this.FormaPagoGrd.DataSource = FormasBindingSource;

            this.ExportarBtn.Enabled = true;

            this.FormaPagoGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(FormaPagoGrd_ColumnHeaderMouseClick);

        }

        private void FormaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FormaPagoTxt.Enabled = this.FormaPagoChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.FormaPagoChk.Checked && this.FormaPagoChk != null)
            {
                criterio = String.Format("forma = '{0}'", FormaPagoTxt.Text);
            }

            this.FormaPagoGrd.DataSource = FormaPago.FindAllStatic(criterio, (p1, p2) => (p1.Forma).CompareTo(p2.Forma));
        }

        private void FormaPagoGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormaPagoGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.FormaPagoGrd.DataBindingComplete -= FormaPagoGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.FormaPagoGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.FormaPagoGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as FormaPago).Forma;
                }
            }
            finally
            {
                this.FormaPagoGrd.DataBindingComplete += FormaPagoGrd_DataBindingComplete;
            }
        }

        private void FormaPagoGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmFormaPagoAM frmpac = new FrmFormaPagoAM();
            FormaPago pac = (this.FormaPagoGrd.SelectedRows[0].DataBoundItem as FormaPago);
            frmpac.ShowModificarFormaPago(pac);
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
                    ExportToCsv(FormaPagoGrd, sfd.FileName);
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

        private void FormaPagoGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (FormaPagoGrd.Tag != null)
                sortOrderGrid = FormaPagoGrd.Tag.ToString();

            DataGridViewColumn newColumn = FormaPagoGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden actual
            ListSortDirection direction;
            if (sortOrderGrid.StartsWith("-") && sortOrderGrid.Substring(1) == newColumn.Name)
                direction = ListSortDirection.Ascending;
            else
                direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener las localidades desde el DataSource
            var bindingSource = FormaPagoGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var FormasPago = bindingSource.List.Cast<FormaPago>().ToList();

            // Ordenar las localidades según la columna seleccionada
            switch (newColumn.Name)
            {
                case "CodigoCol":
                    FormasPago.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Codigo.CompareTo(t2.Codigo) : t2.Codigo.CompareTo(t1.Codigo));
                    break;
                case "FormaCol":
                    FormasPago.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Forma.CompareTo(t2.Forma) : t2.Forma.CompareTo(t1.Forma));
                    break;
            }

            // Cambiar la dirección de orden para la próxima vez
            direction = (direction == ListSortDirection.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Actualizar la etiqueta de dirección de orden
            FormaPagoGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<FormaPago>(FormasPago);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }
}