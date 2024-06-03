using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Actividad : BaseClass, IAccessDB<Actividad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionActividadGuardar;
        public List<Actividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Actividad> FindAll(string criterio)
        {
            return ORMDB<Actividad>.FindAll(criterio); 
        }
        public Actividad FindbyKey(params object[] key)
        {
            var act = ORMDB<Actividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = act.Codigo;
            this.CodTipoActividad = act.CodTipoActividad;
            this.CodTransporte = act.CodTransporte;
            this.Importe = act.Importe;
            this.Nivel = act.Nivel;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionActividadGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    
                }
            }
            return ORMDB<Actividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Actividad
        public static List<Actividad> FindAllStatic(string criterio, Comparison<Actividad> compara)
        {
            var lista = ORMDB<Actividad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Actividad FindByKeyStatic(params object[] key)
        {
            return ORMDB<Actividad>.FindbyKey(key);
        }
    }
}
