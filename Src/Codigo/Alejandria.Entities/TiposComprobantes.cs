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
    
    public partial class TiposComprobantes
    {
        public TiposComprobantes()
        {
            this.CajasMovimientos = new HashSet<CajasMovimientos>();
            this.CelularesMovimiento = new HashSet<CelularesMovimiento>();
            this.ChoferesMontosFavor = new HashSet<ChoferesMontosFavor>();
            this.OrdenesPago = new HashSet<OrdenesPago>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Prioridad { get; set; }
        public string Comprobante { get; set; }
        public string Concepto { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual ICollection<CajasMovimientos> CajasMovimientos { get; set; }
        public virtual ICollection<CelularesMovimiento> CelularesMovimiento { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavor { get; set; }
        public virtual Operadores Operadores { get; set; }
        public virtual Operadores Operadores1 { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
        public virtual Sucursales Sucursales { get; set; }
        public virtual Sucursales Sucursales1 { get; set; }
    }
}
