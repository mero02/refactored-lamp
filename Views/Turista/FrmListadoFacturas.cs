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
            // Desactivar temporalmente el evento para evitar recursiones infinitas
            this.FacturasGrd.DataBindingComplete -= FacturasTuristaGrd_DataBindingComplete;

            foreach (DataGridViewRow item in this.FacturasGrd.Rows)
            {
                var facturaTurista = item.DataBoundItem as FacturaTurista;
                if (facturaTurista != null)
                {
                    item.Cells[0].Value = facturaTurista.Nro;
                    item.Cells[1].Value = facturaTurista.Serie;
                    item.Cells[2].Value = facturaTurista.Letra;
                    item.Cells[3].Value = facturaTurista.Fecha;
                    item.Cells[4].Value = facturaTurista.DniTurista;
                    item.Cells[5].Value = facturaTurista.FormaPagoObj.Forma; 
                    item.Cells[6].Value = facturaTurista.DetallePago;
                }
            }

            // Volver a activar el evento
            this.FacturasGrd.DataBindingComplete += FacturasTuristaGrd_DataBindingComplete;
        }


        private void _CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = FacturasGrd.Rows[e.RowIndex];
                
                string nro = row.Cells["nro"].Value.ToString();
                string serie = row.Cells["serie"].Value.ToString();
                string letra = row.Cells["letra"].Value.ToString();

                FrmDetalleFactura frm = new FrmDetalleFactura(nro,serie,letra);

                frm.ShowListadoDetalleFacturas(this);

            }

        }
    }
}
