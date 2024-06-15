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

        public void ShowListadoFacturas(string criterio, FormBase Invoker)
        {
            var lista = FacturaTurista.FindAllStatic(criterio, (p1, p2) => (p1.DniTurista).CompareTo(p2.DniTurista));
            this.InvokerForm = Invoker;
            _listado = lista;
            this.FacturasGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<FacturaTurista>(lista);
            var source = new BindingSource(bindingList, null);
            this.FacturasGrd.DataSource = source;
            InvokerForm.Close();
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
                item.Cells[5].Value = (item.DataBoundItem as FacturaTurista).FormaPagoObj.Forma;
            }
            for (int i = 0; i < this.FacturasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.FacturasGrd.Rows[i];
                item.Cells[6].Value = (item.DataBoundItem as FacturaTurista).DetallePago;
            }
        }

        private void FacturasGrd_DoubleClick(object sender, EventArgs e)
        {
            string nro = String.Format("nro_fact = {0}",_listado[0].Nro);

            MainView.Instance.Cursor = Cursors.Default;
            FrmDetalleFactura frm = new FrmDetalleFactura();
            frm.ShowListadoDetalleFacturas(this, nro);
                

        }
    }
}
