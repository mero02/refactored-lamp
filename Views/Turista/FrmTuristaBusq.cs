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
    public partial class FrmTuristaBusq : FormBase
    {
        public FrmTuristaBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

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

            if (this.PaisChk.Checked)
            {
                if(criterio==null)
                    criterio = String.Format("cod_pais = {0} ", (PaisCbo.SelectedValue as Pais).Codigo);
                else
                    criterio += String.Format(" and cod_pais = {0}", (PaisCbo.SelectedValue as Pais).Codigo);
            }

            try
            {
                var lista = Turista.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmTuristaList frm = new FrmTuristaList();
                frm.ShowListado(lista, this, null);
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

        private void NombresChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PaisCbo.Enabled = this.PaisChk.Checked;
        }

        private void FrmTuristaBusq_Load(object sender, EventArgs e)
        {            
            PaisCbo.DataSource = Pais.FindAllStatic(null,(loc1,loc2)=>loc1.Nombre.CompareTo(loc2.Nombre) );
            PaisCbo.SelectedIndex = -1;
        }

        private void FrmTuristaBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

    }
}
