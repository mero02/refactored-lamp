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
    public partial class FrmListadoTuristas : FormBase
    {
        public FrmListadoTuristas()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.NombreChk.Checked;
        }

        private void FrmListadoTuristas_Load(object sender, EventArgs e)
        {            
            LoadComboBox( Pais.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.PaisCbo, addSeleccion: true);
                                    
            this.TuristasGrd.AutoGenerateColumns = false;
            this.TuristasGrd.DataSource = Turista.FindAllStatic (null, (p1,p2)=> (p1.Nombre).CompareTo(p2.Nombre));
        }

        private void PaisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.PaisCbo.Enabled = PaisChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;
            
            if (this.PaisChk.Checked && this.PaisCbo.SelectedIndex != -1)
            {
                if (criterio != null)
                {
                    criterio += " and cod_pais = " + PaisCbo.SelectedValue;
                }
                else
                    criterio = "cod_pais = " + PaisCbo.SelectedValue;
            }
            this.TuristasGrd.DataSource = Turista.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));            
        }

        private void TuristasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TuristasGrd.Rows)
            {                
                rw.Cells[3].Value = (rw.DataBoundItem as Turista).PaisObj.Nombre;
            }
        }

        private void TuristasGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TuristasGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmTuristaAM frmpac = new FrmTuristaAM();
            Turista pac  =  (this.TuristasGrd.SelectedRows[0].DataBoundItem as Turista);
            frmpac.ShowModificarTurista(pac);
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
