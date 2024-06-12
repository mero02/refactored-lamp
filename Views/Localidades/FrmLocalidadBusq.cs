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
    public partial class FrmLocalidadBusq : FormBase
    {
        public FrmLocalidadBusq()
        {
            InitializeComponent();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmLocalidadBusq_Load(object sender, EventArgs e)
        {
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            LocalidadCbo.SelectedIndex = -1;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FrmLocalidadBusq_Activated(object sender, EventArgs e)
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

            if (this.LocalidadChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("cod_postal = {0} ", (LocalidadCbo.SelectedValue));
                else
                    criterio += String.Format(" and cod_postal = {0}", (LocalidadCbo.SelectedValue));
            }

            try
            {
                var lista = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmLocalidadList frm = new FrmLocalidadList();
                frm.ShowListado(lista, this, criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
