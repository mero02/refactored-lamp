using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Destino : BaseClass, IAccessDB<Destino>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionDestinoGuardar;
        public List<Destino> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Destino> FindAll(string criterio)
        {
            return ORMDB<Destino>.FindAll(criterio); 
        }
        public Destino FindbyKey(params object[] key)
        {
            var dest = ORMDB<Destino>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = dest.Codigo;
            this.Nombre = dest.Nombre;
            this.Descripcion = dest.Descripcion;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionDestinoGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionDestinoGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Destino>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Destino
        public static List<Destino> FindAllStatic(string criterio, Comparison<Destino> compara)
        {
            var lista = ORMDB<Destino>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Destino FindByKeyStatic(params object[] key)
        {
            return ORMDB<Destino>.FindbyKey(key);
        }
    }
}
