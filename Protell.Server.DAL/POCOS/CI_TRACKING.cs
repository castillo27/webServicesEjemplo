//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Protell.Server.DAL.POCOS
{
    public partial class CI_TRACKING
    {
        #region Primitive Properties
    
        public virtual long IdTracking
        {
            get;
            set;
        }
    
        public virtual string Accion
        {
            get;
            set;
        }
    
        public virtual string Valor
        {
            get;
            set;
        }
    
        public virtual string Ip
        {
            get;
            set;
        }
    
        public virtual string Equipo
        {
            get;
            set;
        }
    
        public virtual string Ubicacion
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdUsuario
        {
            get { return _idUsuario; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idUsuario != value)
                    {
                        if (APP_USUARIO != null && APP_USUARIO.IdUsuario != value)
                        {
                            APP_USUARIO = null;
                        }
                        _idUsuario = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idUsuario;
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<long> LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual long IdPuntoMedicion
        {
            get;
            set;
        }
    
        public virtual long FechaNumerica
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual APP_USUARIO APP_USUARIO
        {
            get { return _aPP_USUARIO; }
            set
            {
                if (!ReferenceEquals(_aPP_USUARIO, value))
                {
                    var previousValue = _aPP_USUARIO;
                    _aPP_USUARIO = value;
                    FixupAPP_USUARIO(previousValue);
                }
            }
        }
        private APP_USUARIO _aPP_USUARIO;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupAPP_USUARIO(APP_USUARIO previousValue)
        {
            if (previousValue != null && previousValue.CI_TRACKING.Contains(this))
            {
                previousValue.CI_TRACKING.Remove(this);
            }
    
            if (APP_USUARIO != null)
            {
                if (!APP_USUARIO.CI_TRACKING.Contains(this))
                {
                    APP_USUARIO.CI_TRACKING.Add(this);
                }
                if (IdUsuario != APP_USUARIO.IdUsuario)
                {
                    IdUsuario = APP_USUARIO.IdUsuario;
                }
            }
            else if (!_settingFK)
            {
                IdUsuario = null;
            }
        }

        #endregion

    }
}