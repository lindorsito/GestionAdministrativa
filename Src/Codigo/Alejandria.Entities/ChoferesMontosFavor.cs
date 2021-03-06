//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChoferesMontosFavor
    {
        public System.Guid Id { get; set; }
        public System.Guid ChoferId { get; set; }
        public System.DateTime FechaComprobante { get; set; }
        public int TipoComprobanteId { get; set; }
        public string Concepto { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> ImpOcupado { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.Guid> OperadorAutorizaId { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int SucursalAltaId { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual Choferes Choferes { get; set; }
        public virtual Operadores Operadores { get; set; }
        public virtual Operadores Operadores1 { get; set; }
        public virtual Operadores Operadores2 { get; set; }
        public virtual Sucursales Sucursales { get; set; }
        public virtual Sucursales Sucursales1 { get; set; }
        public virtual TiposComprobantes TiposComprobantes { get; set; }
    }
}
