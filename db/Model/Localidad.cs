using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "localidad")]
    public partial class Localidad
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_postal", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 60)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion        
    }

}
