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
    public partial class FrmAgenciaBusq : FormBase
    {
        public FrmAgenciaBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;            

            if (this.LocalidadChk.Checked)
            {
                if(criterio==null)
                    criterio = String.Format("codigo_postal = {0} ", LocalidadCbo.SelectedValue);
                else
                    criterio += String.Format(" and codigo_postal = {0}", LocalidadCbo.SelectedValue );
            }

            try
            {
                var lista = Agencia.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmAgenciaList frm = new FrmAgenciaList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombresChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void FrmAgenciaBusq_Load(object sender, EventArgs e)
        {            
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null,(loc1,loc2)=>loc1.Nombre.CompareTo(loc2.Nombre) );
            LocalidadCbo.SelectedIndex = -1;
        }

        private void FrmAgenciaBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void LocalidadChk_CheckedChanged_1(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

    }
}
