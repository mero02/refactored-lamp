using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "tipo_actividad")]
    public partial class TipoActividad
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private string _duracion;
        private int _nivel;
        
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
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

        [Propiedad(Name = "descripcion", Tipo = typeof(string), Longitud = 250)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Propiedad(Name = "duracion", Tipo = typeof(string), Longitud = 250)]
        public string Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        [Propiedad(Name = "nivel", Tipo = typeof(int))]
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        #endregion        
    }

}
