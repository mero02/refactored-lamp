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
            get {
                if (tipo_paquete == null && this.CodTipoPaquete != 0)
                {
                    tipo_paquete = TipoPaquete.FindByKeyStatic(this.CodTipoPaquete);
                }
                return tipo_paquete;
            }
        }

        public TipoActividad TipoActividadObj
        {
            get {
                if (tipo_actividad == null && this.CodTipoActividad != 0) {
                    tipo_actividad = TipoActividad.FindByKeyStatic(this.CodTipoActividad);
                }
                return tipo_actividad;
            }
        }

        #endregion
    }

}
