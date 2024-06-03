using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Reflection;
using TurApp.db.orm;
using TurApp.db;

namespace TurApp.db
{
    /*
     Clase de Uso Generica segun el tipo pasado por parametros. Consume informacion de metadata de la clase para armar las cadenas SQL.
     */
    public class ORMDB<T> where T : BaseClass , new()
    {
        
        public static List<T> FindAll(string criteria)
        {
            Type clase = typeof(T);
            // Obtener conjunto de atributos publicos de la clase para generar el listado de campos con los cuales se mapea la clase.
            var props = MetaDataClass.GetProps(clase);
            
            List<T> lista =  new List<T>();
            DataTable dt = AccessDB.GetExecuteSQL(
                String.Format(
                    "select {0} from {1} {2};",
                    // listado de nombre de columnas - Obtenido desde la metadata de los atributos publicos de la clase
                    String.Join(",",props.Select(pp => pp.GetCustomAttributes(typeof(PropiedadAttribute), true)[0])),
                    // nombre de la tabla - Obtenido desde la metadata de la clase
                    MetaDataClass.GetTable(clase),
                    (criteria==null? "" : String.Format(" where {0}",criteria))
                    )
             ); 
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    T obj = new T();
                     // Para cada propiedad customizada con metadata, inicializar con datos obtenidos desde la Base.
                    foreach (PropertyInfo prop in props)
                    {
                        string propName = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute).Name;
                        Type t = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                        object safeValue = (dt.Rows[i][propName] == DBNull.Value) ? null : Convert.ChangeType(dt.Rows[i][propName], t);

                        prop.SetValue(obj, safeValue, null);                        
                        
                    }
                    obj.SetIsObjFromDB();
                    
