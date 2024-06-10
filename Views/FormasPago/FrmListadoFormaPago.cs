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
            this.FormaPagoGrd.DataSource = FormaPago.FindAllStatic(null, (p1, p2) => (p1.Forma).CompareTo(p2.Forma));

            this.ExportarBtn.Enabled = true;
        }

        private void FormaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FormaPagoTxt.Enabled = this.FormaPagoChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //Implementar
        }

        private void FormaPagoGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormaPagoGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.FormaPagoGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as FormaPago).Codigo;
            }

            foreach (DataGridViewRow rw in this.FormaPagoGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as FormaPago).Forma;
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
    }
}