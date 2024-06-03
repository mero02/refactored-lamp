using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Agencia : BaseClass, IAccessDB<Agencia>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionAgenciaGuardar;
        public List<Agencia> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Agencia> FindAll(string criterio)
        {
            return ORMDB<Agencia>.FindAll(criterio); 
        }
        public Agencia FindbyKey(params object[] key)
        {
            var agn = ORMDB<Agencia>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = agn.Codigo;
            this.Nombre = agn.Nombre;
            this.Calle = agn.Calle;
            this.Nro = agn.Nro;
            this.Piso = agn.Piso;
            this.Dpto = agn.Dpto;
            this.Telefono1 = agn.Telefono1;
            this.Telefono2 = agn.Telefono2;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionAgenciaGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionAgenciaGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Agencia>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Agencia
        public static List<Agencia> FindAllStatic(string criterio, Comparison<Agencia> compara)
        {
            var lista = ORMDB<Agencia>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Agencia FindByKeyStatic(params object[] key)
        {
            return ORMDB<Agencia>.FindbyKey(key);
        }
    }
}
