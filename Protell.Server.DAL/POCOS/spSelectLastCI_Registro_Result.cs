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
    public partial class spSelectLastCI_Registro_Result
    {
        #region Primitive Properties
    
        public long IdRegistro
        {
            get;
            set;
        }
    
        public long IdPuntoMedicion
        {
            get;
            set;
        }
    
        public System.DateTime FechaCaptura
        {
            get;
            set;
        }
    
        public int HoraRegistro
        {
            get;
            set;
        }
    
        public int DiaRegistro
        {
            get;
            set;
        }
    
        public double Valor
        {
            get;
            set;
        }
    
        public string AccionActual
        {
            get;
            set;
        }
    
        public bool IsActive
        {
            get;
            set;
        }
    
        public bool IsModified
        {
            get;
            set;
        }
    
        public long LastModifiedDate
        {
            get;
            set;
        }
    
        public long IdCondicion
        {
            get;
            set;
        }
    
        public Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public Nullable<long> FechaNumerica
        {
            get;
            set;
        }

        #endregion

    }
}
