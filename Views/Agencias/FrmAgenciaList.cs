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
    public partial class FrmAgenciaList : FormBase
    {
        private string _criterio = null;
        private List<Agencia> _listado;
        public FrmAgenciaList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<Agencia> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.AgenciasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Agencia>(listado);
            var source = new BindingSource(bindingList, null);
            this.AgenciasGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void FrmAgenciaList_Load(object sender, EventArgs e)
        {

        }

        private void AgenciasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.AgenciasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.AgenciasGrd.Rows[i];
                Agencia ag = item.DataBoundItem as Agencia;
                item.Cells[1].Value = ag.Calle + " " + ag.Nro + " " + ag.Piso + " " +ag.Dpto ;
                item.Cells[2].Value = ag.LocalidadObj.Nombre;
            }
        }
    }
}
