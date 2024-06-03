using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    public partial class DetalleFacturaTurista : BaseClass, IAccessDB<DetalleFacturaTurista>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionDetalleFacturaTuristaGuardar;
        public List<DetalleFacturaTurista> FindAll()
        {
            return this.FindAll(null);
        }
        public List<DetalleFacturaTurista> FindAll(string criterio)
        {
            return ORMDB<DetalleFacturaTurista>.FindAll(criterio); 
        }
        public DetalleFacturaTurista FindbyKey(params object[] key)
        {
            var fac = ORMDB<DetalleFacturaTurista>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroFactura = fac.NroFactura;
            this.SerieFactura = fac.SerieFactura;
            this.LetraFactura = fac.LetraFactura;
            this.CodPaquete= fac.CodPaquete;
            this.Importe = fac.Importe;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionDetalleFacturaTuristaGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    
                }
            }
            return ORMDB<DetalleFacturaTurista>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-DetalleFacturaTurista
        public static List<DetalleFacturaTurista> FindAllStatic(string criterio, Comparison<DetalleFacturaTurista> compara)
        {
            var lista = ORMDB<DetalleFacturaTurista>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static DetalleFacturaTurista FindByKeyStatic(params object[] key)
        {
            return ORMDB<DetalleFacturaTurista>.FindbyKey(key);
        }
    }
}
