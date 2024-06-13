using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db;
using Newtonsoft;

namespace TurApp.Views
{
    public partial class FrmListadoFacturas : FormBase
    {
        private List<FacturaTurista> _listado;

        public FrmListadoFacturas()
        {
            InitializeComponent();
        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {

        }

        public void ShowListadoFacturas(List<FacturaTurista> listado)
        {
            //this.InvokerForm = Invoker;
            _listado = listado;
           //_criterio = criterio;
            this.FacturasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<FacturaTurista>(listado);
            var source = new BindingSource(bindingList, null);
            //this.TuristasGrd.DataSource = listado;
            this.FacturasGrd.DataSource = source;
            //InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturasTuristaGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as FacturaTurista).Nro;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as FacturaTurista).Serie;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[2].Value = (item.DataBoundItem as FacturaTurista).Letra;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[3].Value = (item.DataBoundItem as FacturaTurista).Fecha;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[4].Value = (item.DataBoundItem as FacturaTurista).DniTurista;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[5].Value = (item.DataBoundItem as FacturaTurista).CodFormaPago;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[6].Value = (item.DataBoundItem as FacturaTurista).DetallePago;
            }
        }
    }
}
