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
    
    public partial class Sucursal_2Entities : DbContext
    {
        public Sucursal_2Entities()
            : base("name=Sucursal_2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutomovilxSucursal> AutomovilxSucursals { get; set; }
        public virtual DbSet<AutxSucxVentxCli> AutxSucxVentxClis { get; set; }
        public virtual DbSet<ClientexFinanciamiento> ClientexFinanciamientoes { get; set; }
        public virtual DbSet<Detalle> Detalles { get; set; }
        public virtual DbSet<DetallexFactura> DetallexFacturas { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<EmpleadoxSucursal> EmpleadoxSucursals { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Financiamiento> Financiamientoes { get; set; }
        public virtual DbSet<Pago> Pagoes { get; set; }
        public virtual DbSet<PagoxClientexFinanciamiento> PagoxClientexFinanciamientoes { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<SucursalUbicacion> SucursalUbicacions { get; set; }
        public virtual DbSet<tipoPago> tipoPagoes { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<VentasxCliente> VentasxClientes { get; set; }
    
        public virtual int spAgregarSucursal_2(Nullable<System.TimeSpan> horaEntrada, Nullable<System.TimeSpan> horaSalida, System.Data.Entity.Spatial.DbGeometry ubicacion, string pais)
        {
            var horaEntradaParameter = horaEntrada.HasValue ?
                new ObjectParameter("horaEntrada", horaEntrada) :
                new ObjectParameter("horaEntrada", typeof(System.TimeSpan));
    
            var horaSalidaParameter = horaSalida.HasValue ?
                new ObjectParameter("horaSalida", horaSalida) :
                new ObjectParameter("horaSalida", typeof(System.TimeSpan));
    
            var ubicacionParameter = ubicacion != null ?
                new ObjectParameter("ubicacion", ubicacion) :
                new ObjectParameter("ubicacion", typeof(System.Data.Entity.Spatial.DbGeometry));
    
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAgregarSucursal_2", horaEntradaParameter, horaSalidaParameter, ubicacionParameter, paisParameter);
        }
    }
}