using System;
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
    public partial class FrmTipoPaqueteBusq : FormBase
    {
        public FrmTipoPaqueteBusq()
        {
            InitializeComponent();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmTipoPaqueteBusq_Load(object sender, EventArgs e)
        {
           TipoPaqueteCbo.DataSource = TipoPaquete.FindAllStatic(null, (tpq1, tpq2) => tpq1.Nombre.CompareTo(tpq2.Nombre));
           TipoPaqueteCbo.SelectedIndex = -1;
        }

        private void TipoPaqueteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoPaqueteCbo.Enabled = TipoPaqueteChk.Checked;

        }

        private void FrmTipoPaqueteBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;

            if (this.TipoPaqueteChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("codigo = {0} ", (TipoPaqueteCbo.SelectedValue));
                else
                    criterio += String.Format(" and codigo = {0}", (TipoPaqueteCbo.SelectedValue));
            }

            try
            {
                var lista = TipoPaquete.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmTipoPaqueteList frm = new FrmTipoPaqueteList();
                frm.ShowListado(lista, this, criterio);   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
