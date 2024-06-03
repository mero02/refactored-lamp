using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "paquete_actividad")]
    public partial class PaqueteActividad
    {
        #region variables locales
        private int _cod_paquete;
        private int _cod_actividad;
        private float _importe;
        private DateTime _fecha_hora_desde;
        private DateTime _fecha_hora_hasta;
        private string _detalle;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_paquete", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodPaquete
        {
            get { return _cod_paquete; }
            set { _cod_paquete = value; }
        }

        [Propiedad(Name = "cod_actividad", Tipo = typeof(int))]
        public int CodActividad
        {
            get { return _cod_actividad; }
            set { _cod_actividad = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        [Propiedad(Name = "fecha_hora_desde", Tipo = typeof(DateTime))]
        public DateTime FechaHoraDesde
        {
            get { return _fecha_hora_desde; }
            set { _fecha_hora_desde = value; }
        }

        [Propiedad(Name = "fecha_hora_hasta", Tipo = typeof(DateTime))]
        public DateTime FechaHoraHasta
        {
            get { return _fecha_hora_hasta; }
            set { _fecha_hora_hasta = value; }
        }

        [Propiedad(Name = "detalle", Tipo = typeof(string), Longitud = 120)]
        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }
        
        
        #endregion        

        // -- TODO --
        #region Relaciones con otras entidades
        #endregion
    }

}
