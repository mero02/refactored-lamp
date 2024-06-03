using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "destino")]
    public partial class Destino
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 120)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Propiedad(Name = "descripcion", Tipo = typeof(string), Longitud = 250)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion        
    }

}
