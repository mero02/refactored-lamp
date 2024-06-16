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
    public partial class FrmListadoPaises : Form
    {
        public FrmListadoPaises()
        {
            InitializeComponent();
        }

        private void FrmListadoDestinos_Load(object sender, EventArgs e)
    {
        this.PaisesGrd.AutoGenerateColumns = false;
        var paises = Pais.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
        var PaisesConTuristas = filtrarPaisesPorDestino(paises);
        var PaisesBindingList = new BindingList<PaisConTuristas>(PaisesConTuristas);
        var PaisesBindingSource = new BindingSource(PaisesBindingList, null);
        this.PaisesGrd.DataSource = PaisesBindingSource;

        this.ExportarBtn.Enabled = true;

        this.PaisesGrd.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(PaisesGrd_ColumnHeaderMouseClick);
    }

    private class PaisConTuristas
    {
        public Pais PaisCol;
        public int CodigoCol;
        public int CantidadCol;
    }

    private List<PaisConTuristas> filtrarPaisesPorDestino(List<Pais> Paises)
    {
        var PaisesConTuristas = new List<PaisConTuristas>();
        var Turistas = Turista.FindAllStatic(null, (p1, p2) => p1.CodPais.CompareTo(p2.CodPais));

        foreach (Pais pais in Paises)
        {
            var codPais = pais.Codigo;
            int count = 0;
            foreach (Turista turista in Turistas)
            {
                if (codPais == turista.CodPais)
                {
                    count++;
                }
            }
        PaisesConTuristas.Add(new PaisConTuristas { PaisCol = pais, CodigoCol = codPais, CantidadCol = count });
    }

        return PaisesConTuristas.OrderBy(p => p.CodigoCol).ToList();
    }

        private void PaisesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PaisesGrd.DataBindingComplete -= PaisesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.PaisesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaisesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as Pais).Nombre;
                }
            }
            finally
            {
                this.PaisesGrd.DataBindingComplete += PaisesGrd_DataBindingComplete;
            }
        }

        private void PaisesGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    ExportToCsv(PaisesGrd, sfd.FileName);
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

        private void PaisesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void FrmListadoPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
