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
    public partial class FrmListActPaq : FormBase
    {
        private string cod_paquete;
        public FrmListActPaq(string codigo)
        {
            InitializeComponent();
            this.cod_paquete = codigo;
        }

        public void ShowListActPaq(FormBase Invoker)
        {
            string criterio = String.Format("cod_tipo_paquete = '{0}' ", cod_paquete);
            var lista = TipoPaqueteTipoActividad.FindAllStatic(criterio, (p1, p2) => (p1.CodTipoPaquete).CompareTo(p2.CodTipoPaquete));
            var listaActividades = getActividades(lista);
            this.InvokerForm = Invoker;
            this.ActividadesGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Actividad>(listaActividades);
            var source = new BindingSource(bindingList, null);
            this.ActividadesGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private List<Actividad> getActividades(List<TipoPaqueteTipoActividad> lista){
            var actividades = new List<Actividad>();
            var actividadesTodas = Actividad.FindAllStatic(null, (p1, p2) => p1.Codigo.CompareTo(p2.Codigo));

            foreach (TipoPaqueteTipoActividad tipoPtipoA in lista)
            {
                var codigo_actividad = tipoPtipoA.CodTipoActividad;
                foreach (Actividad actividad in actividadesTodas)
                {
                    if (codigo_actividad == actividad.CodTipoActividad) {
                        actividades.Add(actividad);
                    }
                }
            }

            return actividades.OrderBy(p => p.Codigo).ToList();
        }

        private void FrmListActPaq_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActividadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.ActividadesGrd.DataBindingComplete -= ActividadesGrd_DataBindingComplete;

            try
            {
                for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
                {
                    DataGridViewRow item = this.ActividadesGrd.Rows[i];
                    item.Cells[1].Value = (item.DataBoundItem as Actividad).TransporteObj.Descripcion;
                    item.Cells[3].Value = (item.DataBoundItem as Actividad).TipoActividadObj.Nombre;
                }
            }
            finally
            {
                this.ActividadesGrd.DataBindingComplete += ActividadesGrd_DataBindingComplete;
            }
        }
    }
}
