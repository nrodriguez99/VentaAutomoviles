﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaAutomoviles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FabricaEntities : DbContext
    {
        public FabricaEntities()
            : base("name=FabricaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Automovil> Automovils { get; set; }
        public virtual DbSet<Caracteristica> Caracteristicas { get; set; }
        public virtual DbSet<CaracteristicasxAutomovil> CaracteristicasxAutomovils { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClienteCredenciale> ClienteCredenciales { get; set; }
        public virtual DbSet<ClienteUbicacion> ClienteUbicacions { get; set; }
        public virtual DbSet<EmpleadoFabrica> EmpleadoFabricas { get; set; }
        public virtual DbSet<Extra> Extras { get; set; }
        public virtual DbSet<ExtraxAutomovil> ExtraxAutomovils { get; set; }
        public virtual DbSet<Fabrica> Fabricas { get; set; }
        public virtual DbSet<Foto> Fotoes { get; set; }
        public virtual DbSet<FotoxAutomovil> FotoxAutomovils { get; set; }
        public virtual DbSet<PedidoSucursal1> PedidoSucursal1 { get; set; }
        public virtual DbSet<PedidoSucursal2> PedidoSucursal2 { get; set; }
        public virtual DbSet<PedidoSucursal3> PedidoSucursal3 { get; set; }
        public virtual DbSet<TipoAutomovil> TipoAutomovils { get; set; }
        public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; }
    
        public virtual int spActualizarPrecioAutomovil(Nullable<int> idAutomovil, Nullable<decimal> precioBase)
        {
            var idAutomovilParameter = idAutomovil.HasValue ?
                new ObjectParameter("idAutomovil", idAutomovil) :
                new ObjectParameter("idAutomovil", typeof(int));
    
            var precioBaseParameter = precioBase.HasValue ?
                new ObjectParameter("precioBase", precioBase) :
                new ObjectParameter("precioBase", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualizarPrecioAutomovil", idAutomovilParameter, precioBaseParameter);
        }
    
        public virtual int spActualizarPrecioExtra(Nullable<int> idExtra, Nullable<decimal> precio)
        {
            var idExtraParameter = idExtra.HasValue ?
                new ObjectParameter("idExtra", idExtra) :
                new ObjectParameter("idExtra", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualizarPrecioExtra", idExtraParameter, precioParameter);
        }
    
        public virtual int spAgregarAutomovil(Nullable<int> idTipoAutomovil, Nullable<int> idTipoCombustible, string placa, Nullable<decimal> precioBase, Nullable<bool> consignacion, Nullable<int> anno, Nullable<int> idCaracteristicas, Nullable<int> idSucursal)
        {
            var idTipoAutomovilParameter = idTipoAutomovil.HasValue ?
                new ObjectParameter("idTipoAutomovil", idTipoAutomovil) :
                new ObjectParameter("idTipoAutomovil", typeof(int));
    
            var idTipoCombustibleParameter = idTipoCombustible.HasValue ?
                new ObjectParameter("idTipoCombustible", idTipoCombustible) :
                new ObjectParameter("idTipoCombustible", typeof(int));
    
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            var precioBaseParameter = precioBase.HasValue ?
                new ObjectParameter("precioBase", precioBase) :
                new ObjectParameter("precioBase", typeof(decimal));
    
            var consignacionParameter = consignacion.HasValue ?
                new ObjectParameter("consignacion", consignacion) :
                new ObjectParameter("consignacion", typeof(bool));
    
            var annoParameter = anno.HasValue ?
                new ObjectParameter("anno", anno) :
                new ObjectParameter("anno", typeof(int));
    
            var idCaracteristicasParameter = idCaracteristicas.HasValue ?
                new ObjectParameter("idCaracteristicas", idCaracteristicas) :
                new ObjectParameter("idCaracteristicas", typeof(int));
    
            var idSucursalParameter = idSucursal.HasValue ?
                new ObjectParameter("idSucursal", idSucursal) :
                new ObjectParameter("idSucursal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarAutomovil", idTipoAutomovilParameter, idTipoCombustibleParameter, placaParameter, precioBaseParameter, consignacionParameter, annoParameter, idCaracteristicasParameter, idSucursalParameter);
        }
    
        public virtual int spAgregarCaracteristica(string color, string marca, Nullable<int> cantidadPasajeros, Nullable<int> nPuertas)
        {
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("marca", marca) :
                new ObjectParameter("marca", typeof(string));
    
            var cantidadPasajerosParameter = cantidadPasajeros.HasValue ?
                new ObjectParameter("cantidadPasajeros", cantidadPasajeros) :
                new ObjectParameter("cantidadPasajeros", typeof(int));
    
            var nPuertasParameter = nPuertas.HasValue ?
                new ObjectParameter("nPuertas", nPuertas) :
                new ObjectParameter("nPuertas", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarCaracteristica", colorParameter, marcaParameter, cantidadPasajerosParameter, nPuertasParameter);
        }
    
        public virtual int spAgregarExtra(string nombre, Nullable<decimal> precio)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarExtra", nombreParameter, precioParameter);
        }
    
        public virtual int spAgregarPedido(Nullable<int> idSucursal, Nullable<int> idFabrica, Nullable<int> idAutomovilxSucursal, Nullable<int> idCliente, Nullable<System.DateTime> fechaPedido, Nullable<System.DateTime> fechaEntrega, Nullable<bool> despacho)
        {
            var idSucursalParameter = idSucursal.HasValue ?
                new ObjectParameter("idSucursal", idSucursal) :
                new ObjectParameter("idSucursal", typeof(int));
    
            var idFabricaParameter = idFabrica.HasValue ?
                new ObjectParameter("idFabrica", idFabrica) :
                new ObjectParameter("idFabrica", typeof(int));
    
            var idAutomovilxSucursalParameter = idAutomovilxSucursal.HasValue ?
                new ObjectParameter("idAutomovilxSucursal", idAutomovilxSucursal) :
                new ObjectParameter("idAutomovilxSucursal", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var fechaPedidoParameter = fechaPedido.HasValue ?
                new ObjectParameter("fechaPedido", fechaPedido) :
                new ObjectParameter("fechaPedido", typeof(System.DateTime));
    
            var fechaEntregaParameter = fechaEntrega.HasValue ?
                new ObjectParameter("fechaEntrega", fechaEntrega) :
                new ObjectParameter("fechaEntrega", typeof(System.DateTime));
    
            var despachoParameter = despacho.HasValue ?
                new ObjectParameter("despacho", despacho) :
                new ObjectParameter("despacho", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarPedido", idSucursalParameter, idFabricaParameter, idAutomovilxSucursalParameter, idClienteParameter, fechaPedidoParameter, fechaEntregaParameter, despachoParameter);
        }
    
        public virtual int spAgregarTipoAutomovil(string tipo)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarTipoAutomovil", tipoParameter);
        }
    
        public virtual int spAgregarTipoCombustible(string tipo)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarTipoCombustible", tipoParameter);
        }
    
        public virtual int spConsultarDescuento10P(Nullable<int> idCliente, Nullable<int> idSucursal)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var idSucursalParameter = idSucursal.HasValue ?
                new ObjectParameter("idSucursal", idSucursal) :
                new ObjectParameter("idSucursal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spConsultarDescuento10P", idClienteParameter, idSucursalParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> spConsultarPrecioAutomovil(Nullable<int> idAutomovil)
        {
            var idAutomovilParameter = idAutomovil.HasValue ?
                new ObjectParameter("idAutomovil", idAutomovil) :
                new ObjectParameter("idAutomovil", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("spConsultarPrecioAutomovil", idAutomovilParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> spConsultarPrecioExtra(Nullable<int> idExtra)
        {
            var idExtraParameter = idExtra.HasValue ?
                new ObjectParameter("idExtra", idExtra) :
                new ObjectParameter("idExtra", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("spConsultarPrecioExtra", idExtraParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spVerAutoNoSalidaxSucursal(Nullable<int> idSucursal)
        {
            var idSucursalParameter = idSucursal.HasValue ?
                new ObjectParameter("idSucursal", idSucursal) :
                new ObjectParameter("idSucursal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spVerAutoNoSalidaxSucursal", idSucursalParameter);
        }
    }
}