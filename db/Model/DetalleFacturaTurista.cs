using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "det_factura_turista")]
    public partial class DetalleFacturaTurista
    {
        #region variables locales
        private int _nro;
        private int _serie;
        private string _letra;
        private int _nro_renglon;
        private int _cod_paquete;
        private float _importe;
                #endregion

        #region propiedades publicas

        [Propiedad(Name = "nro_fact", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int NroFactura
        {
            get { return _nro; }
            set { _nro = value; }
        }

        [Propiedad(Name = "serie_fact", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int SerieFactura
        {
            get { return _serie; }
            set { _serie = value; }
        }

        [Propiedad(Name = "letra_fact", Tipo = typeof(string), Longitud = 1, EsClave = true)]
        public string LetraFactura
        {
            get { return _letra; }
            set { _letra = value; }
        }

        [Propiedad(Name = "nro_renglon", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int NroRenglon
        {
            get { return _nro_renglon; }
            set { _nro_renglon = value; }
        }

        [Propiedad(Name = "cod_paquete", Tipo = typeof(int))]
        public int CodPaquete
        {
            get { return _cod_paquete; }
            set { _cod_paquete = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        #endregion        
        // -- TODO --
        #region Relaciones con otras entidades  
        #endregion
    }

}
