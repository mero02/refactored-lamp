using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class TipoActividad : BaseClass, IAccessDB<TipoActividad>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTipoActividadGuardar;
        public List<TipoActividad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TipoActividad> FindAll(string criterio)
        {
            return ORMDB<TipoActividad>.FindAll(criterio); 
        }
        public TipoActividad FindbyKey(params object[] key)
        {
            var tp_act = ORMDB<TipoActividad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = tp_act.Codigo;
            this.Nombre = tp_act.Nombre;
            this.Descripcion = tp_act.Descripcion;
            this.Duracion = tp_act.Duracion;
            this.Nivel = tp_act.Nivel;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTipoActividadGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionTipoActividadGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<TipoActividad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TipoActividad
        public static List<TipoActividad> FindAllStatic(string criterio, Comparison<TipoActividad> compara)
        {
            var lista = ORMDB<TipoActividad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static TipoActividad FindByKeyStatic(params object[] key)
        {
            return ORMDB<TipoActividad>.FindbyKey(key);
        }
    }
}
