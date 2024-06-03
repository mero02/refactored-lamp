using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurApp.db.orm
{
    public interface IImpleCodigo
    {
        int Codigo { get; }
    }
    public delegate void ValidarClaseDelegate(string mensaje);

    public abstract class BaseClass 
    {        
        private bool _isNew;

        public bool IsNew
        {
            get { return _isNew; }            
        }

        public BaseClass()
        {
            _isNew = true;
        }
        // Metodo invocado al recuperar informacion de la base de datos.
        public void SetIsObjFromDB()
        {
            this._isNew = false; // si esta en false, se trata de un objeto recuperado desde la base de datos
        }
    }
}
