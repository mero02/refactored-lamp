using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "tipo_paquete_tipo_actividad")]
    public partial class TipoPaqueteTipoActividad
    {
        #region variables locales
        private int _CodTipoPaquete;
        private int _CodTipoActividad;
        private TipoPaquete tipo_paquete = null;
        private TipoActividad tipo_actividad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoPaquete
        {
            get { return _CodTipoPaquete; }
            set { _CodTipoPaquete = value; }
        }

        [Propiedad(Name = "cod_tipo_actividad", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoActividad
        {
            get { return _CodTipoActividad; }
            set { _CodTipoActividad = value; }
        }
        #endregion     
       
        // -- TODO --        
        #region Relaciones con otras entidades
        public TipoPaquete TipoPaqueteObj
        {
            get { throw new NotImplementedException(); }
        }

        public TipoActividad TipoActividadObj
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }

}
