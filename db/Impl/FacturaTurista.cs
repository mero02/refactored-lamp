using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class FacturaTurista : BaseClass, IAccessDB<FacturaTurista>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionFacturaTuristaGuardar;
        public List<FacturaTurista> FindAll()
        {
            return this.FindAll(null);
        }
        public List<FacturaTurista> FindAll(string criterio)
        {
            return ORMDB<FacturaTurista>.FindAll(criterio); 
        }
        public FacturaTurista FindbyKey(params object[] key)
        {
            var fac = ORMDB<FacturaTurista>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Nro = fac.Nro;
            this.Serie = fac.Serie;
            this.Letra = fac.Letra;
            this.Fecha = fac.Fecha;
            this.DniTurista = fac.DniTurista;
            this.DetallePago = fac.DetallePago;
            this.CodFormaPago = fac.CodFormaPago;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionFacturaTuristaGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    
                }
            }
            return ORMDB<FacturaTurista>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-FacturaTurista
        public static List<FacturaTurista> FindAllStatic(string criterio, Comparison<FacturaTurista> compara)
        {
            var lista = ORMDB<FacturaTurista>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static FacturaTurista FindByKeyStatic(params object[] key)
        {
            return ORMDB<FacturaTurista>.FindbyKey(key);
        }
    }
}
