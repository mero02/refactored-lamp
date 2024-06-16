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
    public partial class FrmTipoActividadBusq : FormBase
    {
        public FrmTipoActividadBusq()
        {
            InitializeComponent();
        }
        public void ShowBuscar() 
        {
            this.Show();
        }
        private void FrmTipoActividadBusq_Load(object sender, EventArgs e)
        {
            TipoActividadCbo.DataSource = TipoActividad.FindAllStatic(null, (tpq1, tpq2) => tpq1.Nombre.CompareTo(tpq2.Nombre));
            TipoActividadCbo.SelectedIndex = -1;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoActividadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoActividadCbo.Enabled = TipoActividadChk.Checked;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;

            if (this.TipoActividadChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("codigo = {0} ", (TipoActividadCbo.SelectedValue));
                else
                    criterio += String.Format(" and codigo = {0}", (TipoActividadCbo.SelectedValue));
            }

            try
            {
                var lista = TipoActividad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmTipoActividadList frm = new FrmTipoActividadList();
                //frm.ShowListado(lista, this, criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
