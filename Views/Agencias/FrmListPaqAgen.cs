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
    public partial class FrmListPaqAgen : FormBase
    {
        private string cod_agencia;
        public FrmListPaqAgen(string cod_agencia)
        {
            InitializeComponent();
            this.cod_agencia = cod_agencia;
        }

        private void FrmListPaqAgen_Load(object sender, EventArgs e)
        {

        }

        public void ShowListPaqAgen(FormBase Invoker)
        {
            string criterio = String.Format("cod_agencia = '{0}' ", cod_agencia);
            var lista = Paquete.FindAllStatic(criterio, (p1, p2) => (p1.Codigo).CompareTo(p2.Codigo));
            this.InvokerForm = Invoker;
            this.PaquetesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Paquete>(lista);
            var source = new BindingSource(bindingList, null);
            this.PaquetesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaquetesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PaquetesGrd.DataBindingComplete -= PaquetesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.PaquetesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.PaquetesGrd.Rows[i];
                    item.Cells[0].Value = (item.DataBoundItem as Paquete).Codigo;
                    item.Cells[1].Value = (item.DataBoundItem as Paquete).TipoPaqueteObj.Nombre;
                    item.Cells[2].Value = (item.DataBoundItem as Paquete).AgenciaObj.Nombre;
                    item.Cells[6].Value = (item.DataBoundItem as Paquete).CodDestino;
                }
            }
            finally
            {
                this.PaquetesGrd.DataBindingComplete += PaquetesGrd_DataBindingComplete;
            }
        }
    }
}
