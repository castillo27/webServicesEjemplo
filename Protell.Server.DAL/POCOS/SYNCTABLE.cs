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
    public partial class SYNCTABLE
    {
        #region Primitive Properties
    
        public virtual long IdSyncTable
        {
            get;
            set;
        }
    
        public virtual string SyncTableName
        {
            get;
            set;
        }
    
        public virtual Nullable<int> OrderTable
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<MODIFIEDDATA> MODIFIEDDATAs
        {
            get
            {
                if (_mODIFIEDDATAs == null)
                {
                    var newCollection = new FixupCollection<MODIFIEDDATA>();
                    newCollection.CollectionChanged += FixupMODIFIEDDATAs;
                    _mODIFIEDDATAs = newCollection;
                }
                return _mODIFIEDDATAs;
            }
            set
            {
                if (!ReferenceEquals(_mODIFIEDDATAs, value))
                {
                    var previousValue = _mODIFIEDDATAs as FixupCollection<MODIFIEDDATA>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupMODIFIEDDATAs;
                    }
                    _mODIFIEDDATAs = value;
                    var newValue = value as FixupCollection<MODIFIEDDATA>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupMODIFIEDDATAs;
                    }
                }
            }
        }
        private ICollection<MODIFIEDDATA> _mODIFIEDDATAs;

        #endregion

        #region Association Fixup
    
        private void FixupMODIFIEDDATAs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (MODIFIEDDATA item in e.NewItems)
                {
                    item.SYNCTABLE = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MODIFIEDDATA item in e.OldItems)
                {
                    if (ReferenceEquals(item.SYNCTABLE, this))
                    {
                        item.SYNCTABLE = null;
                    }
                }
            }
        }

        #endregion

    }
}
