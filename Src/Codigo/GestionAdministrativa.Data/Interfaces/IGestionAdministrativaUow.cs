﻿
using GestionAdministrativa.Entities;
using Framework.Data.Repository;

namespace GestionAdministrativa.Data.Interfaces
{
    public interface IGestionAdministrativaUow : IUow
    {
        //IRepository<CategoriaOperador> CategoriaOperadores { get; }
        //IRepository<CondicionesIVA> CondicionesIVAs { get; }
        //IRepository<CondicionesVenta> CondicionesVentas { get; }
        //IRepository<Especialidad> Especialidades { get; }
        //IRepository<EstadosCliente> EstadosClientes { get; }
        //IRepository<Localidad> Localidades { get; }
        //IRepository<Operador> Operadores { get; }
        //IRepository<Personal> Personales { get; }
        //IRepository<Profesion> Profesiones { get; }
        //IRepository<Provincia> Provincias { get; }
        //IRepository<Sucursal> Sucursales { get; }
        //IRepository<TiposDocumentosIdentidad> TiposDocumentosIdentidades { get; }
        //IRepository<ClientesCuentasCorriente> ClientesCuentasCorrientes { get; }
        //IRepository<EstadosVenta> EstadosVentas{ get; }
        //IRepository<TiposComprobante> TiposComprobantes { get; }
        //IRepository<Venta> Ventas { get; }
        //IRepository<Caja> Cajas { get; }
        //IRepository<CajasMovimiento> CajasMovimientos { get; }
        //IRepository<TiposMovimientosCaja> TiposMovimientosCajas { get; }
        //IRepository<Cliente> Clientes { get; }
        //IRepository<Cobrador> Cobradores { get; }


        GestionAdministrativaDbContext DbContext { get; }
        bool IsDisposed { get; }

        void Commit();
    }
}