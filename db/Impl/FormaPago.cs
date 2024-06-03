using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class FormaPago : BaseClass, IAccessDB<FormaPago>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionFormaPagoGuardar;
        public List<FormaPago> FindAll()
        {
            return this.FindAll(null);
        }
        public List<FormaPago> FindAll(string criterio)
        {
            return ORMDB<FormaPago>.FindAll(criterio); 
        }
        public FormaPago FindbyKey(params object[] key)
        {
            var forma = ORMDB<FormaPago>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo= forma.Codigo;
            this.Forma = forma.Forma;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionFormaPagoGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Forma == "" )
                        ValidacionFormaPagoGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<FormaPago>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-FormaPago
        public static List<FormaPago> FindAllStatic(string criterio, Comparison<FormaPago> compara)
        {
            var lista = ORMDB<FormaPago>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static FormaPago FindByKeyStatic(params object[] key)
        {
            return ORMDB<FormaPago>.FindbyKey(key);
        }
    }
}
