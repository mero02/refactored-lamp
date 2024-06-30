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
        private string nro, serie, letra;
        public FrmDetalleFactura(string nro,string serie,string letra)
        {
            InitializeComponent();
            this.nro = nro;
            this.serie = serie;
            this.letra = letra;
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {

        }

        public void ShowListadoDetalleFacturas(FormBase Invoker)
        {
            string criterio = String.Format("nro_fact = '{0}' AND serie_fact = '{1}' AND letra_fact = '{2}'", nro, serie, letra);
            var lista = DetalleFacturaTurista.FindAllStatic(criterio, (p1, p2) => (p1.NroFactura).CompareTo(p2.NroFactura));
            this.InvokerForm = Invoker;
            this.DetalleFacGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<DetalleFacturaTurista>(lista);
            var source = new BindingSource(bindingList, null);
            this.DetalleFacGrd.DataSource = source;
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void DetalleFacGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Desactivar temporalmente el evento para evitar recursiones infinitas
            this.DetalleFacGrd.DataBindingComplete -= DetalleFacGrd_DataBindingComplete;

            foreach (DataGridViewRow item in this.DetalleFacGrd.Rows)
            {
                var detalleFacturaTurista = item.DataBoundItem as DetalleFacturaTurista;
                if (detalleFacturaTurista != null)
                {
                    item.Cells[0].Value = detalleFacturaTurista.NroRenglon;
                    item.Cells[1].Value = detalleFacturaTurista.CodPaquete;
                    item.Cells[2].Value = detalleFacturaTurista.Importe;
                }
            }

            // Volver a activar el evento
            this.DetalleFacGrd.DataBindingComplete += DetalleFacGrd_DataBindingComplete;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