                    lista.Add(obj);
                }
            }            
            return lista;
        }
        public static T FindbyKey(params object[] key)
        {
            // corregir para que tome el id especificado en los atributos de la propiedad clave
            // Determinar la columna Clave para poder generar el Query con el Id correcto
            string colKey = "";
            Type clase = typeof(T);
            var props = MetaDataClass.GetProps(clase);
            foreach (var prop in props)
                {
                    PropiedadAttribute propAt = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute);
                    if (propAt.EsClave)
                    {
                        colKey = propAt.Name;
                        break;
                    }
                 }

            List<T> listObj = FindAll(String.Format("{0}={1}", colKey,key.GetValue(0)));
            if (listObj == null)
            {
                return null;
            }
            else
                if (listObj.Count == 0)
                    return null;
            return listObj[0];
        }
        public static bool SaveObject(T obj)
        {
            string sql = "";
            var clase  = typeof(T);
            var props = MetaDataClass.GetProps(clase);
            //var propKey = MetaDataClass.GetProps(clase, true);
            var table = MetaDataClass.GetTable(clase);
            bool KeyAutoGen = false;
            string whereCondicion="";
            string propKey = "";
            List<string> listValues = new List<string>();
            if (obj.IsNew)
            {                
                foreach (var prop in props)
                {
                    PropiedadAttribute propAt = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute);
                    if (!propAt.EsClave)
                    {
                        // se divide por tipo ya que los datos se deben configurar de forma diferente en cadena sql.
                        // campos string y date llevan delimitadores: '
                        // campos Datetime pueden tener formato, con y sin hora.
                        // los campos e tipo numericos no necesitan delimitadores, los valores con decimal se separan con .

                        if (propAt.Tipo == typeof(string))
                            listValues.Add(String.Format("'{0}'", prop.GetValue(obj, null)));
                        if (propAt.Tipo == typeof(DateTime) || propAt.Tipo == typeof(DateTime?))
                        {
                            if(propAt.Format.IndexOf("HH")!=-1)
                                listValues.Add(String.Format("TO_TIMESTAMP('{0}','{1}')", Convert.ToDateTime(prop.GetValue(obj, null)).ToString(propAt.Format), "HH24:MI:SS"));
                            else
                                listValues.Add(String.Format("'{0}'", Convert.ToDateTime(prop.GetValue(obj, null)).ToString(propAt.Format)));
                        }
                        if (propAt.Tipo == typeof(int) || prop.GetType() == typeof(long) || prop.GetType() == typeof(short))
                            listValues.Add(String.Format("{0}", prop.GetValue(obj, null)));
                        if (propAt.Tipo == typeof(float) || prop.GetType() == typeof(double) || prop.GetType() == typeof(decimal))
                            listValues.Add(String.Format("{0:F2}", prop.GetValue(obj, null)).Replace(",", "."));
                        if (propAt.Tipo == typeof(bool))
                            listValues.Add(String.Format("{0}", prop.GetValue(obj, null)));
                    }
                    else
                    {
                        propKey = propAt.Name;
                        if (propAt.EsAutoGenerado)
                        {
                            KeyAutoGen = true;
                            listValues.Add(String.Format("coalesce((select max({0})+1 from {1}),1)", propAt.Name, table));
                        }
                        else
                            listValues.Add(String.Format("{0}", prop.GetValue(obj, null)));
                        
                    }
                }
                // generar cadena sql insert, considerar metadata
                if(KeyAutoGen)
                    sql = String.Format("insert into {0} ({1}) values ({2}) RETURNING {3};", table, String.Join(",", props.Select(pd => (pd.GetCustomAttributes(false)[0] as PropiedadAttribute).Name).ToList()), String.Join(",", listValues), propKey);
                else
                    sql = String.Format("insert into {0} ({1}) values ({2});", table, String.Join(",", props.Select(pd => (pd.GetCustomAttributes(false)[0] as PropiedadAttribute).Name).ToList()), String.Join(",", listValues));
                sql = sql.Replace("'0001-00-01'", "null");
                // verificar en la insercion que se devuelva dato: Id de la nueva tupla para guardar en la instancia.
            }
            else
            {
                // Se debe actualizar campos no clave, y algunos campos.  
                foreach (var prop in props)
                {
                    PropiedadAttribute propAt = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute);
                    // cadena Set 
                    if (!propAt.EsClave)
                    {
                        if (propAt.Tipo == typeof(string))
                            listValues.Add(String.Format("{0}='{1}'", propAt.Name, prop.GetValue(obj, null)));
                        if (propAt.Tipo == typeof(DateTime))
                            listValues.Add(String.Format("{0}='{1}'", propAt.Name, Convert.ToDateTime(prop.GetValue(obj, null)).ToString(propAt.Format)));
                        if (propAt.Tipo == typeof(int) || prop.GetType() == typeof(long) || prop.GetType() == typeof(short))
                            listValues.Add(String.Format("{0}={1}", propAt.Name, prop.GetValue(obj, null)));
                        if (propAt.Tipo == typeof(float) || prop.GetType() == typeof(double) || prop.GetType() == typeof(decimal))
                            listValues.Add(String.Format("{0}={1:F2}", propAt.Name, prop.GetValue(obj, null)).Replace(",", "."));
                        if (propAt.Tipo == typeof(bool))
                            listValues.Add(String.Format("{0}={1}", propAt.Name, prop.GetValue(obj, null)));
                    }
                    else
                    { // Armar condicion Where, solo se considera clave numerica. Adaptar si la clave fuese no Numerica.
                        whereCondicion = String.Format("{0} = {1}", propAt.Name, prop.GetValue(obj, null));
                    }
                }
                sql = String.Format("update {0} set {1} where {2}", table, String.Join(",", listValues), whereCondicion);
                // generar cadena sql de update, considerar metadata
            }
            // ejecutar sql 
            DataTable dt = AccessDB.GetExecuteSQL(sql);
            // aplicar a clases auditables, si implementa la interface registrar la informacion en la tabla de Auditoria
            if (obj is IAuditable)
            {
                IAuditable IObj = obj as IAuditable;
                // Registro de auditoria de la clase.
                //Logger.Log();
            }
            if (obj.IsNew && KeyAutoGen)
                props[0].SetValue(obj, Convert.ChangeType(dt.Rows[0][propKey], props[0].PropertyType), null);
            obj.SetIsObjFromDB();
 
            return true;
        }
    }    
}
