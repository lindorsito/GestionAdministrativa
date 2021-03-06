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
    
    public partial class Cajas
    {
        public Cajas()
        {
            this.OrdenesPagoDetalle = new HashSet<OrdenesPagoDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public int SucursalId { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<System.DateTime> FCierre { get; set; }
        public Nullable<decimal> Inicio { get; set; }
        public Nullable<decimal> Ingresos { get; set; }
        public Nullable<decimal> Egresos { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> Cheques { get; set; }
        public Nullable<decimal> Bonos { get; set; }
        public string PcAlta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Operadores Operadores { get; set; }
        public virtual Operadores Operadores1 { get; set; }
        public virtual Operadores Operadores2 { get; set; }
        public virtual Sucursales Sucursales { get; set; }
        public virtual Sucursales Sucursales1 { get; set; }
        public virtual Sucursales Sucursales2 { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalle { get; set; }
    }
}
