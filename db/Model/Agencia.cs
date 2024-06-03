using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurApp.db
{
    [Table(Name = "agencia")]
    public partial class Agencia
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        private string _calle;
        private string _nro;
        private string _piso;
        private int _dpto;
        private int _codigo_postal;
        private string _telefono1;
        private string _telefono2;
        private Localidad _localidad = null;        
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 90)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Propiedad(Name = "calle", Tipo = typeof(string), Longitud = 150)]
        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
        [Propiedad(Name = "nro", Tipo = typeof(string), Longitud = 7)]
        public string Nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [Propiedad(Name = "piso", Tipo = typeof(string), Longitud = 7)]
        public string Piso
        {
            get { return _piso; }
            set { _piso = value; }
        }
        [Propiedad(Name = "dpto", Tipo = typeof(int))]
        public int Dpto
        {
            get { return _dpto; }
            set { _dpto = value; }
        }
        [Propiedad(Name = "codigo_postal", Tipo = typeof(int))]
        public int CodPostal
        {
            get { return _codigo_postal; }
            set { _codigo_postal = value; }
        }
        [Propiedad(Name = "telefono1", Tipo = typeof(string), Longitud = 20)]
        public string Telefono1
        {
            get { return _telefono1; }
            set { _telefono1 = value; }
        }
        [Propiedad(Name = "telefono2", Tipo = typeof(string), Longitud = 20)]
        public string Telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }
        #endregion  
        // -- TODO --
        #region Relaciones con otras entidades

        public Localidad LocalidadObj {
            get {
                if (_localidad == null && this.CodPostal != 0)
                {
                    _localidad = Localidad.FindByKeyStatic(this.CodPostal);
                }
                return _localidad;
            }
        }

        public List<AgenciaTipoPaquete> ListPaquetesAgencia {
            get
            {
                return AgenciaTipoPaquete.FindAllStatic("cod_agencia=" + this.Codigo,null);
            }
        }
        
        #endregion
    }
}
