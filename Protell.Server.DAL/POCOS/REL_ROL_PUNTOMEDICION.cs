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
    public partial class REL_ROL_PUNTOMEDICION
    {
        #region Primitive Properties
    
        public virtual long IdRel
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdRol
        {
            get { return _idRol; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idRol != value)
                    {
                        if (APP_ROL != null && APP_ROL.IdRol != value)
                        {
                            APP_ROL = null;
                        }
                        _idRol = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idRol;
    
        public virtual Nullable<long> IdPuntoMedicion
        {
            get { return _idPuntoMedicion; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idPuntoMedicion != value)
                    {
                        if (CAT_PUNTO_MEDICION != null && CAT_PUNTO_MEDICION.IdPuntoMedicion != value)
                        {
                            CAT_PUNTO_MEDICION = null;
                        }
                        _idPuntoMedicion = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idPuntoMedicion;
    
        public virtual Nullable<bool> IsActive
        {
            get;
            set;
        }
    
        public virtual Nullable<long> LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual APP_ROL APP_ROL
        {
            get { return _aPP_ROL; }
            set
            {
                if (!ReferenceEquals(_aPP_ROL, value))
                {
                    var previousValue = _aPP_ROL;
                    _aPP_ROL = value;
                    FixupAPP_ROL(previousValue);
                }
            }
        }
        private APP_ROL _aPP_ROL;
    
        public virtual CAT_PUNTO_MEDICION CAT_PUNTO_MEDICION
        {
            get { return _cAT_PUNTO_MEDICION; }
            set
            {
                if (!ReferenceEquals(_cAT_PUNTO_MEDICION, value))
                {
                    var previousValue = _cAT_PUNTO_MEDICION;
                    _cAT_PUNTO_MEDICION = value;
                    FixupCAT_PUNTO_MEDICION(previousValue);
                }
            }
        }
        private CAT_PUNTO_MEDICION _cAT_PUNTO_MEDICION;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupAPP_ROL(APP_ROL previousValue)
        {
            if (previousValue != null && previousValue.REL_ROL_PUNTOMEDICION.Contains(this))
            {
                previousValue.REL_ROL_PUNTOMEDICION.Remove(this);
            }
    
            if (APP_ROL != null)
            {
                if (!APP_ROL.REL_ROL_PUNTOMEDICION.Contains(this))
                {
                    APP_ROL.REL_ROL_PUNTOMEDICION.Add(this);
                }
                if (IdRol != APP_ROL.IdRol)
                {
                    IdRol = APP_ROL.IdRol;
                }
            }
            else if (!_settingFK)
            {
                IdRol = null;
            }
        }
    
        private void FixupCAT_PUNTO_MEDICION(CAT_PUNTO_MEDICION previousValue)
        {
            if (previousValue != null && previousValue.REL_ROL_PUNTOMEDICION.Contains(this))
            {
                previousValue.REL_ROL_PUNTOMEDICION.Remove(this);
            }
    
            if (CAT_PUNTO_MEDICION != null)
            {
                if (!CAT_PUNTO_MEDICION.REL_ROL_PUNTOMEDICION.Contains(this))
                {
                    CAT_PUNTO_MEDICION.REL_ROL_PUNTOMEDICION.Add(this);
                }
                if (IdPuntoMedicion != CAT_PUNTO_MEDICION.IdPuntoMedicion)
                {
                    IdPuntoMedicion = CAT_PUNTO_MEDICION.IdPuntoMedicion;
                }
            }
            else if (!_settingFK)
            {
                IdPuntoMedicion = null;
            }
        }

        #endregion

    }
}