using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurApp.db.orm;
using TurApp.db;

namespace TurApp.Views
{
    public enum FrmOperacion
    {
        frmAlta=1,
        frmModificacion=2,
        frmConsulta=3
    };
    public enum TipoOperacionStatus
    {
        stOK =1,
        stError = 2
    }
    public class EventArgDom : EventArgs
    {
        public TipoOperacionStatus Status { get; set; }
        public string Mensaje { get; set; }
        public Object ObjProcess { get; set; }
    }

    // Delegado Generico para poder mandar Mensaje Generico a formulario invocador del form.
    public delegate void FormEvent(object Sender, EventArgDom ev);

    
    public class FormBase: Form
    {
        public static void LoadComboBox(dynamic list, ComboBox cbo, string displayMap="Nombre", string codigoMap="Id" ,  bool addSeleccion = false)
        {
            cbo.DisplayMember = displayMap;
            cbo.ValueMember = codigoMap;
            cbo.DataSource = list;
            cbo.SelectedIndex = -1;            
        }
        // ATENCION...Cada Formulario debe sobreescribir este evento para poder enlazarlo a un metodo handler..  Disparado desde Boton GUARDAR.
        public virtual event FormEvent DoCompleteOperationForm = delegate { }; 
        public virtual FrmOperacion OperacionForm { get; set; }
        public virtual void ConfigurePermiso(PermisoAttribute perm)
        {
            // hay que redefinir en cada Form  para ver los permisos
        }
        private List<Control> ctls = null;
        public virtual void Reload(){}
        public FormBase InvokerForm;
        private PermisoAttribute _perm;
        public FormBase()
        {
            this.Load += new EventHandler(FormBase_Load);            
        }

        public static void SoloConsulta(FormBase frm)
        {
            List<Control> ctls = new List<Control>();
            Button cmdCancelar = null;

            foreach (Control item in frm.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    foreach (Control itm  in (item as GroupBox).Controls)
                    {
                        if(itm.Tag != null && itm.Tag.ToString() != "") 
                        {                            
                            ctls.Add(itm);
                        }
                    }
                }
                else
                {
                    // verificar si posee la metadata asociativa con la clase.
                    if (item.Tag != null && item.Tag.ToString() != "")
                    {
                        ctls.Add(item);
                    }
                    else
                        if (item is Button && item.Name == "CancelarBtn")
                        {
                            item.Text = "Cerrar";
                        }
                            
                }
             }

            foreach (Control item in ctls)
            {
                item.Enabled = false;
            }

        }

        public PermisoAttribute getPermisoObj
        {
            get { return _perm; }
        }

        void FormBase_Load(object sender, EventArgs e)
        {
            var cfgPerm = MetaDataFormBaseClass.ConfigPermisoForm(this.GetType());
            _perm = cfgPerm as PermisoAttribute;
            
            if (cfgPerm != null)
            {
                PermisoAttribute prmInfo = (cfgPerm as PermisoAttribute);
                this.ConfigurePermiso(prmInfo);
            }
        }
        
        public static void ShowDataFromModel(FormBase frm, BaseClass obj)
        {
            var props = MetaDataClass.GetProps(obj.GetType());

            List<Control> ctls = new List<Control>();
            foreach (Control item in frm.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    foreach (Control itm  in (item as GroupBox).Controls)
                    {
                        if (itm.Tag != null && itm.Tag.ToString() != "")
                        {
                            ctls.Add(itm);
                        }   
                    }
                }
                else
                {
                    // verificar si posee la metadata asociativa con la clase.
                    if (item.Tag != null && item.Tag.ToString() != "")
                    {
                        ctls.Add(item);
                    }
                }
             }
            foreach (var prop in props)
            {
                dynamic data="";
                PropiedadAttribute propAt = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute);
                data = prop.GetValue(obj, null);                    
                
                foreach (Control item in ctls)
                {
                     // Tipos de controles: comunes a setear.
                     // TextBox
                     // ComboBox
                     // CheckBox
                     // DatePicker
                    // Verificar Conjunto de datos Mapeados

                    if (item.GetType() == typeof(TextBox))
                    {
                        if(item.Tag.ToString() == prop.Name)
                            (item as TextBox).Text = String.Format("{0}", (data == null?"":data));
                    }
                    if (item.GetType() == typeof(ComboBox))
                    {
                        if (item.Tag.ToString() == prop.Name)
                        {
                            //(item as ComboBox).SelectedIndex = (item as ComboBox).FindString(data.ToString());
                            //(item as ComboBox).SelectedItem = data;
                            (item as ComboBox).SelectedValue = data;
                        }
                    }
                    if (item.GetType() == typeof(DateTimePicker))
                    {
                        if (item.Tag.ToString() == prop.Name)
                          (item as DateTimePicker).Value= data;
                    }
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (item.Tag.ToString() == prop.Name)
                          (item as CheckBox).Checked = data;
                    }
                }    
            }
        }

        public static void ReadDataFromForm(FormBase frm, BaseClass obj)
        {
            var props = MetaDataClass.GetProps(obj.GetType());

            List<Control> ctls = new List<Control>();
            foreach (Control item in frm.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    foreach (Control itm in (item as GroupBox).Controls)
                    {
                        if (itm.Tag != null && itm.Tag.ToString() != "")
                        {
                            ctls.Add(itm);
                        }
                    }
                }
                else
                {
                    // verificar si posee la metadata asociativa con la clase.
                    if (item.Tag != null && item.Tag.ToString() != "")
                    {
                        ctls.Add(item);
                    }
                }
            }
            foreach (var prop in props)
            {
                dynamic data = "";
                PropiedadAttribute propAt = (prop.GetCustomAttributes(typeof(PropiedadAttribute), true)[0] as PropiedadAttribute);
                //data = prop.GetValue(obj, null);

                foreach (Control item in ctls)
                {
                    // Tipos de controles: comunes a setear.
                    // TextBox
                    // ComboBox
                    // CheckBox
                    // DatePicker
                    // Verificar Conjunto de datos Mapeados

                    if (item.GetType() == typeof(TextBox))
                    {
                        if (item.Tag.ToString() == prop.Name)
                        {
                            prop.SetValue(obj, Convert.ChangeType((item as TextBox).Text, prop.PropertyType), null);
                        }
                    }
                    if (item.GetType() == typeof(ComboBox))
                    {
                        if (item.Tag.ToString() == prop.Name)
                        {
                            //(item as ComboBox).SelectedIndex = (item as ComboBox).FindString(data.ToString());
                            //(item as ComboBox).SelectedItem = data;
                            dynamic valor = (item as ComboBox).SelectedValue;
                            dynamic objVal=null;
                            if (typeof(object) == valor.GetType())
                                objVal = (valor as IImpleCodigo).Codigo;
                            else
                                objVal = valor;
                            // verificar si es instancia o el valor---
                            prop.SetValue(obj, Convert.ChangeType(objVal, prop.PropertyType), null);
                        }
                    }
                    if (item.GetType() == typeof(DateTimePicker))
                    {
                        if (item.Tag.ToString() == prop.Name)
                            prop.SetValue(obj, (item as DateTimePicker).Value, null); 
                    }
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if (item.Tag.ToString() == prop.Name)
                            prop.SetValue(obj, (item as CheckBox).Checked, null);                             
                    }
                }
            }
        }
    }
}
