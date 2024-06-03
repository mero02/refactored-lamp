using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurApp.db.orm;

namespace TurApp.db
{
    // ICOmparable
    public partial class Turista : BaseClass, IAccessDB<Turista>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTuristaGuardar;
        public List<Turista> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Turista> FindAll(string criterio)
        {
            return ORMDB<Turista>.FindAll(criterio); 
        }
        public Turista FindbyKey(params object[] key)
        {
            var tur = ORMDB<Turista>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = tur.NroDocumento;
            this.Nombre = tur.Nombre;
            this.Domicilio = tur.Domicilio;
            this.Telefono = tur.Telefono;
            this.CodPais = tur.CodPais;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTuristaGuardar != null)
                {
                    // Validaciones de los datos que deben estar cargados para tener una tupla de datos valida
                    if(Nombre == "" )
                        ValidacionTuristaGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Turista>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Turista
        public static List<Turista> FindAllStatic(string criterio, Comparison<Turista> compara)
        {
            var lista = ORMDB<Turista>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Turista FindByKeyStatic(params object[] key)
        {
            return ORMDB<Turista>.FindbyKey(key);
        }
    }
}
