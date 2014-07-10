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
    public partial class CI_REGISTRO
    {
        #region Primitive Properties
    
        public virtual long IdRegistro
        {
            get;
            set;
        }
    
        public virtual long IdPuntoMedicion
        {
            get { return _idPuntoMedicion; }
            set
            {
                if (_idPuntoMedicion != value)
                {
                    if (CAT_PUNTO_MEDICION != null && CAT_PUNTO_MEDICION.IdPuntoMedicion != value)
                    {
                        CAT_PUNTO_MEDICION = null;
                    }
                    _idPuntoMedicion = value;
                }
            }
        }
        private long _idPuntoMedicion;
    
        public virtual System.DateTime FechaCaptura
        {
            get;
            set;
        }
    
        public virtual int HoraRegistro
        {
            get;
            set;
        }
    
        public virtual int DiaRegistro
        {
            get;
            set;
        }
    
        public virtual double Valor
        {
            get;
            set;
        }
    
        public virtual string AccionActual
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual bool IsModified
        {
            get;
            set;
        }
    
        public virtual long LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual long IdCondicion
        {
            get { return _idCondicion; }
            set
            {
                if (_idCondicion != value)
                {
                    if (CAT_CONDPRO != null && CAT_CONDPRO.IdCondicion != value)
                    {
                        CAT_CONDPRO = null;
                    }
                    _idCondicion = value;
                }
            }
        }
        private long _idCondicion;
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<long> FechaNumerica
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual CAT_CONDPRO CAT_CONDPRO
        {
            get { return _cAT_CONDPRO; }
            set
            {
                if (!ReferenceEquals(_cAT_CONDPRO, value))
                {
                    var previousValue = _cAT_CONDPRO;
                    _cAT_CONDPRO = value;
                    FixupCAT_CONDPRO(previousValue);
                }
            }
        }
        private CAT_CONDPRO _cAT_CONDPRO;
    
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
    
        private void FixupCAT_CONDPRO(CAT_CONDPRO previousValue)
        {
            if (previousValue != null && previousValue.CI_REGISTRO.Contains(this))
            {
                previousValue.CI_REGISTRO.Remove(this);
            }
    
            if (CAT_CONDPRO != null)
            {
                if (!CAT_CONDPRO.CI_REGISTRO.Contains(this))
                {
                    CAT_CONDPRO.CI_REGISTRO.Add(this);
                }
                if (IdCondicion != CAT_CONDPRO.IdCondicion)
                {
                    IdCondicion = CAT_CONDPRO.IdCondicion;
                }
            }
        }
    
        private void FixupCAT_PUNTO_MEDICION(CAT_PUNTO_MEDICION previousValue)
        {
            if (previousValue != null && previousValue.CI_REGISTRO.Contains(this))
            {
                previousValue.CI_REGISTRO.Remove(this);
            }
    
            if (CAT_PUNTO_MEDICION != null)
            {
                if (!CAT_PUNTO_MEDICION.CI_REGISTRO.Contains(this))
                {
                    CAT_PUNTO_MEDICION.CI_REGISTRO.Add(this);
                }
                if (IdPuntoMedicion != CAT_PUNTO_MEDICION.IdPuntoMedicion)
                {
                    IdPuntoMedicion = CAT_PUNTO_MEDICION.IdPuntoMedicion;
                }
            }
        }

        #endregion

    }
}
