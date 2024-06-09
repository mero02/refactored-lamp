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
    public partial class FrmLocalidadList : FormBase
    {
        public FrmLocalidadList()
        {
            InitializeComponent();
        }

        private void FrmLocalidadList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as Localidad).Codigo;
            }

            foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as Localidad).Nombre;
            }
        }

        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
