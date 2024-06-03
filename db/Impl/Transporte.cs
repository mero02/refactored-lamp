using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class Transporte : BaseClass, IAccessDB<Transporte>, IImpleCodigo
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTransporteGuardar;
        public List<Transporte> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Transporte> FindAll(string criterio)
        {
            return ORMDB<Transporte>.FindAll(criterio); 
        }
        public Transporte FindbyKey(params object[] key)
        {
            var trp = ORMDB<Transporte>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = trp.Codigo;
            this.Dominio = trp.Dominio;
            this.Descripcion = trp.Descripcion;
            this.Importe = trp.Importe;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTransporteGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                   
                }
            }
            return ORMDB<Transporte>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Transporte
        public static List<Transporte> FindAllStatic(string criterio, Comparison<Transporte> compara)
        {
            var lista = ORMDB<Transporte>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Transporte FindByKeyStatic(params object[] key)
        {
            return ORMDB<Transporte>.FindbyKey(key);
        }
    }
}
