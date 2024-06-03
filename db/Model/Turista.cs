using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurApp.db
{
    [Table(Name = "turista")]
    public partial class Turista
    {
        #region variables locales
        private int _dni;
        private string _nombres;
        private string _domicilio;
        private string _telefono;
        private int _cod_pais;
        private string _observaciones;
        // usado para relacion con la clase Localidad, carga Lazy
        private Pais _pais = null;        
        #endregion        

        #region propiedades publicas

        [Propiedad(Name = "dni", Tipo = typeof(int),EsClave=true)]
        public int NroDocumento
        {
            get { return _dni; }
            set { _dni = value; }
        }
             
        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 90)]
        public string Nombre
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        [Propiedad(Name = "domicilio", Tipo = typeof(string), Longitud = 150)]
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio= value; }
        }

        [Propiedad(Name = "telefono", Tipo = typeof(string), Longitud = 50)]        
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        
        [Propiedad(Name = "cod_pais", Tipo = typeof(int))]
        public int CodPais
        {
            get { return _cod_pais; }
            set {
                if (value != _cod_pais && value > 0)
                    this._pais = null;
                _cod_pais = value;
            }
        }

        [Propiedad(Name = "observaciones", Tipo = typeof(string), Longitud = 200)]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        #endregion  

        #region Relaciones con otras entidades
        public Pais PaisObj
        {
            get {
                if (_pais == null && this.CodPais != 0)
                {
                    _pais = Pais.FindByKeyStatic(this.CodPais);
                }
                return _pais;
            }
        }    
        
        #endregion

    }
}
