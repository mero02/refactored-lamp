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
    public partial class FrmFormaPagoBusq : FormBase
    {
        public FrmFormaPagoBusq()
        {
            InitializeComponent();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmFormaPagoBusq_Load(object sender, EventArgs e)
        {
            FormaPagoCbo.DataSource = FormaPago.FindAllStatic(null, (for1, for2) => for1.Forma.CompareTo(for2.Forma));
            FormaPagoCbo.SelectedIndex = -1;
        }

        private void FormaPagoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FormaPagoCbo.Enabled = FormaPagoChk.Checked;
        }

        private void FrmFormaPagoBusq_Activated(object sender, EventArgs e)
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

            if (this.FormaPagoChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("codigo = {0} ", (FormaPagoCbo.SelectedValue));
                else
                    criterio += String.Format(" and codigo = {0}", (FormaPagoCbo.SelectedValue));
            }

            try
            {
                var lista = FormaPago.FindAllStatic(criterio, (p1, p2) => (p1.Forma).CompareTo(p2.Forma));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmFormaPagoList frm = new FrmFormaPagoList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
