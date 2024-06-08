using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "paquete")]
    public partial class Paquete
    {
        #region variables locales
        private int _Codigo;
        private int _cod_tipo_paquete;
        private int _cod_agencia;
        private DateTime _fecha;
        private int _nivel;
        private int _dniTurista;
        private int _cod_destino;
        //instancias internas de destino, tipo paquete, turista, agencia

        private Turista _turista = null;
        private TipoPaquete _tipoPaquete = null;
        private Agencia _agencia = null;
        private Destino _destino = null;

        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int))]
        public int CodTipoPaquete
        {
            get { return _cod_tipo_paquete; }
            set { _cod_tipo_paquete = value; }
        }

        [Propiedad(Name = "cod_agencia", Tipo = typeof(int))]
        public int CodAgencia
        {
            get { return _cod_agencia; }
            set { _cod_agencia = value; }
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

        [Propiedad(Name = "nivel", Tipo = typeof(int))]
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        [Propiedad(Name = "cod_destino", Tipo = typeof(int))]
        public int CodDestino
        {
            get { return _cod_destino; }
            set { _cod_destino = value; }
        }
        #endregion        

        // -- TODO --
        #region Relaciones con otras entidades

        public TipoPaquete TipoPaqueteObj
        {
            get
            {
                if (_tipoPaquete == null && this.CodTipoPaquete != 0)
                {
                    _tipoPaquete = TipoPaquete.FindByKeyStatic(this.CodTipoPaquete);
                }
                return _tipoPaquete;
            }
        }

        public Agencia AgenciaObj
        {
            get
            {
                if (_agencia == null && this.CodAgencia != 0)
                {
                    _agencia = Agencia.FindByKeyStatic(this.CodAgencia);
                }
                return _agencia;
            }
        }

        public Destino DestinoObj
        {
            get
            {
                if (_destino == null && this.CodDestino != 0)
                {
                    _destino = Destino.FindByKeyStatic(this.CodDestino);
                }
                return _destino;
            }
        }

        public Turista TuristaObj
        {
            get
            {
                if (_turista == null && this.DniTurista != 0)
                {
                    _turista = Turista.FindByKeyStatic(this.DniTurista);
                }
                return _turista;
            }
        }

        #endregion
    }

}
