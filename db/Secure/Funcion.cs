using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "funciones")]
    public partial class Funcion : BaseClass, IAccessDB<Funcion>
    {
        #region variables locales
        private int _id;
        private string _nombre;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 60)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion

        public event ValidarClaseDelegate ValidacionFuncionGuardar;
        public List<Funcion> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Funcion> FindAll(string criterio)
        {
            return ORMDB<Funcion>.FindAll(criterio);
        }
        public Funcion FindbyKey(params object[] key)
        {
            var func = ORMDB<Funcion>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = func.Id;
            this.Nombre = func.Nombre;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionFuncionGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionFuncionGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Funcion>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Funcion
        public static List<Funcion> FindAllStatic(string criterio, Comparison<Funcion> compara)
        {
            var lista = ORMDB<Funcion>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Funcion FindByKeyStatic(params object[] key)
        {
            return ORMDB<Funcion>.FindbyKey(key);
        }
    }

}
