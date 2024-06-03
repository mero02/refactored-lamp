using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "factura_turista")]
    public partial class FacturaTurista
    {
        #region variables locales
        private int _nro;
        private int _serie;
        private string _letra;
        private DateTime _fecha;
        private int _dniTurista;
        private int _cod_forma_pago;
        private string _detallePago;
        
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "nro", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int Nro
        {
            get { return _nro; }
            set { _nro = value; }
        }

        [Propiedad(Name = "serie", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }
        
        [Propiedad(Name = "letra", Tipo = typeof(string), Longitud = 1, EsClave = true)]
        public string Letra
        {
            get { return _letra; }
            set { _letra = value; }
        }

        [Propiedad(Name = "fecha", Tipo = typeof(DateTime))]
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        [Propiedad(Name = "dni_turista", Tipo = typeof(int))]
        public int DniTurista
        {
            get { return _dniTurista; }
            set { _dniTurista = value; }
        }

        [Propiedad(Name = "cod_forma_pago", Tipo = typeof(int))]
        public int CodFormaPago
        {
            get { return _cod_forma_pago; }
            set { _cod_forma_pago = value; }
        }

        [Propiedad(Name = "det_pago", Tipo = typeof(string), Longitud = 90)]
        public string DetallePago
        {
            get { return _detallePago; }
            set { _detallePago = value; }
        }
        #endregion        
    }

}
