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
    public partial class FrmPaqueteBusq : FormBase
    {
        public FrmPaqueteBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        private void FrmPaqueteBusq_Load(object sender, EventArgs e)
        {
            TipoPaqueteCbo.DataSource = TipoPaquete.FindAllStatic(null, (tpq1, tpq2) => tpq1.Nombre.CompareTo(tpq2.Nombre));
            TipoPaqueteCbo.SelectedIndex = -1;

            AgenciaCbo.DataSource = Agencia.FindAllStatic(null, (age1, age2) => age1.Nombre.CompareTo(age2.Nombre));
            AgenciaCbo.SelectedIndex = -1;

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.DniChk.Checked)
            {
                criterio = String.Format("dni = {0}", DniTxt.Text);
            }

            if (this.TipoPaqueteChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("Tipo Paquete = {0} ", (TipoPaqueteCbo.SelectedValue));
                //else
                  //  criterio += String.Format(" and Tipo Paquete  = {0}", (TipoPaqueteCbo.SelectedValue));
            }
            if (this.AgenciaChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("Agencia = '{0}'", (AgenciaCbo.SelectedValue));
               // else
                  //  criterio += String.Format(" and Agencia  = {0}", (AgenciaCbo.SelectedValue));
            }

            try
            {
                var lista = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmTuristaList frm = new FrmTuristaList();
                //frm.ShowListado(lista, this, criterio); //Falta el listado y list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DniChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DniTxt.Enabled = this.DniChk.Checked;
        }

        
        private void CodAgenciaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AgenciaCbo.Enabled = this.AgenciaChk.Checked;

        }

        private void TipoPaqueteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoPaqueteCbo.Enabled = this.TipoPaqueteChk .Checked;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmPaqueteBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void DniTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
