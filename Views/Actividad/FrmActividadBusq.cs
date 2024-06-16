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
    public partial class FrmActividadBusq : FormBase
    {
        public FrmActividadBusq()
        {
            InitializeComponent();
        }

        private void FrmActividadBusq_Load(object sender, EventArgs e)
        {
            ActividadCbo.DataSource = TipoActividad.FindAllStatic(null, (for1, for2) => for1.Codigo.CompareTo(for2.Codigo));
            ActividadCbo.SelectedIndex = -1;
        }
        
        public void ShowBuscar()
        {
            this.Show();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodigoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ActividadCbo.Enabled = this.CodigoChk.Checked;
            
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;

            if (this.CodigoChk.Checked)
            {
                criterio = String.Format("cod_tipo_actividad = {0}", (ActividadCbo.SelectedValue));
            }




            try
            {
                var lista = Actividad.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));

                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmActividadList frm = new FrmActividadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MainView.Instance.Cursor = Cursors.Default;
            }
        }

        

    }
}
