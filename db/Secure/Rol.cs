using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "roles")]
    public partial class Rol : BaseClass, IAccessDB<Rol>
    {
        #region variables locales
        private int _id;
        private string _nombre;
        private List<Funcion> _list_Funciones = null;
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

        public event ValidarClaseDelegate ValidacionRolGuardar;

        public List<Funcion> ListarFuncionesRol()
        {
            return Funcion.FindAllStatic("codigo in (select cod_funcion from funciones_rol where cod_rol="+ this.Id.ToString()+")", null);
        }
        public List<Rol> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Rol> FindAll(string criterio)
        {
            return ORMDB<Rol>.FindAll(criterio);
        }
        public Rol FindbyKey(params object[] key)
        {
            var rol = ORMDB<Rol>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = rol.Id;
            this.Nombre = rol.Nombre;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionRolGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionRolGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Rol>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Rol
        public static List<Rol> FindAllStatic(string criterio, Comparison<Rol> compara)
        {
            var lista = ORMDB<Rol>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Rol FindByKeyStatic(params object[] key)
        {
            return ORMDB<Rol>.FindbyKey(key);
        }
    }

}
