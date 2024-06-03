using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class AgenciaTipoPaquete : BaseClass, IAccessDB<AgenciaTipoPaquete>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionAgenciaTipoPaqueteGuardar;
        public List<AgenciaTipoPaquete> FindAll()
        {
            return this.FindAll(null);
        }
        public List<AgenciaTipoPaquete> FindAll(string criterio)
        {
            return ORMDB<AgenciaTipoPaquete>.FindAll(criterio); 
        }
        public AgenciaTipoPaquete FindbyKey(params object[] key)
        {
            var agntp = ORMDB<AgenciaTipoPaquete>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.CodAgencia = agntp.CodAgencia;
            this.CodTipoPaquete = agntp.CodTipoPaquete;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionAgenciaTipoPaqueteGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                   
                }
            }
            return ORMDB<AgenciaTipoPaquete>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-AgenciaTipoPaquete
        public static List<AgenciaTipoPaquete> FindAllStatic(string criterio, Comparison<AgenciaTipoPaquete> compara)
        {
            var lista = ORMDB<AgenciaTipoPaquete>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static AgenciaTipoPaquete FindByKeyStatic(params object[] key)
        {
            return ORMDB<AgenciaTipoPaquete>.FindbyKey(key);
        }
    }
}
