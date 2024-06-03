using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class TipoPaquete : BaseClass, IAccessDB<TipoPaquete>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTipoPaqueteGuardar;
        public List<TipoPaquete> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TipoPaquete> FindAll(string criterio)
        {
            return ORMDB<TipoPaquete>.FindAll(criterio); 
        }
        public TipoPaquete FindbyKey(params object[] key)
        {
            var tp_paq = ORMDB<TipoPaquete>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = tp_paq.Codigo;
            this.Nombre = tp_paq.Nombre;
            this.Descripcion = tp_paq.Descripcion;
            this.Duracion = tp_paq.Duracion;
            this.Nivel = tp_paq.Nivel;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTipoPaqueteGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionTipoPaqueteGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<TipoPaquete>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TipoPaquete
        public static List<TipoPaquete> FindAllStatic(string criterio, Comparison<TipoPaquete> compara)
        {
            var lista = ORMDB<TipoPaquete>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static TipoPaquete FindByKeyStatic(params object[] key)
        {
            return ORMDB<TipoPaquete>.FindbyKey(key);
        }
    }
}
