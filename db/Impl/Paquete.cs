using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Paquete : BaseClass, IAccessDB<Paquete>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionPaqueteGuardar;
        public List<Paquete> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Paquete> FindAll(string criterio)
        {
            return ORMDB<Paquete>.FindAll(criterio); 
        }
        public Paquete FindbyKey(params object[] key)
        {
            var pq = ORMDB<Paquete>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = pq.Codigo;
            this.CodTipoPaquete = pq.CodTipoPaquete;
            this.CodAgencia = pq.CodAgencia;
            this.Fecha = pq.Fecha;
            this.DniTurista = pq.DniTurista;
            this.Nivel = pq.Nivel;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionPaqueteGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    
                }
            }
            return ORMDB<Paquete>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Paquete
        public static List<Paquete> FindAllStatic(string criterio, Comparison<Paquete> compara)
        {
            var lista = ORMDB<Paquete>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Paquete FindByKeyStatic(params object[] key)
        {
            return ORMDB<Paquete>.FindbyKey(key);
        }
    }
}
