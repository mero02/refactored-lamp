using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "forma_pago")]
    public partial class FormaPago
    {
        #region variables locales
        private int _codigo;
        private string _forma;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "forma", Tipo = typeof(string), Longitud = 50)]
        public string Forma
        {
            get { return _forma; }
            set { _forma = value; }
        }
        #endregion        
    }

}
