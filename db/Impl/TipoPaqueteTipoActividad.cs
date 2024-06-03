using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class TipoPaqueteTipoActividad : BaseClass, IAccessDB<TipoPaqueteTipoActividad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTipoPaqueteTipoActividadGuardar;
        public List<TipoPaqueteTipoActividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TipoPaqueteTipoActividad> FindAll(string criterio)
        {
            return ORMDB<TipoPaqueteTipoActividad>.FindAll(criterio); 
        }
        public TipoPaqueteTipoActividad FindbyKey(params object[] key)
        {
            var tpPq_tpAct = ORMDB<TipoPaqueteTipoActividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.CodTipoPaquete = tpPq_tpAct.CodTipoPaquete;
            this.CodTipoActividad = tpPq_tpAct.CodTipoActividad;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTipoPaqueteTipoActividadGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    
                }
            }
            return ORMDB<TipoPaqueteTipoActividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TipoPaqueteTipoActividad
        public static List<TipoPaqueteTipoActividad> FindAllStatic(string criterio, Comparison<TipoPaqueteTipoActividad> compara)
        {
            var lista = ORMDB<TipoPaqueteTipoActividad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static TipoPaqueteTipoActividad FindByKeyStatic(params object[] key)
        {
            return ORMDB<TipoPaqueteTipoActividad>.FindbyKey(key);
        }
    }
}
