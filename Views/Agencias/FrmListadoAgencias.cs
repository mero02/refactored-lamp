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
            this.AgenciasGrd.DataSource = Agencia.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));

            this.ExportarBtn.Enabled = true;
        }

        private void AgenciasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.AgenciasGrd.Rows)
            {
                rw.Cells[6].Value = (rw.DataBoundItem as Agencia).LocalidadObj.Nombre;
            }

            foreach (DataGridViewRow rw in this.AgenciasGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as Agencia).Nombre;
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
    }
}
