//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class GruposProveedore
    {
        public GruposProveedore()
        {
            this.Proveedores = new HashSet<Proveedore>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Operadore Operadore { get; set; }
        public virtual Operadore Operadore1 { get; set; }
        public virtual Sucursale Sucursale { get; set; }
        public virtual Sucursale Sucursale1 { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
