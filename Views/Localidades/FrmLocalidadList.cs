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
        private string _criterio = null;
        private List<Localidad> _listado;

        public FrmLocalidadList()
        {
            InitializeComponent();
        }

        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.LocalidadesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Localidad>(listado);
            var source = new BindingSource(bindingList, null);
            this.LocalidadesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmLocalidadList_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LocalidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.LocalidadesGrd.Rows.Count; ++i)
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
        }

    }
}
