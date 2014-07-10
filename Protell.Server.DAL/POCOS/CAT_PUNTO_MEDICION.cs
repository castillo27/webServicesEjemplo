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
    public partial class CAT_PUNTO_MEDICION
    {
        #region Primitive Properties
    
        public virtual long IdPuntoMedicion
        {
            get;
            set;
        }
    
        public virtual string PuntoMedicionName
        {
            get;
            set;
        }
    
        public virtual long IdUnidadMedida
        {
            get { return _idUnidadMedida; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idUnidadMedida != value)
                    {
                        if (CAT_UNIDAD_MEDIDA != null && CAT_UNIDAD_MEDIDA.IdUnidadMedida != value)
                        {
                            CAT_UNIDAD_MEDIDA = null;
                        }
                        _idUnidadMedida = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private long _idUnidadMedida;
    
        public virtual long IdTipoPuntoMedicion
        {
            get { return _idTipoPuntoMedicion; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idTipoPuntoMedicion != value)
                    {
                        if (CAT_TIPO_PUNTO_MEDICION != null && CAT_TIPO_PUNTO_MEDICION.IdTipoPuntoMedicion != value)
                        {
                            CAT_TIPO_PUNTO_MEDICION = null;
                        }
                        _idTipoPuntoMedicion = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private long _idTipoPuntoMedicion;
    
        public virtual Nullable<double> ValorReferencia
        {
            get;
            set;
        }
    
        public virtual string ParametroReferencia
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
    
        public virtual Nullable<double> latiitud
        {
            get;
            set;
        }
    
        public virtual Nullable<double> longitud
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> vAccion
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> vCondicion
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> Visibility
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdAccionActual
        {
            get { return _idAccionActual; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idAccionActual != value)
                    {
                        if (CAT_ACCION_ACTUAL != null && CAT_ACCION_ACTUAL.IdAccionActual != value)
                        {
                            CAT_ACCION_ACTUAL = null;
                        }
                        _idAccionActual = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idAccionActual;

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<CAT_PROTOCOLO> CAT_PROTOCOLO
        {
            get
            {
                if (_cAT_PROTOCOLO == null)
                {
                    var newCollection = new FixupCollection<CAT_PROTOCOLO>();
                    newCollection.CollectionChanged += FixupCAT_PROTOCOLO;
                    _cAT_PROTOCOLO = newCollection;
                }
                return _cAT_PROTOCOLO;
            }
            set
            {
                if (!ReferenceEquals(_cAT_PROTOCOLO, value))
                {
                    var previousValue = _cAT_PROTOCOLO as FixupCollection<CAT_PROTOCOLO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCAT_PROTOCOLO;
                    }
                    _cAT_PROTOCOLO = value;
                    var newValue = value as FixupCollection<CAT_PROTOCOLO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCAT_PROTOCOLO;
                    }
                }
            }
        }
        private ICollection<CAT_PROTOCOLO> _cAT_PROTOCOLO;
    
        public virtual ICollection<CI_REGISTRO> CI_REGISTRO
        {
            get
            {
                if (_cI_REGISTRO == null)
                {
                    var newCollection = new FixupCollection<CI_REGISTRO>();
                    newCollection.CollectionChanged += FixupCI_REGISTRO;
                    _cI_REGISTRO = newCollection;
                }
                return _cI_REGISTRO;
            }
            set
            {
                if (!ReferenceEquals(_cI_REGISTRO, value))
                {
                    var previousValue = _cI_REGISTRO as FixupCollection<CI_REGISTRO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCI_REGISTRO;
                    }
                    _cI_REGISTRO = value;
                    var newValue = value as FixupCollection<CI_REGISTRO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCI_REGISTRO;
                    }
                }
            }
        }
        private ICollection<CI_REGISTRO> _cI_REGISTRO;
    
        public virtual ICollection<REL_EST_PUNTOMED> REL_EST_PUNTOMED
        {
            get
            {
                if (_rEL_EST_PUNTOMED == null)
                {
                    var newCollection = new FixupCollection<REL_EST_PUNTOMED>();
                    newCollection.CollectionChanged += FixupREL_EST_PUNTOMED;
                    _rEL_EST_PUNTOMED = newCollection;
                }
                return _rEL_EST_PUNTOMED;
            }
            set
            {
                if (!ReferenceEquals(_rEL_EST_PUNTOMED, value))
                {
                    var previousValue = _rEL_EST_PUNTOMED as FixupCollection<REL_EST_PUNTOMED>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_EST_PUNTOMED;
                    }
                    _rEL_EST_PUNTOMED = value;
                    var newValue = value as FixupCollection<REL_EST_PUNTOMED>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_EST_PUNTOMED;
                    }
                }
            }
        }
        private ICollection<REL_EST_PUNTOMED> _rEL_EST_PUNTOMED;
    
        public virtual CAT_TIPO_PUNTO_MEDICION CAT_TIPO_PUNTO_MEDICION
        {
            get { return _cAT_TIPO_PUNTO_MEDICION; }
            set
            {
                if (!ReferenceEquals(_cAT_TIPO_PUNTO_MEDICION, value))
                {
                    var previousValue = _cAT_TIPO_PUNTO_MEDICION;
                    _cAT_TIPO_PUNTO_MEDICION = value;
                    FixupCAT_TIPO_PUNTO_MEDICION(previousValue);
                }
            }
        }
        private CAT_TIPO_PUNTO_MEDICION _cAT_TIPO_PUNTO_MEDICION;
    
        public virtual CAT_UNIDAD_MEDIDA CAT_UNIDAD_MEDIDA
        {
            get { return _cAT_UNIDAD_MEDIDA; }
            set
            {
                if (!ReferenceEquals(_cAT_UNIDAD_MEDIDA, value))
                {
                    var previousValue = _cAT_UNIDAD_MEDIDA;
                    _cAT_UNIDAD_MEDIDA = value;
                    FixupCAT_UNIDAD_MEDIDA(previousValue);
                }
            }
        }
        private CAT_UNIDAD_MEDIDA _cAT_UNIDAD_MEDIDA;
    
        public virtual ICollection<CAT_PUNTO_MEDICION_MAX_MIN> CAT_PUNTO_MEDICION_MAX_MIN
        {
            get
            {
                if (_cAT_PUNTO_MEDICION_MAX_MIN == null)
                {
                    var newCollection = new FixupCollection<CAT_PUNTO_MEDICION_MAX_MIN>();
                    newCollection.CollectionChanged += FixupCAT_PUNTO_MEDICION_MAX_MIN;
                    _cAT_PUNTO_MEDICION_MAX_MIN = newCollection;
                }
                return _cAT_PUNTO_MEDICION_MAX_MIN;
            }
            set
            {
                if (!ReferenceEquals(_cAT_PUNTO_MEDICION_MAX_MIN, value))
                {
                    var previousValue = _cAT_PUNTO_MEDICION_MAX_MIN as FixupCollection<CAT_PUNTO_MEDICION_MAX_MIN>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCAT_PUNTO_MEDICION_MAX_MIN;
                    }
                    _cAT_PUNTO_MEDICION_MAX_MIN = value;
                    var newValue = value as FixupCollection<CAT_PUNTO_MEDICION_MAX_MIN>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCAT_PUNTO_MEDICION_MAX_MIN;
                    }
                }
            }
        }
        private ICollection<CAT_PUNTO_MEDICION_MAX_MIN> _cAT_PUNTO_MEDICION_MAX_MIN;
    
        public virtual CAT_ACCION_ACTUAL CAT_ACCION_ACTUAL
        {
            get { return _cAT_ACCION_ACTUAL; }
            set
            {
                if (!ReferenceEquals(_cAT_ACCION_ACTUAL, value))
                {
                    var previousValue = _cAT_ACCION_ACTUAL;
                    _cAT_ACCION_ACTUAL = value;
                    FixupCAT_ACCION_ACTUAL(previousValue);
                }
            }
        }
        private CAT_ACCION_ACTUAL _cAT_ACCION_ACTUAL;
    
        public virtual ICollection<CAT_PUNTOS_MEDICION_SHORTNAME> CAT_PUNTOS_MEDICION_SHORTNAME
        {
            get
            {
                if (_cAT_PUNTOS_MEDICION_SHORTNAME == null)
                {
                    var newCollection = new FixupCollection<CAT_PUNTOS_MEDICION_SHORTNAME>();
                    newCollection.CollectionChanged += FixupCAT_PUNTOS_MEDICION_SHORTNAME;
                    _cAT_PUNTOS_MEDICION_SHORTNAME = newCollection;
                }
                return _cAT_PUNTOS_MEDICION_SHORTNAME;
            }
            set
            {
                if (!ReferenceEquals(_cAT_PUNTOS_MEDICION_SHORTNAME, value))
                {
                    var previousValue = _cAT_PUNTOS_MEDICION_SHORTNAME as FixupCollection<CAT_PUNTOS_MEDICION_SHORTNAME>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCAT_PUNTOS_MEDICION_SHORTNAME;
                    }
                    _cAT_PUNTOS_MEDICION_SHORTNAME = value;
                    var newValue = value as FixupCollection<CAT_PUNTOS_MEDICION_SHORTNAME>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCAT_PUNTOS_MEDICION_SHORTNAME;
                    }
                }
            }
        }
        private ICollection<CAT_PUNTOS_MEDICION_SHORTNAME> _cAT_PUNTOS_MEDICION_SHORTNAME;
    
        public virtual ICollection<REL_ROL_PUNTOMEDICION> REL_ROL_PUNTOMEDICION
        {
            get
            {
                if (_rEL_ROL_PUNTOMEDICION == null)
                {
                    var newCollection = new FixupCollection<REL_ROL_PUNTOMEDICION>();
                    newCollection.CollectionChanged += FixupREL_ROL_PUNTOMEDICION;
                    _rEL_ROL_PUNTOMEDICION = newCollection;
                }
                return _rEL_ROL_PUNTOMEDICION;
            }
            set
            {
                if (!ReferenceEquals(_rEL_ROL_PUNTOMEDICION, value))
                {
                    var previousValue = _rEL_ROL_PUNTOMEDICION as FixupCollection<REL_ROL_PUNTOMEDICION>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_ROL_PUNTOMEDICION;
                    }
                    _rEL_ROL_PUNTOMEDICION = value;
                    var newValue = value as FixupCollection<REL_ROL_PUNTOMEDICION>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_ROL_PUNTOMEDICION;
                    }
                }
            }
        }
        private ICollection<REL_ROL_PUNTOMEDICION> _rEL_ROL_PUNTOMEDICION;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupCAT_TIPO_PUNTO_MEDICION(CAT_TIPO_PUNTO_MEDICION previousValue)
        {
            if (previousValue != null && previousValue.CAT_PUNTO_MEDICION.Contains(this))
            {
                previousValue.CAT_PUNTO_MEDICION.Remove(this);
            }
    
            if (CAT_TIPO_PUNTO_MEDICION != null)
            {
                if (!CAT_TIPO_PUNTO_MEDICION.CAT_PUNTO_MEDICION.Contains(this))
                {
                    CAT_TIPO_PUNTO_MEDICION.CAT_PUNTO_MEDICION.Add(this);
                }
                if (IdTipoPuntoMedicion != CAT_TIPO_PUNTO_MEDICION.IdTipoPuntoMedicion)
                {
                    IdTipoPuntoMedicion = CAT_TIPO_PUNTO_MEDICION.IdTipoPuntoMedicion;
                }
            }
        }
    
        private void FixupCAT_UNIDAD_MEDIDA(CAT_UNIDAD_MEDIDA previousValue)
        {
            if (previousValue != null && previousValue.CAT_PUNTO_MEDICION.Contains(this))
            {
                previousValue.CAT_PUNTO_MEDICION.Remove(this);
            }
    
            if (CAT_UNIDAD_MEDIDA != null)
            {
                if (!CAT_UNIDAD_MEDIDA.CAT_PUNTO_MEDICION.Contains(this))
                {
                    CAT_UNIDAD_MEDIDA.CAT_PUNTO_MEDICION.Add(this);
                }
                if (IdUnidadMedida != CAT_UNIDAD_MEDIDA.IdUnidadMedida)
                {
                    IdUnidadMedida = CAT_UNIDAD_MEDIDA.IdUnidadMedida;
                }
            }
        }
    
        private void FixupCAT_ACCION_ACTUAL(CAT_ACCION_ACTUAL previousValue)
        {
            if (previousValue != null && previousValue.CAT_PUNTO_MEDICION.Contains(this))
            {
                previousValue.CAT_PUNTO_MEDICION.Remove(this);
            }
    
            if (CAT_ACCION_ACTUAL != null)
            {
                if (!CAT_ACCION_ACTUAL.CAT_PUNTO_MEDICION.Contains(this))
                {
                    CAT_ACCION_ACTUAL.CAT_PUNTO_MEDICION.Add(this);
                }
                if (IdAccionActual != CAT_ACCION_ACTUAL.IdAccionActual)
                {
                    IdAccionActual = CAT_ACCION_ACTUAL.IdAccionActual;
                }
            }
            else if (!_settingFK)
            {
                IdAccionActual = null;
            }
        }
    
        private void FixupCAT_PROTOCOLO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAT_PROTOCOLO item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAT_PROTOCOLO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }
    
        private void FixupCI_REGISTRO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CI_REGISTRO item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CI_REGISTRO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }
    
        private void FixupREL_EST_PUNTOMED(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_EST_PUNTOMED item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_EST_PUNTOMED item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }
    
        private void FixupCAT_PUNTO_MEDICION_MAX_MIN(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAT_PUNTO_MEDICION_MAX_MIN item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAT_PUNTO_MEDICION_MAX_MIN item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }
    
        private void FixupCAT_PUNTOS_MEDICION_SHORTNAME(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CAT_PUNTOS_MEDICION_SHORTNAME item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CAT_PUNTOS_MEDICION_SHORTNAME item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }
    
        private void FixupREL_ROL_PUNTOMEDICION(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_ROL_PUNTOMEDICION item in e.NewItems)
                {
                    item.CAT_PUNTO_MEDICION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_ROL_PUNTOMEDICION item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_PUNTO_MEDICION, this))
                    {
                        item.CAT_PUNTO_MEDICION = null;
                    }
                }
            }
        }

        #endregion

    }
}