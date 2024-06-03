using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class PaqueteActividad : BaseClass, IAccessDB<PaqueteActividad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionPaqueteActividadGuardar;
        public List<PaqueteActividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<PaqueteActividad> FindAll(string criterio)
        {
            return ORMDB<PaqueteActividad>.FindAll(criterio); 
        }
        public PaqueteActividad FindbyKey(params object[] key)
        {
            var pq_act = ORMDB<PaqueteActividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.CodPaquete = pq_act.CodPaquete;
            this.CodActividad = pq_act.CodActividad;
            this.Importe = pq_act.Importe;
            this.FechaHoraDesde = pq_act.FechaHoraDesde;
            this.FechaHoraHasta = pq_act.FechaHoraHasta;
            this.Detalle = pq_act.Detalle;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionPaqueteActividadGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                  
                }
            }
            return ORMDB<PaqueteActividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-PaqueteActividad
        public static List<PaqueteActividad> FindAllStatic(string criterio, Comparison<PaqueteActividad> compara)
        {
            var lista = ORMDB<PaqueteActividad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static PaqueteActividad FindByKeyStatic(params object[] key)
        {
            return ORMDB<PaqueteActividad>.FindbyKey(key);
        }
    }
}
