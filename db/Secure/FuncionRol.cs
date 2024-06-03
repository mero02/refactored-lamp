using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "funciones_rol")]
    public partial class FuncionRol : BaseClass, IAccessDB<FuncionRol>
    {
        #region variables locales
        private int _id;
        private int _cod_funcion;
        private int _cod_rol;
        private bool _puede;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "cod_funcion", Tipo = typeof(int))]
        public int CodFuncion
        {
            get { return _cod_funcion; }
            set { _cod_funcion = value; }
        }

        [Propiedad(Name = "cod_rol", Tipo = typeof(int))]
        public int CodRol
        {
            get { return _cod_rol; }
            set { _cod_rol = value; }
        }

        [Propiedad(Name = "puede", Tipo = typeof(bool))]
        public bool Puede
        {
            get { return _puede; }
            set { _puede = value; }
        }

        #endregion

        public event ValidarClaseDelegate ValidacionFuncionRolGuardar;
        public List<FuncionRol> FindAll()
        {
            return this.FindAll(null);
        }
        public List<FuncionRol> FindAll(string criterio)
        {
            return ORMDB<FuncionRol>.FindAll(criterio);
        }
        public FuncionRol FindbyKey(params object[] key)
        {
            var funcRol = ORMDB<FuncionRol>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = funcRol.Id;
            this.CodFuncion = funcRol.CodFuncion;
            this.CodRol = funcRol.CodRol;
            this.Puede = funcRol.Puede;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionFuncionRolGuardar != null)
                {
                    
                }
            }
            return ORMDB<FuncionRol>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-FuncionRol
        public static List<FuncionRol> FindAllStatic(string criterio, Comparison<FuncionRol> compara)
        {
            var lista = ORMDB<FuncionRol>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static FuncionRol FindByKeyStatic(params object[] key)
        {
            return ORMDB<FuncionRol>.FindbyKey(key);
        }
    }

}
