using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "usuario_roles")]
    public partial class UsuarioRol : BaseClass, IAccessDB<UsuarioRol>
    {
        #region variables locales
        private int _id;
        private int _cod_usuario;
        private int _cod_rol;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "cod_usuario", Tipo = typeof(int))]
        public int CodUsuario
        {
            get { return _cod_usuario; }
            set { _cod_usuario = value; }
        }

        [Propiedad(Name = "cod_rol", Tipo = typeof(int))]
        public int CodRol
        {
            get { return _cod_rol; }
            set { _cod_rol = value; }
        }

        #endregion

        public event ValidarClaseDelegate ValidacionUsuarioRolGuardar;
        public List<UsuarioRol> FindAll()
        {
            return this.FindAll(null);
        }
        public List<UsuarioRol> FindAll(string criterio)
        {
            return ORMDB<UsuarioRol>.FindAll(criterio);
        }
        public UsuarioRol FindbyKey(params object[] key)
        {
            var usuarioRol = ORMDB<UsuarioRol>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = usuarioRol.Id;
            this.CodUsuario = usuarioRol.CodUsuario;
            this.CodRol = usuarioRol.CodRol;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionUsuarioRolGuardar != null)
                {

                }
            }
            return ORMDB<UsuarioRol>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-UsuarioRol
        public static List<UsuarioRol> FindAllStatic(string criterio, Comparison<UsuarioRol> compara)
        {
            var lista = ORMDB<UsuarioRol>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static UsuarioRol FindByKeyStatic(params object[] key)
        {
            return ORMDB<UsuarioRol>.FindbyKey(key);
        }
    }

}
