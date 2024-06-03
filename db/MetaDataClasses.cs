using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    // Reflection para obtener metadata del mapeo con la Base de datos.
    public class PropiedadAttribute : Attribute
    {
        private Type _tipo;
        public PropiedadAttribute()
        {
            this.EsClave = false;
            this.EsNullable = false;
            this.EsAutoGenerado = false;
            this.Longitud = 0;
        }
        public string Name { get; set; }
        public Type Tipo { get { return _tipo; } 
            set {
                if (value == typeof(DateTime))
                    this.Format = "yyyy-M-d hh:m:ss";
                _tipo = value; } }
        public bool EsClave { get; set; }
        public bool EsAutoGenerado { get; set; }
        public int Longitud { get; set; }
        public bool EsNullable { get; set; }
        public string Format { get; set; } 
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
        public Type Tipo { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    public class MetaDataClass
    {
        // Obtencion de Metadata: Nombre de la Tabla
        public static object GetTable(Type clase)
        {
            return Attribute.GetCustomAttribute(clase, typeof(TableAttribute));
        }
        // Obtencion de la metadata de la clase, Los atributos mapeados a las columna de la tabla.
        public static List<PropertyInfo> GetProps(Type clase, bool? keyColumns = null)
        {
            if (keyColumns == null)
                return clase.GetProperties().Where(pp => Attribute.IsDefined(pp, typeof(PropiedadAttribute))).ToList();
            return clase.GetProperties().Where(pp => Attribute.IsDefined(pp, typeof(PropiedadAttribute)) && (pp.GetCustomAttributes(false).ToList()[0] as PropiedadAttribute).EsClave == keyColumns).ToList();
            //return clase.GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(PropiedadAttribute))).ToList();
        }
        // Obtencion de la lista de Columnas no Clave de la tabla: usado para el insert, update en SaveObject       

    }

    public class PermisoAttribute : Attribute
    {
        private bool _hasAddPerm = false;
        private bool _hasUpdPerm = false;
        private bool _hasViewPerm = false;
        public void setPermInfo(bool valHasAdd, bool valHasUpd, bool valHasView)
        {
            _hasAddPerm = valHasAdd;
            _hasUpdPerm = valHasUpd;
            _hasViewPerm = valHasView;
        }
        
        public string FuncionPermiso { get; set; }
        public string RolUsuario { get; set; }
        public string ClaseBaseForm { get; set; }
        public bool HasAddPerm { get { return _hasAddPerm; } }
        public bool HasUpdPerm { get { return _hasUpdPerm; } }
        public bool HasViewPerm { get { return _hasViewPerm; } }
    }

    public class MetaDataFormBaseClass
    {
        // Obtencion de Metadata: Permisos y Roles para 
        public static object ConfigPermisoForm(Type clase)
        {
            PermisoAttribute permRet = new PermisoAttribute();
            var prm = Attribute.GetCustomAttribute(clase, typeof(PermisoAttribute));
            if(prm!=null)
            {
                permRet = prm as PermisoAttribute;
                bool consulta=false,agrega=false,modifica=false;
                string[] listFunciones = permRet.FuncionPermiso.Split(',');
                string consultaFunc = null, agregaFunc = null, modificaFunc=null;
                
                // ver si puede consultar.
                if(listFunciones.Where(p=>p.IndexOf("Consulta" + permRet.ClaseBaseForm)!=-1).Count()>0)
                    consultaFunc = listFunciones.Where(p=>p.IndexOf("Consulta" + permRet.ClaseBaseForm)!=-1).FirstOrDefault();
                
                if(consultaFunc!=null)
                    consulta = Usuario.UsuarioSys.ListadoFunciones.Find(fc => fc.Nombre == consultaFunc) != null;

                if (listFunciones.Where(p => p.IndexOf("Alta" + permRet.ClaseBaseForm) != -1).Count() > 0)
                    agregaFunc = listFunciones.Where(p => p.IndexOf("Alta" + permRet.ClaseBaseForm) != -1).FirstOrDefault();
                
                if (agregaFunc != null)
                    agrega = Usuario.UsuarioSys.ListadoFunciones.Find(fc => fc.Nombre == agregaFunc) != null;

                if (listFunciones.Where(p => p.IndexOf("Modifica" + permRet.ClaseBaseForm) != -1).Count() > 0)
                    modificaFunc = listFunciones.Where(p => p.IndexOf("Modifica" + permRet.ClaseBaseForm) != -1).FirstOrDefault();
                
                if (modificaFunc != null)
                    modifica = Usuario.UsuarioSys.ListadoFunciones.Find(fc => fc.Nombre == modificaFunc) != null; 

                permRet.setPermInfo(agrega, modifica, consulta);
                // si tiene Permiso de                 
                return permRet;
            }
            return permRet;
        }        
    }
}
