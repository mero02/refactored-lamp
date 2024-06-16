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
    public partial class FrmTipoActividadList : FormBase
    {
        private string _criterio = null;
        private List<TipoActividad> _listado;
        public FrmTipoActividadList()
        {
            InitializeComponent();
        }
        public void ShowListado(List<TipoActividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoActividadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<TipoActividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.TipoActividadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
        private void FrmTipoActividadList_Load(object sender, EventArgs e)
        {

        }

        private void TipoActividadGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
