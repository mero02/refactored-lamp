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
    public partial class FrmDetalleFactura : FormBase
    {
        public FrmDetalleFactura()
        {
            InitializeComponent();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {

        }

        public void ShowListadoDetalleFacturas(FormBase Invoker,string nro)
        {
            var lista = DetalleFacturaTurista.FindAllStatic(nro, (p1, p2) => (p1.NroFactura).CompareTo(p2.NroFactura));
            this.InvokerForm = Invoker;
            this.DetalleFacGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<DetalleFacturaTurista>(lista);
            var source = new BindingSource(bindingList, null);
            this.DetalleFacGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void DetalleFacGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*for (int i = 0; i < this.DetalleFacGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.DetalleFacGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as DetalleFacturaTurista).NroRenglon;
            }
            for (int i = 0; i < this.DetalleFacGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.DetalleFacGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as DetalleFacturaTurista).CodPaquete;
            }

            for (int i = 0; i < this.DetalleFacGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.DetalleFacGrd.Rows[i];
                item.Cells[2].Value = (item.DataBoundItem as DetalleFacturaTurista).Importe;
            }*/
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
