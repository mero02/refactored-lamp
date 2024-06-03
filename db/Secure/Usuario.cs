using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "usuarios")]
    public partial class Usuario : BaseClass, IAccessDB<Usuario>
    {
        #region variables locales
        private int _id;
        private string _usuario;
        private string _clave;
        private DateTime? _fecha_login;
        private List<Rol> _listRolesUsuario=null;
        private List<Funcion> _list_Funciones=null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "id", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "usuario", Tipo = typeof(string), Longitud = 90)]
        public string UsuarioName
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        [Propiedad(Name = "clave", Tipo = typeof(string), Longitud = 120)]
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        [Propiedad(Name = "fecha_login", Tipo = typeof(DateTime?))]
        public DateTime? FechaLogin
        {
            get { return _fecha_login; }
            set { _fecha_login = value; }
        }

        #endregion

        public event ValidarClaseDelegate ValidacionUsuarioGuardar;
        private static Usuario _usr_sys;
        public static Usuario UsuarioSys
        {
            get
            {
                return _usr_sys;
            }
        }
        public List<Rol> ListadoRoles
        {
            get
            {
                if (_listRolesUsuario == null)
                {
                    _listRolesUsuario = Rol.FindAllStatic("codigo in (select cod_rol from usuario_roles where cod_usuario=" + this.Id.ToString()+")",null);
                }
                return _listRolesUsuario;
            }
        }

        public List<Funcion> ListadoFunciones
        {
            get
            {
                // para cada Rol, incorporar listado de Funciones que implica.
                if (_list_Funciones == null)
                {
                    _list_Funciones = new List<Funcion>();
                    foreach (var rol in this.ListadoRoles)
                    {
                        var lfuncs = rol.ListarFuncionesRol();
                        if( lfuncs !=null)
                        {
                            foreach (var func in lfuncs)
	                        {
                                if(_list_Funciones.Find(ff=>ff.Nombre==func.Nombre)==null)
                                {
                                    _list_Funciones.Add(func);
                                }
	                        }
                        }
                    }
                }
                return _list_Funciones;
            }
        }
        public List<Usuario> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Usuario> FindAll(string criterio)
        {
            return ORMDB<Usuario>.FindAll(criterio);
        }
        public Usuario FindbyKey(params object[] key)
        {
            var usuario = ORMDB<Usuario>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = usuario.Id;
            this.UsuarioName = usuario.UsuarioName;
            this.Clave = usuario.Clave;
            this.FechaLogin = usuario.FechaLogin;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionUsuarioGuardar != null)
                {

                }
            }
            return ORMDB<Usuario>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Usuario
        public static List<Usuario> FindAllStatic(string criterio, Comparison<Usuario> compara)
        {
            var lista = ORMDB<Usuario>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
        public static Usuario FindByKeyStatic(params object[] key)
        {
            return ORMDB<Usuario>.FindbyKey(key);
        }
        public static void FindUsuario(string usuario, string clave)
        {
            List<Usuario> lista = ORMDB<Usuario>.FindAll(String.Format("usuario='{0}' and clave='{1}'",usuario,clave));
            if (lista != null)
            {
                if (lista.Count > 0)
                {
                    Usuario uu = lista[0];
                    uu.FechaLogin = DateTime.Now;
                    uu.SaveObj();
                    _usr_sys = uu;
                    // leer configuracion de permisos, Que Rol y Funcion tiene                    
                    return;
                }
                else
                {
                    lista = ORMDB<Usuario>.FindAll(String.Format("usuario='{0}'", usuario));
                    if (lista != null)
                    {
                        throw new Exception("Error: Clave incorrecta");
                    }
                    else
                        throw new Exception("Error: No existe el usuario");
                }
            }
            else
            {
                // verificar si existe el usuario pero la clave ingresada no es la misma.
                lista = ORMDB<Usuario>.FindAll(String.Format("usuario='{0}'", usuario));
                if (lista != null)
                {
                    throw new Exception("Error: Clave incorrecta");
                }
                else
                    throw new Exception("Error: No existe el usuario");
            }            
        }
        public static bool HasPermiso(string permiso)
        {
            return UsuarioSys.ListadoFunciones.Where(perm => perm.Nombre == permiso).Count() > 0;
        }
    }

}
