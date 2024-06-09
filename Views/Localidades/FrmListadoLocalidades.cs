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

            this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(null, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));

            this.ExportarBtn.Enabled = true;
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

            if (this.LocalidadChk.Checked && this.LocalidadCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_Localidad = " + LocalidadCbo.SelectedValue;
                }
                else
                    criterio = "cod_Localidad = " + LocalidadCbo.SelectedValue;
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

        }
    }
}
