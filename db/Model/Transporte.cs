using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "transporte")]
    public partial class Transporte
    {
        #region variables locales
        private int _Codigo;
        private string _dominio;
        private string _descripcion;
        private float _importe;
            
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [Propiedad(Name = "dominio", Tipo = typeof(string), Longitud = 15)]
        public string Dominio
        {
            get { return _dominio; }
            set { _dominio = value; }
        }

        [Propiedad(Name = "descripcion", Tipo = typeof(string), Longitud = 150)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        #endregion        
    }

}
