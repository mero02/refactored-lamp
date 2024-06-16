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
    public partial class FrmListadoAuditoria : Form
    {
        public FrmListadoAuditoria()
        {
            InitializeComponent();
        }

        private class AuditoriaConLogger
        {
            public string UsuarioName;
            public string Objeto;
            public string Operacion;
            public DateTime Fecha;
            public string Detalle;
        }

        private void FrmListadoAuditoria_Load(object sender, EventArgs e)
        {
            this.AuditoriasGrd.AutoGenerateColumns = false;
            var auditorias = Logger.FindAllStatic(null, (a1, a2) => a1.Fecha.CompareTo(a2.Fecha));
            var AuditoriasConLogger = filtrarAuditoriasPorLogger(auditorias);
            var AuditoriasBindingList = new BindingList<AuditoriaConLogger>(AuditoriasConLogger);
            var AuditoriasBindingSource = new BindingSource(AuditoriasBindingList, null);
            this.AuditoriasGrd.DataSource = AuditoriasBindingSource;

            this.ExportarBtn.Enabled = true;

            this.AuditoriasGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(AuditoriasGrd_ColumnHeaderMouseClick);
        }

        private List<AuditoriaConLogger> filtrarAuditoriasPorLogger(List<Logger> Auditorias)
        {
            var AuditoriasConLogger = new List<AuditoriaConLogger>();

            foreach (Logger auditoria in Auditorias)
            {
                AuditoriasConLogger.Add(new AuditoriaConLogger { UsuarioName = auditoria.UsuarioName, Objeto = auditoria.Objeto, Operacion = auditoria.Operacion, Fecha = auditoria.Fecha, Detalle = auditoria.Detalle });
            }

            return AuditoriasConLogger.OrderBy(a => a.Fecha).ToList();
        }

        private void AuditoriasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.AuditoriasGrd.DataBindingComplete -= AuditoriasGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.AuditoriasGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.AuditoriasGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as AuditoriaConLogger).UsuarioName;
                    item.Cells[1].Value = (item.DataBoundItem as AuditoriaConLogger).Objeto;
                    item.Cells[2].Value = (item.DataBoundItem as AuditoriaConLogger).Fecha;
                    item.Cells[3].Value = (item.DataBoundItem as AuditoriaConLogger).Operacion;
                    item.Cells[4].Value = (item.DataBoundItem as AuditoriaConLogger).Detalle;
                }
            }
            finally
            {
                this.AuditoriasGrd.DataBindingComplete += AuditoriasGrd_DataBindingComplete;
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
                    ExportToCsv(AuditoriasGrd, sfd.FileName);
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

        private void AuditoriasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortOrderGrid = "";

            if (AuditoriasGrd.Tag != null)
                sortOrderGrid = AuditoriasGrd.Tag.ToString();

            DataGridViewColumn newColumn = AuditoriasGrd.Columns[e.ColumnIndex];

            // Determinar la dirección de orden
            ListSortDirection direction = sortOrderGrid.StartsWith("-") ? ListSortDirection.Descending : ListSortDirection.Ascending;

            // Obtener los turistas desde el DataSource
            var bindingSource = AuditoriasGrd.DataSource as BindingSource;
            if (bindingSource == null)
            {
                MessageBox.Show("DataSource no es un BindingSource.");
                return;
            }

            var auditorias = bindingSource.List.Cast<AuditoriaConLogger>().ToList();

            // Ordenar los turistas según la columna seleccionada
            switch (newColumn.Name)
            {
                case "usuario":
                    auditorias.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.UsuarioName.CompareTo(t2.UsuarioName) : t2.UsuarioName.CompareTo(t1.UsuarioName));
                    break;
                case "fecha":
                    auditorias.Sort((t1, t2) => direction == ListSortDirection.Ascending ? t1.Fecha.CompareTo(t2.Fecha) : t2.Fecha.CompareTo(t1.Fecha));
                    break;
            }

            // Actualizar la etiqueta de dirección de orden
            AuditoriasGrd.Tag = direction == ListSortDirection.Ascending ? "" : "-" + newColumn.Name;

            // Asignar los datos ordenados al DataSource
            bindingSource.DataSource = new BindingList<AuditoriaConLogger>(auditorias);

            // Mostrar la dirección de orden en el encabezado de la columna
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void AuditoriasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
