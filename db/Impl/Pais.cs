using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Pais : BaseClass, IAccessDB<Pais>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionPaisGuardar;
        public List<Pais> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Pais> FindAll(string criterio)
        {
            return ORMDB<Pais>.FindAll(criterio); 
        }
        public Pais FindbyKey(params object[] key)
        {
            var pais = ORMDB<Pais>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = pais.Codigo;
            this.Nombre = pais.Nombre;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionPaisGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionPaisGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Pais>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Pais
        public static List<Pais> FindAllStatic(string criterio, Comparison<Pais> compara)
        {
            var lista = ORMDB<Pais>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Pais FindByKeyStatic(params object[] key)
        {
            return ORMDB<Pais>.FindbyKey(key);
        }
    }
}
