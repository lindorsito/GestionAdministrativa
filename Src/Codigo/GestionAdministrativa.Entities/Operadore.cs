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
    
    public partial class Operadore
    {
        public Operadore()
        {
            this.Bancos = new HashSet<Banco>();
            this.Bancos1 = new HashSet<Banco>();
            this.Cajas = new HashSet<Caja>();
            this.Cajas1 = new HashSet<Caja>();
            this.Cajas2 = new HashSet<Caja>();
            this.CajasMovimientos = new HashSet<CajasMovimiento>();
            this.CajasMovimientos1 = new HashSet<CajasMovimiento>();
            this.CategoriasOperadores = new HashSet<CategoriasOperadore>();
            this.CategoriasOperadores1 = new HashSet<CategoriasOperadore>();
            this.Celulares = new HashSet<Celulare>();
            this.Celulares1 = new HashSet<Celulare>();
            this.CelularesMovimientoes = new HashSet<CelularesMovimiento>();
            this.CelularesMovimientoes1 = new HashSet<CelularesMovimiento>();
            this.CentrosCostos = new HashSet<CentrosCosto>();
            this.CentrosCostos1 = new HashSet<CentrosCosto>();
            this.Choferes = new HashSet<Chofere>();
            this.Choferes1 = new HashSet<Chofere>();
            this.ChoferesMontosFavors = new HashSet<ChoferesMontosFavor>();
            this.ChoferesMontosFavors1 = new HashSet<ChoferesMontosFavor>();
            this.ChoferesMontosFavors2 = new HashSet<ChoferesMontosFavor>();
            this.Conceptos = new HashSet<Concepto>();
            this.Conceptos1 = new HashSet<Concepto>();
            this.CondicionesCompras = new HashSet<CondicionesCompra>();
            this.CondicionesCompras1 = new HashSet<CondicionesCompra>();
            this.Funciones = new HashSet<Funcione>();
            this.Funciones1 = new HashSet<Funcione>();
            this.GruposProveedores = new HashSet<GruposProveedore>();
            this.GruposProveedores1 = new HashSet<GruposProveedore>();
            this.Localidades = new HashSet<Localidade>();
            this.Localidades1 = new HashSet<Localidade>();
            this.Moviles = new HashSet<Movile>();
            this.Moviles1 = new HashSet<Movile>();
            this.Operadores1 = new HashSet<Operadore>();
            this.Operadores11 = new HashSet<Operadore>();
            this.OperadoresFunciones = new HashSet<OperadoresFuncione>();
            this.OperadoresFunciones1 = new HashSet<OperadoresFuncione>();
            this.OperadoresSucursales = new HashSet<OperadoresSucursale>();
            this.OperadoresSucursales1 = new HashSet<OperadoresSucursale>();
            this.OrdenesPagoes = new HashSet<OrdenesPago>();
            this.OrdenesPagoes1 = new HashSet<OrdenesPago>();
            this.OrdenesPagoDetalles = new HashSet<OrdenesPagoDetalle>();
            this.OrdenesPagoDetalles1 = new HashSet<OrdenesPagoDetalle>();
            this.OrdenesPagoDetalles2 = new HashSet<OrdenesPagoDetalle>();
            this.PagosCelulars = new HashSet<PagosCelular>();
            this.PagosCelulars1 = new HashSet<PagosCelular>();
            this.Personals = new HashSet<Personal>();
            this.Personals1 = new HashSet<Personal>();
            this.PersonalConceptoes = new HashSet<PersonalConcepto>();
            this.PersonalConceptoes1 = new HashSet<PersonalConcepto>();
            this.PersonalNovedades = new HashSet<PersonalNovedade>();
            this.PersonalNovedades1 = new HashSet<PersonalNovedade>();
            this.Proveedores = new HashSet<Proveedore>();
            this.Proveedores1 = new HashSet<Proveedore>();
            this.ProveedoresBancoes = new HashSet<ProveedoresBanco>();
            this.ProveedoresBancoes1 = new HashSet<ProveedoresBanco>();
            this.Provincias = new HashSet<Provincia>();
            this.Provincias1 = new HashSet<Provincia>();
            this.Recibos = new HashSet<Recibo>();
            this.Recibos1 = new HashSet<Recibo>();
            this.Recibos2 = new HashSet<Recibo>();
            this.RecibosDetalles = new HashSet<RecibosDetalle>();
            this.RecibosDetalles1 = new HashSet<RecibosDetalle>();
            this.Sucursales = new HashSet<Sucursale>();
            this.Sucursales1 = new HashSet<Sucursale>();
            this.TiposCelulares = new HashSet<TiposCelulare>();
            this.TiposCelulares1 = new HashSet<TiposCelulare>();
            this.TiposComprobantes = new HashSet<TiposComprobante>();
            this.TiposComprobantes1 = new HashSet<TiposComprobante>();
            this.TiposGastos = new HashSet<TiposGasto>();
            this.TiposGastos1 = new HashSet<TiposGasto>();
            this.TiposMovimientosCajas = new HashSet<TiposMovimientosCaja>();
            this.TiposMovimientosCajas1 = new HashSet<TiposMovimientosCaja>();
            this.Roles = new HashSet<Role>();
        }
    
        public System.Guid Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Nullable<System.DateTime> VigenteDesde { get; set; }
        public Nullable<System.DateTime> VigenteHasta { get; set; }
        public Nullable<System.Guid> PersonalId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual ICollection<Banco> Bancos { get; set; }
        public virtual ICollection<Banco> Bancos1 { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<Caja> Cajas1 { get; set; }
        public virtual ICollection<Caja> Cajas2 { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos1 { get; set; }
        public virtual ICollection<CategoriasOperadore> CategoriasOperadores { get; set; }
        public virtual ICollection<CategoriasOperadore> CategoriasOperadores1 { get; set; }
        public virtual ICollection<Celulare> Celulares { get; set; }
        public virtual ICollection<Celulare> Celulares1 { get; set; }
        public virtual ICollection<CelularesMovimiento> CelularesMovimientoes { get; set; }
        public virtual ICollection<CelularesMovimiento> CelularesMovimientoes1 { get; set; }
        public virtual ICollection<CentrosCosto> CentrosCostos { get; set; }
        public virtual ICollection<CentrosCosto> CentrosCostos1 { get; set; }
        public virtual ICollection<Chofere> Choferes { get; set; }
        public virtual ICollection<Chofere> Choferes1 { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavors { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavors1 { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavors2 { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
        public virtual ICollection<Concepto> Conceptos1 { get; set; }
        public virtual ICollection<CondicionesCompra> CondicionesCompras { get; set; }
        public virtual ICollection<CondicionesCompra> CondicionesCompras1 { get; set; }
        public virtual ICollection<Funcione> Funciones { get; set; }
        public virtual ICollection<Funcione> Funciones1 { get; set; }
        public virtual ICollection<GruposProveedore> GruposProveedores { get; set; }
        public virtual ICollection<GruposProveedore> GruposProveedores1 { get; set; }
        public virtual ICollection<Localidade> Localidades { get; set; }
        public virtual ICollection<Localidade> Localidades1 { get; set; }
        public virtual ICollection<Movile> Moviles { get; set; }
        public virtual ICollection<Movile> Moviles1 { get; set; }
        public virtual ICollection<Operadore> Operadores1 { get; set; }
        public virtual Operadore Operadore1 { get; set; }
        public virtual ICollection<Operadore> Operadores11 { get; set; }
        public virtual Operadore Operadore2 { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Sucursale Sucursale { get; set; }
        public virtual Sucursale Sucursale1 { get; set; }
        public virtual ICollection<OperadoresFuncione> OperadoresFunciones { get; set; }
        public virtual ICollection<OperadoresFuncione> OperadoresFunciones1 { get; set; }
        public virtual ICollection<OperadoresSucursale> OperadoresSucursales { get; set; }
        public virtual ICollection<OperadoresSucursale> OperadoresSucursales1 { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPagoes { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPagoes1 { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalles { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalles1 { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalles2 { get; set; }
        public virtual ICollection<PagosCelular> PagosCelulars { get; set; }
        public virtual ICollection<PagosCelular> PagosCelulars1 { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Personal> Personals1 { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConceptoes { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConceptoes1 { get; set; }
        public virtual ICollection<PersonalNovedade> PersonalNovedades { get; set; }
        public virtual ICollection<PersonalNovedade> PersonalNovedades1 { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<Proveedore> Proveedores1 { get; set; }
        public virtual ICollection<ProveedoresBanco> ProveedoresBancoes { get; set; }
        public virtual ICollection<ProveedoresBanco> ProveedoresBancoes1 { get; set; }
        public virtual ICollection<Provincia> Provincias { get; set; }
        public virtual ICollection<Provincia> Provincias1 { get; set; }
        public virtual ICollection<Recibo> Recibos { get; set; }
        public virtual ICollection<Recibo> Recibos1 { get; set; }
        public virtual ICollection<Recibo> Recibos2 { get; set; }
        public virtual ICollection<RecibosDetalle> RecibosDetalles { get; set; }
        public virtual ICollection<RecibosDetalle> RecibosDetalles1 { get; set; }
        public virtual ICollection<Sucursale> Sucursales { get; set; }
        public virtual ICollection<Sucursale> Sucursales1 { get; set; }
        public virtual ICollection<TiposCelulare> TiposCelulares { get; set; }
        public virtual ICollection<TiposCelulare> TiposCelulares1 { get; set; }
        public virtual ICollection<TiposComprobante> TiposComprobantes { get; set; }
        public virtual ICollection<TiposComprobante> TiposComprobantes1 { get; set; }
        public virtual ICollection<TiposGasto> TiposGastos { get; set; }
        public virtual ICollection<TiposGasto> TiposGastos1 { get; set; }
        public virtual ICollection<TiposMovimientosCaja> TiposMovimientosCajas { get; set; }
        public virtual ICollection<TiposMovimientosCaja> TiposMovimientosCajas1 { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
