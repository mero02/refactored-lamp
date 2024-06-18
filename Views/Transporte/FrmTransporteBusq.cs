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
    public partial class FrmTransporteBusq : FormBase
    {
        public FrmTransporteBusq()
        {
            InitializeComponent();
        }



        private void FrmTransporteBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.DominioChk.Checked)
            {
                criterio = String.Format("cod_pais = {0} ", (DominioCbo.SelectedValue));
            }

            try
            {
                var lista = Transporte.FindAllStatic(criterio, (p1, p2) => (p1.Dominio).CompareTo(p2.Dominio));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                //FrmTuristaList frm = new FrmTuristaList();
               //frm.ShowListado(lista, this, criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTransporteBusq_Load(object sender, EventArgs e)
        {
            DominioCbo.DataSource = Transporte.FindAllStatic(null, (loc1, loc2) => loc1.Dominio.CompareTo(loc2.Dominio));
            DominioCbo.SelectedIndex = -1;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }
    }
}
