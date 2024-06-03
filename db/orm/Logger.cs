using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TurApp.db.orm;

namespace TurApp.db
{
    [Table(Name = "logger")]
    public partial class Logger : BaseClass, IAccessDB<Logger>
    {
        #region variables locales
        private int _id;
        private string _usuario;
        private string _objeto;
        private string _operacion;
        private DateTime _fecha;
        private string _detalle;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "id", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "usuario", Tipo = typeof(string), Longitud = 90)]
        public string UsuarioName
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        [Propiedad(Name = "objeto", Tipo = typeof(string), Longitud = 80)]
        public string Objeto 
        {
            get { return _objeto; }
            set { _objeto = value; }
        }

        [Propiedad(Name = "fecha", Tipo = typeof(DateTime))]
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        [Propiedad(Name = "operacion", Tipo = typeof(string), Longitud = 80)]
        public string Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }
        }

        [Propiedad(Name = "detalle", Tipo = typeof(string), Longitud = 8000)]
        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }
        #endregion

        public event ValidarClaseDelegate ValidacionLoggerGuardar;
        /*
        private static Logger _logger_sys=new Logger();
        public static Logger LoggerSys
        {
            get
            {
                return _logger_sys;
            }
        }*/
        public List<Logger> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Logger> FindAll(string criterio)
        {
            return ORMDB<Logger>.FindAll(criterio);
        }
        public Logger FindbyKey(params object[] key)
        {
            var logData = ORMDB<Logger>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = logData.Id;
            this.UsuarioName = logData.UsuarioName;
            this.Detalle = logData.Detalle;
            this.Objeto = logData.Objeto;
            this.Operacion = logData.Operacion;
            this.Fecha = logData.Fecha;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionLoggerGuardar != null)
                {

                }
            }
            return ORMDB<Logger>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Logger
        public static List<Logger> FindAllStatic(string criterio, Comparison<Logger> compara)
        {
            var lista = ORMDB<Logger>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }
        public static Logger FindByKeyStatic(params object[] key)
        {
            return ORMDB<Logger>.FindbyKey(key);
        }

        public static void SaveLog(string operacion, string objeto,string detalle)
        {
            Logger log = new Logger { UsuarioName = Usuario.UsuarioSys.UsuarioName, Fecha = DateTime.Now, Operacion = operacion, Objeto = objeto, Detalle = detalle };
            log.SaveObj();
        }
    }
}
