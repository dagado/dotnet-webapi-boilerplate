using System;
using System.Collections.Generic;
using FSH.WebApi.Domain.Gestion;
using Microsoft.EntityFrameworkCore;

namespace FSH.WebApi.Infrastructure.Gestion;

public partial class GestionDbContext : DbContext
{
    public GestionDbContext()
    {
    }

    public GestionDbContext(DbContextOptions<GestionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DetallepresupuestoCapitulosSubcapitulo> DetallepresupuestoCapitulosSubcapitulos { get; set; }

    public virtual DbSet<FacturasVencimientosManuale> FacturasVencimientosManuales { get; set; }

    public virtual DbSet<MgguardaMueble> MgguardaMuebles { get; set; }

    public virtual DbSet<MgpedidoMudanza> MgpedidoMudanzas { get; set; }

    public virtual DbSet<Mgzona> Mgzonas { get; set; }

    public virtual DbSet<TbAccesosDirecto> TbAccesosDirectos { get; set; }

    public virtual DbSet<TbAccesosDirectosWeb> TbAccesosDirectosWebs { get; set; }

    public virtual DbSet<TbAdministadoresFinca> TbAdministadoresFincas { get; set; }

    public virtual DbSet<TbAlbaranCertificacion> TbAlbaranCertificacions { get; set; }

    public virtual DbSet<TbAlbaranImpuesto> TbAlbaranImpuestos { get; set; }

    public virtual DbSet<TbAlerta> TbAlertas { get; set; }

    public virtual DbSet<TbAlertasDestinatario> TbAlertasDestinatarios { get; set; }

    public virtual DbSet<TbAlertasStatus> TbAlertasStatuses { get; set; }

    public virtual DbSet<TbAlmacene> TbAlmacenes { get; set; }

    public virtual DbSet<TbArticulo> TbArticulos { get; set; }

    public virtual DbSet<TbArticulosPack> TbArticulosPacks { get; set; }

    public virtual DbSet<TbArticulosReferenciasCompra> TbArticulosReferenciasCompras { get; set; }

    public virtual DbSet<TbAviso> TbAvisos { get; set; }

    public virtual DbSet<TbAvisosOperario> TbAvisosOperarios { get; set; }

    public virtual DbSet<TbBanco> TbBancos { get; set; }

    public virtual DbSet<TbBancosTpv> TbBancosTpvs { get; set; }

    public virtual DbSet<TbBic> TbBics { get; set; }

    public virtual DbSet<TbCabeceraFabDe> TbCabeceraFabDes { get; set; }

    public virtual DbSet<TbCabeceraMensaje> TbCabeceraMensajes { get; set; }

    public virtual DbSet<TbCabeceraMovimientoAlmacen> TbCabeceraMovimientoAlmacens { get; set; }

    public virtual DbSet<TbCabeceraPedido> TbCabeceraPedidos { get; set; }

    public virtual DbSet<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; set; }

    public virtual DbSet<TbCabeceraPresupuestoDocumento> TbCabeceraPresupuestoDocumentos { get; set; }

    public virtual DbSet<TbCabeceraRemesa> TbCabeceraRemesas { get; set; }

    public virtual DbSet<TbCabeceraTarifa> TbCabeceraTarifas { get; set; }

    public virtual DbSet<TbCaja> TbCajas { get; set; }

    public virtual DbSet<TbCapitulo> TbCapitulos { get; set; }

    public virtual DbSet<TbClasificacion> TbClasificacions { get; set; }

    public virtual DbSet<TbClasificacionesApunte> TbClasificacionesApuntes { get; set; }

    public virtual DbSet<TbClausulasContrato> TbClausulasContratos { get; set; }

    public virtual DbSet<TbClausulasDocumento> TbClausulasDocumentos { get; set; }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbClientesContacto> TbClientesContactos { get; set; }

    public virtual DbSet<TbClientesCuentasBancaria> TbClientesCuentasBancarias { get; set; }

    public virtual DbSet<TbClientesDelegacione> TbClientesDelegaciones { get; set; }

    public virtual DbSet<TbClientesDireccione> TbClientesDirecciones { get; set; }

    public virtual DbSet<TbClientesDocumento> TbClientesDocumentos { get; set; }

    public virtual DbSet<TbClientesFacturacionPeriodica> TbClientesFacturacionPeriodicas { get; set; }

    public virtual DbSet<TbClientesRutasDocumento> TbClientesRutasDocumentos { get; set; }

    public virtual DbSet<TbClientesTarifa> TbClientesTarifas { get; set; }

    public virtual DbSet<TbClientesTarifaDto> TbClientesTarifaDtos { get; set; }

    public virtual DbSet<TbContrato> TbContratos { get; set; }

    public virtual DbSet<TbCuentasCorreo> TbCuentasCorreos { get; set; }

    public virtual DbSet<TbCuentasCorreoCarpeta> TbCuentasCorreoCarpetas { get; set; }

    public virtual DbSet<TbDatosEmpresa> TbDatosEmpresas { get; set; }

    public virtual DbSet<TbDestinatariosMensaje> TbDestinatariosMensajes { get; set; }

    public virtual DbSet<TbDetalle> TbDetalles { get; set; }

    public virtual DbSet<TbDetalleCertificacion> TbDetalleCertificacions { get; set; }

    public virtual DbSet<TbDetalleContrato> TbDetalleContratos { get; set; }

    public virtual DbSet<TbDetalleDtoFactura> TbDetalleDtoFacturas { get; set; }

    public virtual DbSet<TbDetalleFabDe> TbDetalleFabDes { get; set; }

    public virtual DbSet<TbDetalleMovimientoAlmacen> TbDetalleMovimientoAlmacens { get; set; }

    public virtual DbSet<TbDetalleParteOperario> TbDetalleParteOperarios { get; set; }

    public virtual DbSet<TbDetallePedido> TbDetallePedidos { get; set; }

    public virtual DbSet<TbDetallePerfil> TbDetallePerfils { get; set; }

    public virtual DbSet<TbDetallePresupuesto> TbDetallePresupuestos { get; set; }

    public virtual DbSet<TbDetalleRetorno> TbDetalleRetornos { get; set; }

    public virtual DbSet<TbDiseñosSubInforme> TbDiseñosSubInformes { get; set; }

    public virtual DbSet<TbDocumentosCoste> TbDocumentosCostes { get; set; }

    public virtual DbSet<TbEntradasTallerEstado> TbEntradasTallerEstados { get; set; }

    public virtual DbSet<TbEntradasTallerPieza> TbEntradasTallerPiezas { get; set; }

    public virtual DbSet<TbEntradasTallerSeguimiento> TbEntradasTallerSeguimientos { get; set; }

    public virtual DbSet<TbEstadosCartera> TbEstadosCarteras { get; set; }

    public virtual DbSet<TbFabricacionDespieze> TbFabricacionDespiezes { get; set; }

    public virtual DbSet<TbFabricacionDespiezeDetalle> TbFabricacionDespiezeDetalles { get; set; }

    public virtual DbSet<TbFabricacionSalida> TbFabricacionSalidas { get; set; }

    public virtual DbSet<TbFacturaCertificacion> TbFacturaCertificacions { get; set; }

    public virtual DbSet<TbFacturaImpuesto> TbFacturaImpuestos { get; set; }

    public virtual DbSet<TbFamilia> TbFamilias { get; set; }

    public virtual DbSet<TbFormasPago> TbFormasPagos { get; set; }

    public virtual DbSet<TbFormato> TbFormatos { get; set; }

    public virtual DbSet<TbHistorialNumerosSerie> TbHistorialNumerosSeries { get; set; }

    public virtual DbSet<TbIva> TbIvas { get; set; }

    public virtual DbSet<TbIvasCuentasContable> TbIvasCuentasContables { get; set; }

    public virtual DbSet<TbLayout> TbLayouts { get; set; }

    public virtual DbSet<TbLineasCoste> TbLineasCostes { get; set; }

    public virtual DbSet<TbMapeo> TbMapeos { get; set; }

    public virtual DbSet<TbMaquinasCliente> TbMaquinasClientes { get; set; }

    public virtual DbSet<TbMaquinasClienteCaracterística> TbMaquinasClienteCaracterísticas { get; set; }

    public virtual DbSet<TbMarca> TbMarcas { get; set; }

    public virtual DbSet<TbModelo> TbModelos { get; set; }

    public virtual DbSet<TbModelosCaracteristica> TbModelosCaracteristicas { get; set; }

    public virtual DbSet<TbModosPago> TbModosPagos { get; set; }

    public virtual DbSet<TbMovimientosBancariosDocumento> TbMovimientosBancariosDocumentos { get; set; }

    public virtual DbSet<TbNumero> TbNumeros { get; set; }

    public virtual DbSet<TbObra> TbObras { get; set; }

    public virtual DbSet<TbObrasCuenta> TbObrasCuentas { get; set; }

    public virtual DbSet<TbObrasDetalle> TbObrasDetalles { get; set; }

    public virtual DbSet<TbObrasDetalleListum> TbObrasDetalleLista { get; set; }

    public virtual DbSet<TbObrasDetalleObservacione> TbObrasDetalleObservaciones { get; set; }

    public virtual DbSet<TbObrasDocumento> TbObrasDocumentos { get; set; }

    public virtual DbSet<TbObrasGrupo> TbObrasGrupos { get; set; }

    public virtual DbSet<TbObrasLista> TbObrasListas { get; set; }

    public virtual DbSet<TbObrasPreciosCoste> TbObrasPreciosCostes { get; set; }

    public virtual DbSet<TbObrasSubgrupo> TbObrasSubgrupos { get; set; }

    public virtual DbSet<TbObservacionesRevision> TbObservacionesRevisions { get; set; }

    public virtual DbSet<TbOperario> TbOperarios { get; set; }

    public virtual DbSet<TbOperariosCliente> TbOperariosClientes { get; set; }

    public virtual DbSet<TbOperariosDocumento> TbOperariosDocumentos { get; set; }

    public virtual DbSet<TbOperariosRutasDocumento> TbOperariosRutasDocumentos { get; set; }

    public virtual DbSet<TbOperariosVacacione> TbOperariosVacaciones { get; set; }

    public virtual DbSet<TbOrganizacionArticulo> TbOrganizacionArticulos { get; set; }

    public virtual DbSet<TbPaise> TbPaises { get; set; }

    public virtual DbSet<TbParametrosFirma> TbParametrosFirmas { get; set; }

    public virtual DbSet<TbParteOperario> TbParteOperarios { get; set; }

    public virtual DbSet<TbPedidoImpuesto> TbPedidoImpuestos { get; set; }

    public virtual DbSet<TbPedidosEstado> TbPedidosEstados { get; set; }

    public virtual DbSet<TbPerfile> TbPerfiles { get; set; }

    public virtual DbSet<TbPlanContable> TbPlanContables { get; set; }

    public virtual DbSet<TbPlantillasCuboCostesVehiculo> TbPlantillasCuboCostesVehiculos { get; set; }

    public virtual DbSet<TbPosicionamientoOperario> TbPosicionamientoOperarios { get; set; }

    public virtual DbSet<TbPotenciale> TbPotenciales { get; set; }

    public virtual DbSet<TbPotencialesEstado> TbPotencialesEstados { get; set; }

    public virtual DbSet<TbPotencialesGrupo> TbPotencialesGrupos { get; set; }

    public virtual DbSet<TbPotencialesSeguimiento> TbPotencialesSeguimientos { get; set; }

    public virtual DbSet<TbPresupuestoImpuesto> TbPresupuestoImpuestos { get; set; }

    public virtual DbSet<TbPresupuestosEstado> TbPresupuestosEstados { get; set; }

    public virtual DbSet<TbPrevisione> TbPrevisiones { get; set; }

    public virtual DbSet<TbPrevisionesTemporal> TbPrevisionesTemporals { get; set; }

    public virtual DbSet<TbProgramacion> TbProgramacions { get; set; }

    public virtual DbSet<TbProgramacionClasificacion> TbProgramacionClasificacions { get; set; }

    public virtual DbSet<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalles { get; set; }

    public virtual DbSet<TbProgramacionDiarium> TbProgramacionDiaria { get; set; }

    public virtual DbSet<TbPropuestum> TbPropuesta { get; set; }

    public virtual DbSet<TbProvincia> TbProvincias { get; set; }

    public virtual DbSet<TbPuntosVentum> TbPuntosVenta { get; set; }

    public virtual DbSet<TbReferenciasGasto> TbReferenciasGastos { get; set; }

    public virtual DbSet<TbReferenciasParte> TbReferenciasPartes { get; set; }

    public virtual DbSet<TbRepositorio> TbRepositorios { get; set; }

    public virtual DbSet<TbResponsable> TbResponsables { get; set; }

    public virtual DbSet<TbRetencione> TbRetenciones { get; set; }

    public virtual DbSet<TbRetencionesCuentasContable> TbRetencionesCuentasContables { get; set; }

    public virtual DbSet<TbRuta> TbRutas { get; set; }

    public virtual DbSet<TbSeriesDiseñoDocumento> TbSeriesDiseñoDocumentos { get; set; }

    public virtual DbSet<TbSeriesFactura> TbSeriesFacturas { get; set; }

    public virtual DbSet<TbSubCapitulo> TbSubCapitulos { get; set; }

    public virtual DbSet<TbSubfamilia> TbSubfamilias { get; set; }

    public virtual DbSet<TbTallere> TbTalleres { get; set; }

    public virtual DbSet<TbTiposArticulo> TbTiposArticulos { get; set; }

    public virtual DbSet<TbTiposDescuento> TbTiposDescuentos { get; set; }

    public virtual DbSet<TbTiposDocumentoInterno> TbTiposDocumentoInternos { get; set; }

    public virtual DbSet<TbTiposMantenimiento> TbTiposMantenimientos { get; set; }

    public virtual DbSet<TbTiposMaquina> TbTiposMaquinas { get; set; }

    public virtual DbSet<TbTiposObra> TbTiposObras { get; set; }

    public virtual DbSet<TbTpv> TbTpvs { get; set; }

    public virtual DbSet<TbTpvUsuario> TbTpvUsuarios { get; set; }

    public virtual DbSet<TbUnidade> TbUnidades { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    public virtual DbSet<TbVehiculo> TbVehiculos { get; set; }

    public virtual DbSet<TbVehiculosAmortizacione> TbVehiculosAmortizaciones { get; set; }

    public virtual DbSet<TbVehiculosDocumento> TbVehiculosDocumentos { get; set; }

    public virtual DbSet<TbVehiculosParte> TbVehiculosPartes { get; set; }

    public virtual DbSet<TbalmacenesStock> TbalmacenesStocks { get; set; }

    public virtual DbSet<TbcabeceraAlbaran> TbcabeceraAlbarans { get; set; }

    public virtual DbSet<TbcabeceraFactura> TbcabeceraFacturas { get; set; }

    public virtual DbSet<Tbcartera> Tbcarteras { get; set; }

    public virtual DbSet<TbdetalleTarifa> TbdetalleTarifas { get; set; }

    public virtual DbSet<TbentradasTaller> TbentradasTallers { get; set; }

    public virtual DbSet<TbhistorialRegularizacion> TbhistorialRegularizacions { get; set; }

    public virtual DbSet<Tblayoutspivot> Tblayoutspivots { get; set; }

    public virtual DbSet<Tblog> Tblogs { get; set; }

    public virtual DbSet<Tbmovimientosbancario> Tbmovimientosbancarios { get; set; }

    public virtual DbSet<Tbparametro> Tbparametros { get; set; }

    public virtual DbSet<TbtiposDocumento> TbtiposDocumentos { get; set; }

    public virtual DbSet<TmpCabeceraTicket> TmpCabeceraTickets { get; set; }

    public virtual DbSet<TmpDetalleTicket> TmpDetalleTickets { get; set; }

    public virtual DbSet<TmpEtiqueta> TmpEtiquetas { get; set; }

    public virtual DbSet<TmpExistencia> TmpExistencias { get; set; }

    public virtual DbSet<TmpInforme> TmpInformes { get; set; }

    public virtual DbSet<TmpInventario> TmpInventarios { get; set; }

    public virtual DbSet<TmpRetorno> TmpRetornos { get; set; }

    public virtual DbSet<TmpTbAvisosOperario> TmpTbAvisosOperarios { get; set; }

    public virtual DbSet<TrCabeceraAlbaran> TrCabeceraAlbarans { get; set; }

    public virtual DbSet<TrCabeceraFactura> TrCabeceraFacturas { get; set; }

    public virtual DbSet<TrDetalle> TrDetalles { get; set; }

    //public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<Vw347> Vw347s { get; set; }

    public virtual DbSet<VwAlbarane> VwAlbaranes { get; set; }

    public virtual DbSet<VwArticulo> VwArticulos { get; set; }

    public virtual DbSet<VwArticulosFoto> VwArticulosFotos { get; set; }

    public virtual DbSet<VwAviso> VwAvisos { get; set; }

    public virtual DbSet<VwConceptosFacturado> VwConceptosFacturados { get; set; }

    public virtual DbSet<VwDetallePartesOperario> VwDetallePartesOperarios { get; set; }

    public virtual DbSet<VwDetallePedidosVentum> VwDetallePedidosVenta { get; set; }

    public virtual DbSet<VwEntradasTaller> VwEntradasTallers { get; set; }

    public virtual DbSet<VwFactura> VwFacturas { get; set; }

    public virtual DbSet<VwFechasMto> VwFechasMtos { get; set; }

    public virtual DbSet<VwHistorialArticulo> VwHistorialArticulos { get; set; }

    public virtual DbSet<VwHistorialArticuloConSaldo> VwHistorialArticuloConSaldos { get; set; }

    public virtual DbSet<VwHistorialCuentasObra> VwHistorialCuentasObras { get; set; }

    public virtual DbSet<VwKilometrosMto> VwKilometrosMtos { get; set; }

    public virtual DbSet<VwLineasDocumento> VwLineasDocumentos { get; set; }

    public virtual DbSet<VwListaObra> VwListaObras { get; set; }

    public virtual DbSet<VwLog> VwLogs { get; set; }

    public virtual DbSet<VwMaquinasCliente> VwMaquinasClientes { get; set; }

    public virtual DbSet<VwMovimientosAlmacen> VwMovimientosAlmacens { get; set; }

    public virtual DbSet<VwObrasCoste> VwObrasCostes { get; set; }

    public virtual DbSet<VwPartesOperario> VwPartesOperarios { get; set; }

    public virtual DbSet<VwPedido> VwPedidos { get; set; }

    public virtual DbSet<VwPresupuesto> VwPresupuestos { get; set; }

    public virtual DbSet<VwRegistroPedido> VwRegistroPedidos { get; set; }

    public virtual DbSet<VwRegistrosCoste> VwRegistrosCostes { get; set; }

    public virtual DbSet<VwRegistrosCosteCubo> VwRegistrosCosteCubos { get; set; }

    public virtual DbSet<VwSeguimientoPotenciale> VwSeguimientoPotenciales { get; set; }

    public virtual DbSet<VwTrazabilidad> VwTrazabilidads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=GestionSettings:ConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<DetallepresupuestoCapitulosSubcapitulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("detallepresupuestoCapitulos_Subcapitulos");

            entity.Property(e => e.Capitulo)
                .HasMaxLength(111)
                .IsUnicode(false)
                .HasColumnName("capitulo");
            entity.Property(e => e.Iddetallefactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddetallefactura");
            entity.Property(e => e.Subcapitulo)
                .HasMaxLength(111)
                .IsUnicode(false)
                .HasColumnName("subcapitulo");
        });

        modelBuilder.Entity<FacturasVencimientosManuale>(entity =>
        {
            entity.HasKey(e => e.Idfactura);

            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");

            entity.HasOne(d => d.IdfacturaNavigation).WithOne(p => p.FacturasVencimientosManuale)
                .HasForeignKey<FacturasVencimientosManuale>(d => d.Idfactura)
                .HasConstraintName("FK_FacturasVencimientosManuales_TBCabeceraFactura");
        });

        modelBuilder.Entity<MgguardaMueble>(entity =>
        {
            entity.HasKey(e => e.IdGm);

            entity.ToTable("MGGuardaMuebles");

            entity.Property(e => e.IdGm)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Alto).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.GuardaMueble)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdZona)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Largo).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMensual).HasColumnType("decimal(6, 2)");

            entity.HasOne(d => d.IdZonaNavigation).WithMany(p => p.MgguardaMuebles)
                .HasForeignKey(d => d.IdZona)
                .HasConstraintName("FK_MGGuardaMuebles_MGZonas");
        });

        modelBuilder.Entity<MgpedidoMudanza>(entity =>
        {
            entity.ToTable("MGPedidoMudanza");

            entity.HasIndex(e => new { e.NumeroPedido, e.Idempresa }, "NonClusteredIndex-20210315-174646").IsUnique();

            entity.HasIndex(e => new { e.FechaRegistro, e.Idempresa }, "NonClusteredIndex-20210315-184426");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cliente)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DireccionEntrega)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DireccionRecogida)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Embalaje)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Empaquetado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaMudanza).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FundasColchon)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IdGm)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MontajeDesmontaje)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Permisos)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("permisos");
            entity.Property(e => e.Roperos)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Telefonos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefonos");
            entity.Property(e => e.TrasladoconDestino)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGmNavigation).WithMany(p => p.MgpedidoMudanzas)
                .HasForeignKey(d => d.IdGm)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_MGPedidoMudanza_MGGuardaMuebles");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.MgpedidoMudanzas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MGPedidoMudanza_TbUsuarios");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.MgpedidoMudanzas)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MGPedidoMudanza_TbClientes");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.MgpedidoMudanzas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MGPedidoMudanza_TbDatosEmpresa");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.MgpedidoMudanzas)
                .HasForeignKey(d => d.Idfactura)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_MGPedidoMudanza_TBCabeceraFactura");
        });

        modelBuilder.Entity<Mgzona>(entity =>
        {
            entity.HasKey(e => e.IdZona);

            entity.ToTable("MGZonas");

            entity.Property(e => e.IdZona)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Mgzonas)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_MGZonas_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbAccesosDirecto>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Maquina)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbAccesosDirectosWeb>(entity =>
        {
            entity.HasKey(e => e.IdWeb);

            entity.ToTable("TbAccesosDirectosWeb");

            entity.Property(e => e.IdWeb)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Maquina)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Web)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbAdministadoresFinca>(entity =>
        {
            entity.HasKey(e => e.IdAdministrador);

            entity.Property(e => e.IdAdministrador)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbAdministadoresFincas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAdministadoresFincas_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbAlbaranCertificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdAlbaran, e.IdDocumento });

            entity.ToTable("TbAlbaranCertificacion");

            entity.Property(e => e.IdAlbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdAlbaranNavigation).WithMany(p => p.TbAlbaranCertificacions)
                .HasForeignKey(d => d.IdAlbaran)
                .HasConstraintName("FK_TbAlbaranCertificacion_TBCabeceraAlbaran");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbAlbaranCertificacions)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbAlbaranCertificacion_TbCabeceraPresupuesto");
        });

        modelBuilder.Entity<TbAlbaranImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TbPedidoAlbaran");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Base).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Bruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAlbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.RecargoEquivalencia).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.TotalAlbaran).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalIva).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(9, 2)");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbAlbaranImpuestos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAlbaranImpuestos_TbIvas");

            entity.HasOne(d => d.IdAlbaranNavigation).WithMany(p => p.TbAlbaranImpuestos)
                .HasForeignKey(d => d.IdAlbaran)
                .HasConstraintName("FK_TbAlbaranImpuestos_TbCabeceraAlbaran");
        });

        modelBuilder.Entity<TbAlerta>(entity =>
        {
            entity.HasIndex(e => new { e.FehaAlarma, e.IdusuarioOrigen }, "NonClusteredIndex-20230905-162055");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Documento)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.FehaAlarma).HasColumnType("date");
            entity.Property(e => e.IdStatus)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.IdusuarioOrigen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Tramitada).HasColumnName("tramitada");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.TbAlerta)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAlertas_TbAlertasStatus");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbAlerta)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAlertas_TbDatosEmpresa");

            entity.HasOne(d => d.IdusuarioOrigenNavigation).WithMany(p => p.TbAlerta)
                .HasForeignKey(d => d.IdusuarioOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAlertas_TbUsuarios");
        });

        modelBuilder.Entity<TbAlertasDestinatario>(entity =>
        {
            entity.ToTable("TbAlertas_Destinatarios");

            entity.HasIndex(e => new { e.IdAlerta, e.IdUsuarioDestino }, "Destinatario_Duplicado").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.FechaTramitacion).HasColumnType("datetime");
            entity.Property(e => e.IdAlerta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuarioDestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdAlertaNavigation).WithMany(p => p.TbAlertasDestinatarios)
                .HasForeignKey(d => d.IdAlerta)
                .HasConstraintName("FK_TbAlertas_Destinatarios_TbAlertas");

            entity.HasOne(d => d.IdUsuarioDestinoNavigation).WithMany(p => p.TbAlertasDestinatarios)
                .HasForeignKey(d => d.IdUsuarioDestino)
                .HasConstraintName("FK_TbAlertas_Destinatarios_TbUsuarios");
        });

        modelBuilder.Entity<TbAlertasStatus>(entity =>
        {
            entity.HasKey(e => e.IdStatus);

            entity.ToTable("TbAlertasStatus");

            entity.Property(e => e.IdStatus)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Color).HasColumnName("color");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Predeterminado).HasColumnName("predeterminado");
        });

        modelBuilder.Entity<TbAlmacene>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen);

            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Almacenpordefecto).HasColumnName("ALMACENPORDEFECTO");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGOPOSTAL");
            entity.Property(e => e.Descatalogado).HasColumnName("DESCATALOGADO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");
            entity.Property(e => e.Provincia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROVINCIA");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbAlmacenes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAlmacenes_TBEmpresas");
        });

        modelBuilder.Entity<TbArticulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AlActualizarStock");
                    tb.HasTrigger("AlInsertarRegistro");
                });

            entity.HasIndex(e => new { e.IdEmpresa, e.Codigobarras1, e.Codigobarras2, e.Codigobarras3 }, "Codigo Barras Duplicado")
                .IsUnique()
                .HasFilter("([codigobarras1] IS NOT NULL AND [codigobarras2] IS NOT NULL AND [codigobarras3] IS NOT NULL)");

            entity.HasIndex(e => new { e.IdEmpresa, e.Referencia }, "NonClusteredIndex-20181109-182814").IsUnique();

            entity.HasIndex(e => e.Descripcion, "NonClusteredIndex-20181113-155628");

            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ALTO");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ANCHO");
            entity.Property(e => e.CodigoIvaVenta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigobarras1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras1");
            entity.Property(e => e.Codigobarras2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras2");
            entity.Property(e => e.Codigobarras3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras3");
            entity.Property(e => e.CoidgoIvaCompra)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionAdicional)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ExcluirTarifa).HasColumnName("excluirTarifa");
            entity.Property(e => e.FechaModificacionPrecioVenta).HasColumnType("datetime");
            entity.Property(e => e.Fechacambiostock)
                .HasColumnType("datetime")
                .HasColumnName("fechacambiostock");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Hipervinculo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hipervinculo");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOrganizacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idfamilia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfamilia");
            entity.Property(e => e.Idmarca)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idmarca");
            entity.Property(e => e.Idsubfamilia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idsubfamilia");
            entity.Property(e => e.Idtipoarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idtipoarticulo");
            entity.Property(e => e.Idunidad)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idunidad");
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.Largo)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("LARGO");
            entity.Property(e => e.Loteado).HasColumnName("LOTEado");
            entity.Property(e => e.MaquinaModificaPrecioVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquinaregistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinaregistro");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("margen");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("PESO");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pvp");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("stock");
            entity.Property(e => e.UdsDefVentas)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(10, 3)");
            entity.Property(e => e.UltimoDto).HasColumnType("decimal(5, 4)");

            entity.HasOne(d => d.CodigoIvaVentaNavigation).WithMany(p => p.TbArticuloCodigoIvaVentaNavigations)
                .HasForeignKey(d => d.CodigoIvaVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbArticulos_TbIvas");

            entity.HasOne(d => d.CoidgoIvaCompraNavigation).WithMany(p => p.TbArticuloCoidgoIvaCompraNavigations)
                .HasForeignKey(d => d.CoidgoIvaCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbArticulos_TbIvas1");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbArticulos_TbDatosEmpresa");

            entity.HasOne(d => d.IdOrganizacionNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.IdOrganizacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbArticulos_TbOrganizacionArticulos");

            entity.HasOne(d => d.IdfamiliaNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.Idfamilia)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbArticulos_TbFamilias");

            entity.HasOne(d => d.IdmarcaNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.Idmarca)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbArticulos_TbMarcas");

            entity.HasOne(d => d.IdsubfamiliaNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.Idsubfamilia)
                .HasConstraintName("FK_TbArticulos_TbSubfamilias");

            entity.HasOne(d => d.IdtipoarticuloNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.Idtipoarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbArticulos_TbTiposArticulo");

            entity.HasOne(d => d.IdunidadNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.Idunidad)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbArticulos_TbUnidades");
        });

        modelBuilder.Entity<TbArticulosPack>(entity =>
        {
            entity.ToTable("TbArticulos_Pack");

            entity.HasIndex(e => new { e.IdArticulo, e.CodigoIvaCompra }, "Iva Compra Duplicado").IsUnique();

            entity.HasIndex(e => new { e.IdArticulo, e.CodigoIvaVenta }, "Iva Venta Duplicado").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoIvaCompra)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoIvaVenta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Preciobasecompra)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("PRECIOBASECOMPRA");
            entity.Property(e => e.Precioii)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PRECIOII");
            entity.Property(e => e.Precioiicompra)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PRECIOIICOMPRA");

            entity.HasOne(d => d.CodigoIvaCompraNavigation).WithMany(p => p.TbArticulosPackCodigoIvaCompraNavigations)
                .HasForeignKey(d => d.CodigoIvaCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbArticulos_Pack_TbIvas1");

            entity.HasOne(d => d.CodigoIvaVentaNavigation).WithMany(p => p.TbArticulosPackCodigoIvaVentaNavigations)
                .HasForeignKey(d => d.CodigoIvaVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbArticulos_Pack_TbIvas");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbArticulosPacks)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK_TbArticulos_Pack_TbArticulos");
        });

        modelBuilder.Entity<TbArticulosReferenciasCompra>(entity =>
        {
            entity.ToTable("TbArticulosReferenciasCompra");

            entity.HasIndex(e => new { e.Idarticulo, e.Idproveedor }, "NonClusteredIndex-20181114-170656").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("DTO1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("DTO2");
            entity.Property(e => e.Dto3)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("DTO3");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idproveedor)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idproveedor");
            entity.Property(e => e.Preciocompra).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbArticulosReferenciasCompras)
                .HasForeignKey(d => d.Idarticulo)
                .HasConstraintName("FK_TbArticulosReferenciasCompra_TbArticulos");

            entity.HasOne(d => d.IdproveedorNavigation).WithMany(p => p.TbArticulosReferenciasCompras)
                .HasForeignKey(d => d.Idproveedor)
                .HasConstraintName("FK_TbArticulosReferenciasCompra_TbClientes");
        });

        modelBuilder.Entity<TbAviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("despues_BORRAR_obra");
                    tb.HasTrigger("despues_actualizar_obra");
                    tb.HasTrigger("despues_insertar_obra");
                });

            entity.HasIndex(e => new { e.IdEmpresa, e.NumeroAviso, e.SerieAviso }, "NonClusteredIndex-20181120-163043").IsUnique();

            entity.HasIndex(e => new { e.IdEmpresa, e.FechaAviso }, "NonClusteredIndex-20181121-113212");

            entity.HasIndex(e => new { e.IdEmpresa, e.Incidencia }, "NonClusteredIndex-20181121-170023");

            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroTrabajo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Certificacion).HasColumnName("certificacion");
            entity.Property(e => e.CodigoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Factura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("factura");
            entity.Property(e => e.Facturar).HasColumnName("facturar");
            entity.Property(e => e.FechaAviso).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.Garantia).HasColumnName("garantia");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iddireccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddireccion");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddiseño");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.ImporteAviso).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ImporteCompraAviso).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Incidencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaquinaUso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modocalculoiva).HasColumnName("modocalculoiva");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeMosobreMat)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("PorcentajeMOsobreMAT");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Rutadocumentos)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RUTADOCUMENTOS");
            entity.Property(e => e.SerieAviso)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoProvinciaNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.CodigoProvincia)
                .HasConstraintName("FK_TbAvisos_TbProvincias");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_TbClientes");

            entity.HasOne(d => d.IdDelegacionNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.IdDelegacion)
                .HasConstraintName("FK_TbAvisos_TbClientesDelegaciones");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_TbDatosEmpresa");

            entity.HasOne(d => d.IdObraNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.IdObra)
                .HasConstraintName("FK_TbAvisos_TbObras");

            entity.HasOne(d => d.IddireccionNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.Iddireccion)
                .HasConstraintName("FK_TbAvisos_TbClientesDirecciones");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbAvisos)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_TbUsuarios");
        });

        modelBuilder.Entity<TbAvisosOperario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TbAvisos_operarios_1");

            entity.ToTable("TbAvisos_operarios");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Engarantia).HasColumnName("ENGARANTIA");
            entity.Property(e => e.FechaHoraIntervencion).HasColumnType("datetime");
            entity.Property(e => e.FicheroFirma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HorasIntervencion).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Preciohora)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preciohora");

            entity.HasOne(d => d.IdAvisoNavigation).WithMany(p => p.TbAvisosOperarios)
                .HasForeignKey(d => d.IdAviso)
                .HasConstraintName("FK_TbAvisos_operarios_TbAvisos");

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbAvisosOperarios)
                .HasForeignKey(d => d.IdOperario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_operarios_TbOperarios");
        });

        modelBuilder.Entity<TbBanco>(entity =>
        {
            entity.HasKey(e => e.IdBanco);

            entity.HasIndex(e => new { e.Cuentacontable, e.Idempresa }, "NonClusteredIndex-20190205-171729")
                .IsUnique()
                .HasFilter("([cuentacontable] IS NOT NULL)");

            entity.Property(e => e.IdBanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bic)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("bic");
            entity.Property(e => e.ConciliadoHasta).HasColumnType("date");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cuentacontable");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaExportado).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO");
            entity.Property(e => e.Iban)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("iban");
            entity.Property(e => e.IdacreedorSepaB2b)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("IdacreedorSepaB2B");
            entity.Property(e => e.IdacreedorSepaTransferencias)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Idacreedorsepa)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("idacreedorsepa");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Instrumentolocal).HasColumnName("INSTRUMENTOLOCAL");
            entity.Property(e => e.Metalico).HasColumnName("metalico");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Predeterminado).HasColumnName("predeterminado");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUNTOVENTA");
            entity.Property(e => e.Sufijo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sufijo");
            entity.Property(e => e.TextoContabilidadCobro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TextoContabilidadPago)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbBancos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbBancos_TbDatosEmpresa");

            entity.HasOne(d => d.TbPuntosVentum).WithMany(p => p.TbBancos)
                .HasForeignKey(d => new { d.Puntoventa, d.Idempresa })
                .HasConstraintName("FK_TbBancos_TbPuntosVenta");
        });

        modelBuilder.Entity<TbBancosTpv>(entity =>
        {
            entity.HasKey(e => new { e.IdBanco, e.IdTpv });

            entity.ToTable("TbBancosTPV");

            entity.Property(e => e.IdBanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTpv)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cuentadescuadres)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTADESCUADRES");
            entity.Property(e => e.IdformaPago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idgrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDGRUPO");
            entity.Property(e => e.Idmodopago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDMODOPAGO");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Seriecaja)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERIECAJA");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.TbBancosTpvs)
                .HasForeignKey(d => d.IdBanco)
                .HasConstraintName("FK_TbBancosTPV_TbBancos");

            entity.HasOne(d => d.IdTpvNavigation).WithMany(p => p.TbBancosTpvs)
                .HasForeignKey(d => d.IdTpv)
                .HasConstraintName("FK_TbBancosTPV_TbTPV");

            entity.HasOne(d => d.IdformaPagoNavigation).WithMany(p => p.TbBancosTpvs)
                .HasForeignKey(d => d.IdformaPago)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbBancosTPV_TbFormasPago");

            entity.HasOne(d => d.IdmodopagoNavigation).WithMany(p => p.TbBancosTpvs)
                .HasForeignKey(d => d.Idmodopago)
                .HasConstraintName("FK_TbBancosTPV_TbModosPago");
        });

        modelBuilder.Entity<TbBic>(entity =>
        {
            entity.HasKey(e => e.CodigoBanco);

            entity.ToTable("TbBic");

            entity.Property(e => e.CodigoBanco)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BIC");
        });

        modelBuilder.Entity<TbCabeceraFabDe>(entity =>
        {
            entity.HasIndex(e => new { e.Idarticulo, e.Lote, e.Tipo }, "NdxLoteDuplicado")
                .IsUnique()
                .HasFilter("([lote] IS NOT NULL)");

            entity.HasIndex(e => e.Idnumero, "NonClusteredIndex-20220623-130535").IsUnique();

            entity.HasIndex(e => new { e.Idarticulo, e.NumeroSerie, e.Tipo }, "ndxNumeroSerieDuplicado")
                .IsUnique()
                .HasFilter("([NumeroSerie] IS NOT NULL)");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CosteFabDes).HasColumnType("decimal(11, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaFinFabricacion).HasColumnType("datetime");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("FECHACADUCIDAD");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idnumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idnumero");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Merma)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("MERMA");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.UdsFabDes).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("UNIDADES");
            entity.Property(e => e.Unidadesmerma)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("UNIDADESMERMA");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbCabeceraFabDes)
                .HasForeignKey(d => d.Idalmacen)
                .HasConstraintName("FK_TbCabeceraFabDes_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbCabeceraFabDes)
                .HasForeignKey(d => d.Idarticulo)
                .HasConstraintName("FK_TbCabeceraFabDes_TbArticulos");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbCabeceraFabDes)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraFabDes_TbUsuarios");
        });

        modelBuilder.Entity<TbCabeceraMensaje>(entity =>
        {
            entity.ToTable("TbCabeceraMensaje");

            entity.HasIndex(e => new { e.IdEmpresa, e.Asunto }, "NonClusteredIndex-20200629-111513");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Asunto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdForo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuarioOrigen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbCabeceraMensajes)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbCabeceraMensaje_TbDatosEmpresa");

            entity.HasOne(d => d.IdUsuarioOrigenNavigation).WithMany(p => p.TbCabeceraMensajes)
                .HasForeignKey(d => d.IdUsuarioOrigen)
                .HasConstraintName("FK_TbCabeceraMensaje_TbUsuarios");
        });

        modelBuilder.Entity<TbCabeceraMovimientoAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento);

            entity.ToTable("TbCabeceraMovimientoAlmacen");

            entity.HasIndex(e => new { e.IdEmpresa, e.FechaMovimiento }, "NonClusteredIndex-20190115-172813");

            entity.Property(e => e.IdMovimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaMovimiento).HasColumnType("date");
            entity.Property(e => e.IdAlmacenDestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAlmacenOrigen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAlmacenDestinoNavigation).WithMany(p => p.TbCabeceraMovimientoAlmacenIdAlmacenDestinoNavigations)
                .HasForeignKey(d => d.IdAlmacenDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraMovimientoAlmacen_TbAlmacenes1");

            entity.HasOne(d => d.IdAlmacenOrigenNavigation).WithMany(p => p.TbCabeceraMovimientoAlmacenIdAlmacenOrigenNavigations)
                .HasForeignKey(d => d.IdAlmacenOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraMovimientoAlmacen_TbAlmacenes");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbCabeceraMovimientoAlmacens)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraMovimientoAlmacen_TBEmpresas");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCabeceraMovimientoAlmacens)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraMovimientoAlmacen_TBUsuarios");
        });

        modelBuilder.Entity<TbCabeceraPedido>(entity =>
        {
            entity.HasKey(e => e.Idpedido);

            entity.ToTable("TbCabeceraPedido");

            entity.HasIndex(e => new { e.Numeropedido, e.Seriepedido, e.Idempresa, e.Tipo }, "NonClusteredIndex-20181220-125631").IsUnique();

            entity.HasIndex(e => new { e.Fecha, e.Idempresa, e.Tipo }, "NonClusteredIndex-20181220-125651");

            entity.Property(e => e.Idpedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpedido");
            entity.Property(e => e.Codigoestado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGOESTADO");
            entity.Property(e => e.DatosDescarga)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Documentorecibido).HasColumnName("DOCUMENTORECIBIDO");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaPrevistaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("FECHAIMPRESION");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Iddireccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDIRECCION");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("mantenerdetalleiva");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modocalculoiva).HasColumnName("modocalculoiva");
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Numeropedido).HasColumnName("numeropedido");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");
            entity.Property(e => e.Seriepedido)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriepedido");
            entity.Property(e => e.Supedido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("supedido");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalbase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbase");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Totalimpuestos)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("totalimpuestos");
            entity.Property(e => e.Totalpedido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalpedido");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbClientes");

            entity.HasOne(d => d.IddelegacionNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Iddelegacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbClientesSucursales");

            entity.HasOne(d => d.IddireccionNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Iddireccion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbClientesDirecciones");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IddocumentoNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Iddocumento)
                .HasConstraintName("FK_TbCabeceraPedido_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Idobra)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbObras");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbUsuarios");

            entity.HasOne(d => d.TbPedidosEstado).WithMany(p => p.TbCabeceraPedidos)
                .HasForeignKey(d => new { d.Codigoestado, d.Idempresa, d.Tipo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPedido_TbEstadosPedidos");
        });

        modelBuilder.Entity<TbCabeceraPresupuesto>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("TbCabeceraPresupuesto");

            entity.HasIndex(e => e.IdAviso, "Aviso-Duplicado")
                .IsUnique()
                .HasFilter("([idaviso] IS NOT NULL)");

            entity.HasIndex(e => new { e.Numerodocumento, e.Seriedocumento, e.Idempresa }, "NonClusteredIndex-20181205-175440").IsUnique();

            entity.HasIndex(e => new { e.FechaDocumento, e.Idempresa }, "NonClusteredIndex-20181210-110322");

            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BeneficioIndustrial).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.CampoLibre1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CarpetaRuta)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("carpeta_ruta");
            entity.Property(e => e.CertificacionAorigen).HasColumnName("CertificacionAOrigen");
            entity.Property(e => e.FechaAceptacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.GastosGenerales).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdClausula)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idclasificacion");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idestado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDESTADO");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.ImporteBeneficioIndustrial).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImporteGastosGenerales).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("mantenerdetalleiva");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modocalculoiva).HasColumnName("modocalculoiva");
            entity.Property(e => e.Numerodocumento).HasColumnName("numerodocumento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Porcentajefacturado)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("porcentajefacturado");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Seriedocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriedocumento");
            entity.Property(e => e.TotalBase).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalImpuestos).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalPresupuesto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Ultimaversion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ultimaversion");
            entity.Property(e => e.Versionaceptada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERSIONACEPTADA");

            entity.HasOne(d => d.IdAvisoNavigation).WithOne(p => p.TbCabeceraPresupuesto)
                .HasForeignKey<TbCabeceraPresupuesto>(d => d.IdAviso)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbAvisos");

            entity.HasOne(d => d.IdClausulaNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.IdClausula)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbClausulasDocumentos");

            entity.HasOne(d => d.IdclasificacionNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idclasificacion)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbClasificacion");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbPotenciales");

            entity.HasOne(d => d.Idcliente1).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbClientes");

            entity.HasOne(d => d.IddelegacionNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Iddelegacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbClientesDelegaciones");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbDatosEmpresa");

            entity.HasOne(d => d.IdestadoNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idestado)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbPresupuestosEstados");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idobra)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbObras");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbCabeceraPresupuestos)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraPresupuesto_TbUsuarios");
        });

        modelBuilder.Entity<TbCabeceraPresupuestoDocumento>(entity =>
        {
            entity.ToTable("TbCabeceraPresupuesto_Documentos");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbCabeceraPresupuestoDocumentos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbCabeceraPresupuesto_Documentos_TbCabeceraPresupuesto");
        });

        modelBuilder.Entity<TbCabeceraRemesa>(entity =>
        {
            entity.HasKey(e => new { e.NumRemesa, e.IdEmpresa });

            entity.ToTable("TbCabeceraRemesa");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnticipoAcuenta).HasColumnName("AnticipoACuenta");
            entity.Property(e => e.Cuaderno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cuaderno");
            entity.Property(e => e.Fechacargo)
                .HasColumnType("date")
                .HasColumnName("fechacargo");
            entity.Property(e => e.Fechaconfeccion)
                .HasColumnType("date")
                .HasColumnName("fechaconfeccion");
            entity.Property(e => e.Idbanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idbanco");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Tipo34)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO34");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbCabeceraRemesas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraRemesa_TbDatosEmpresa");

            entity.HasOne(d => d.IdbancoNavigation).WithMany(p => p.TbCabeceraRemesas)
                .HasForeignKey(d => d.Idbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraRemesa_TbBancos");
        });

        modelBuilder.Entity<TbCabeceraTarifa>(entity =>
        {
            entity.HasKey(e => e.IdTarifa);

            entity.ToTable("TbCabeceraTarifa");

            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaInicio).HasColumnType("date");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Ivaincluido).HasColumnName("IVAINCLUIDO");
            entity.Property(e => e.Tarifageneral).HasColumnName("tarifageneral");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbCabeceraTarifas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraTarifa_TBEmpresas");
        });

        modelBuilder.Entity<TbCaja>(entity =>
        {
            entity.HasKey(e => e.Idcaja);

            entity.HasIndex(e => new { e.NumeroCaja, e.SerieCaja, e.Idempresa }, "NonClusteredIndex-20220429-115800").IsUnique();

            entity.HasIndex(e => new { e.Idempresa, e.Fecharegistro }, "NonClusteredIndex-20220504-180112");

            entity.Property(e => e.Idcaja)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcaja");
            entity.Property(e => e.Cambio)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("cambio");
            entity.Property(e => e.Descuadre)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("DESCUADRE");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idbanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idbanco");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SaldoFinal).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.SerieCaja)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdbancoNavigation).WithMany(p => p.TbCajas)
                .HasForeignKey(d => d.Idbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCajas_TbBancos");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbCajas)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCajas_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbCajas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCajas_TBEmpresas");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbCajas)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCajas_TbUsuarios");
        });

        modelBuilder.Entity<TbCapitulo>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCapitulo, e.Version, e.IdDocumento }).HasName("PK_TbCapitulos_1");

            entity.HasIndex(e => e.Proyecto, "NonClusteredIndex-20220527-161243");

            entity.Property(e => e.CodigoCapitulo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Capitulo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Imprimirtotal).HasColumnName("imprimirtotal");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROYECTO");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbCapitulos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbCapitulos_TbCabeceraPresupuesto");
        });

        modelBuilder.Entity<TbClasificacion>(entity =>
        {
            entity.HasKey(e => e.Idclasificacion).HasName("PK_TbClasificacionClientes");

            entity.ToTable("TbClasificacion");

            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idclasificacion");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clasificacion");
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbClasificacions)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbClasificacion_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbClasificacionesApunte>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TbClausulasContrato>(entity =>
        {
            entity.HasKey(e => e.IdClausula);

            entity.ToTable("TbClausulasContrato");

            entity.Property(e => e.IdClausula)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Clausula).HasColumnType("text");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbClausulasContratos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbClausulasContrato_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbClausulasDocumento>(entity =>
        {
            entity.HasKey(e => e.IdClausula);

            entity.Property(e => e.IdClausula)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Clausula).HasColumnType("text");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbClausulasDocumentos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbClausulasDocumentos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente);

            entity.ToTable(tb => tb.HasTrigger("Mod_Clientes"));

            entity.HasIndex(e => new { e.Tipo, e.Dni, e.Idempresa }, "NonClusteredIndex-20161118-130233").IsUnique();

            entity.HasIndex(e => new { e.Cuentacontable, e.Idempresa }, "NonClusteredIndex-20161121-105441")
                .IsUnique()
                .HasFilter("([cuentacontable] IS NOT NULL)");

            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.CodigoAdministracion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Contracuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTRACUENTACONTABLE");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTACONTABLE");
            entity.Property(e => e.Cuerpomensajeemail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUERPOMENSAJEEMAIL");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Diafijopago1).HasColumnName("DIAFIJOPAGO1");
            entity.Property(e => e.Diafijopago2).HasColumnName("DIAFIJOPAGO2");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpresaoParticular)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaExportadoContabilidad).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Forzariva).HasColumnName("forzariva");
            entity.Property(e => e.IdEstadoCartera)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdFormaPago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idadministrador)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idadministrador");
            entity.Property(e => e.Idbanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDBANCO");
            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idclasificacion");
            entity.Property(e => e.Iddiseñofactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑOFACTURA");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idmodopago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDMODOPAGO");
            entity.Property(e => e.Idruta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idruta");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Incluir347).HasColumnName("INCLUIR347");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnName("modificado");
            entity.Property(e => e.ModoFacturacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Observacionesfactura)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrganoGestor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrganoProponente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pais");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUNTOVENTA");
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("RETENCION");
            entity.Property(e => e.Riesgo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RIESGO");
            entity.Property(e => e.SerieFacturacion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Seriealbaran)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERIEALBARAN");
            entity.Property(e => e.SoporteFactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoporteFActura");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnidadTramitadora)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Web)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("WEB");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbIvas");

            entity.HasOne(d => d.CodigoProvinciaNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.CodigoProvincia)
                .HasConstraintName("FK_TbClientes_TbProvincias");

            entity.HasOne(d => d.CodigoRetencionNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.CodigoRetencion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbRetenciones");

            entity.HasOne(d => d.IdEstadoCarteraNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.IdEstadoCartera)
                .HasConstraintName("FK_TbClientes_TbEstadosCartera");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbFormasPago");

            entity.HasOne(d => d.IdadministradorNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idadministrador)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbAdministadoresFincas");

            entity.HasOne(d => d.IdbancoNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idbanco)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbBancos");

            entity.HasOne(d => d.IdclasificacionNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idclasificacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbClasificacion");

            entity.HasOne(d => d.IddiseñofacturaNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Iddiseñofactura)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientes_TbDatosEmpresa");

            entity.HasOne(d => d.IdmodopagoNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idmodopago)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbModosPago");

            entity.HasOne(d => d.IdrutaNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idruta)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientes_TbRutas");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientes_TbUsuarios");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.Pais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientes_TbPaises");

            entity.HasOne(d => d.TbPlanContable).WithMany(p => p.TbClientes)
                .HasForeignKey(d => new { d.Contracuentacontable, d.Idempresa })
                .HasConstraintName("FK_TbClientes_TbPlanContable");

            entity.HasOne(d => d.TbPuntosVentum).WithMany(p => p.TbClientes)
                .HasForeignKey(d => new { d.Puntoventa, d.Idempresa })
                .HasConstraintName("FK_TbClientes_TbPuntosVenta");
        });

        modelBuilder.Entity<TbClientesContacto>(entity =>
        {
            entity.HasKey(e => e.IdContacto);

            entity.Property(e => e.IdContacto)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesContactos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesContactos_TbClientes");
        });

        modelBuilder.Entity<TbClientesCuentasBancaria>(entity =>
        {
            entity.HasKey(e => e.Idcuenta);

            entity.Property(e => e.Idcuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcuenta");
            entity.Property(e => e.Bic)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("bic");
            entity.Property(e => e.CuentaExtraComunitaria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fechafirmamandato)
                .HasColumnType("datetime")
                .HasColumnName("fechafirmamandato");
            entity.Property(e => e.Iban)
                .HasMaxLength(28)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IBAN");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Pagoperiodico).HasColumnName("pagoperiodico");
            entity.Property(e => e.Pais)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAIS");
            entity.Property(e => e.Predeterminada).HasColumnName("predeterminada");
            entity.Property(e => e.Referenciamandato)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referenciamandato");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesCuentasBancaria)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientesCuentasBancarias_TbClientes");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.TbClientesCuentasBancaria)
                .HasForeignKey(d => d.Pais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientesCuentasBancarias_TbPaises");
        });

        modelBuilder.Entity<TbClientesDelegacione>(entity =>
        {
            entity.HasKey(e => e.Iddelegacion).HasName("PK_TbClientesSucursales");

            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.CodigoAdministracion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoPROVINCIA");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGOPOSTAL");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idcuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCUENTA");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OrganoGestor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OrganoProponente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Recargoequivalencia).HasColumnName("RECARGOEQUIVALENCIA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UnidadTramitadora)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoProvinciaNavigation).WithMany(p => p.TbClientesDelegaciones)
                .HasForeignKey(d => d.CodigoProvincia)
                .HasConstraintName("FK_TbClientesDelegaciones_TbProvincias");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.TbClientesDelegaciones)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientesDelegaciones_TbCabeceraTarifa");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesDelegaciones)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientesDelegaciones_TbClientes");

            entity.HasOne(d => d.IdcuentaNavigation).WithMany(p => p.TbClientesDelegaciones)
                .HasForeignKey(d => d.Idcuenta)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientesDelegaciones_TbClientesCuentasBancarias");
        });

        modelBuilder.Entity<TbClientesDireccione>(entity =>
        {
            entity.HasKey(e => e.Iddireccion);

            entity.Property(e => e.Iddireccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddireccion");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoprovincia");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Predeterminado).HasColumnName("predeterminado");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono2");

            entity.HasOne(d => d.CodigoprovinciaNavigation).WithMany(p => p.TbClientesDirecciones)
                .HasForeignKey(d => d.Codigoprovincia)
                .HasConstraintName("FK_TbClientesDirecciones_TbProvincias");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesDirecciones)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesDirecciones_TbClientes");
        });

        modelBuilder.Entity<TbClientesDocumento>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesDocumentos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesDocumentos_TbClientes");
        });

        modelBuilder.Entity<TbClientesFacturacionPeriodica>(entity =>
        {
            entity.ToTable("TbClientesFacturacionPeriodica");

            entity.HasIndex(e => e.Agrupacion, "NonClusteredIndex-20230908-105256");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Agrupacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("agrupacion");
            entity.Property(e => e.Concepto)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("precio");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("unidades");
            entity.Property(e => e.Unidades2)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades2");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbClientesFacturacionPeriodicas)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientesFacturacionPeriodica_TbArticulos");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesFacturacionPeriodicas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesFacturacionPeriodica_TbClientes");

            entity.HasOne(d => d.IddelegacionNavigation).WithMany(p => p.TbClientesFacturacionPeriodicas)
                .HasForeignKey(d => d.Iddelegacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbClientesFacturacionPeriodica_TbClientesDelegaciones");
        });

        modelBuilder.Entity<TbClientesRutasDocumento>(entity =>
        {
            entity.HasKey(e => e.IdRuta);

            entity.Property(e => e.IdRuta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionRuta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesRutasDocumentos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesRutasDocumentos_TbClientes");
        });

        modelBuilder.Entity<TbClientesTarifa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TbTarifasCliente");

            entity.ToTable("TbClientesTarifa");

            entity.HasIndex(e => new { e.Idcliente, e.Idtarifa }, "NonClusteredIndex-20181117-101807").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.DescuentoSobreDescuentoProveedor).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idtarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idtarifa");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesTarifas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesTarifa_TbClientes");

            entity.HasOne(d => d.IdtarifaNavigation).WithMany(p => p.TbClientesTarifas)
                .HasForeignKey(d => d.Idtarifa)
                .HasConstraintName("FK_TbClientesTarifa_TbCabeceraTarifa");
        });

        modelBuilder.Entity<TbClientesTarifaDto>(entity =>
        {
            entity.ToTable("TbClientesTarifaDto");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("descuento");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddescuento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddescuento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbClientesTarifaDtos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_TbClientesTarifaDto_TbClientes");

            entity.HasOne(d => d.IddescuentoNavigation).WithMany(p => p.TbClientesTarifaDtos)
                .HasForeignKey(d => d.Iddescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbClientesTarifaDto_TbTiposDescuento");
        });

        modelBuilder.Entity<TbContrato>(entity =>
        {
            entity.HasKey(e => e.Idcontrato);

            entity.Property(e => e.Idcontrato)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcontrato");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dnipersonafisica)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNIPERSONAFISICA");
            entity.Property(e => e.Documento).HasColumnName("documento");
            entity.Property(e => e.Fechaenviooutlook)
                .HasColumnType("datetime")
                .HasColumnName("fechaenviooutlook");
            entity.Property(e => e.Fechafin)
                .HasColumnType("date")
                .HasColumnName("fechafin");
            entity.Property(e => e.Fechafirma)
                .HasColumnType("date")
                .HasColumnName("fechafirma");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("date")
                .HasColumnName("fechainicio");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdGm)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.MgdomicilioEntrega)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MGDomicilioEntrega");
            entity.Property(e => e.MgdomicilioRecogida)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MGDomicilioRecogida");
            entity.Property(e => e.MgespecificacionesEmbalaje)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MGEspecificacionesEmbalaje");
            entity.Property(e => e.MginstalacionElectrodomesticos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MGInstalacionElectrodomesticos");
            entity.Property(e => e.MgmediosTecnicos)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MGMediosTecnicos");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("periodicidad");
            entity.Property(e => e.Personafisica)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PERSONAFISICA");
            entity.Property(e => e.Refcontrato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("refcontrato");

            entity.HasOne(d => d.IdGmNavigation).WithMany(p => p.TbContratos)
                .HasForeignKey(d => d.IdGm)
                .HasConstraintName("FK_TbContratos_MGGuardaMuebles");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbContratos)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbContratos_TbClientes");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbContratos)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbContratos_TbUsuarios");
        });

        modelBuilder.Entity<TbCuentasCorreo>(entity =>
        {
            entity.HasKey(e => e.IdCuenta);

            entity.ToTable("TbCuentasCorreo");

            entity.Property(e => e.IdCuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Alto).HasColumnName("ALTO");
            entity.Property(e => e.Ancho).HasColumnName("ANCHO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Firma).HasColumnName("FIRMA");
            entity.Property(e => e.Html).HasColumnName("html");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Predeterminado).HasColumnName("PREDETERMINADO");
            entity.Property(e => e.Puerto).HasColumnName("puerto");
            entity.Property(e => e.ServidorSmtp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ServidorSMTP");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbCuentasCorreoCarpeta>(entity =>
        {
            entity.ToTable("TbCuentasCorreo_Carpetas");

            entity.HasIndex(e => new { e.Idcuenta, e.Maquina }, "MaquinaDuplicada").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdcuentaNavigation).WithMany(p => p.TbCuentasCorreoCarpeta)
                .HasForeignKey(d => d.Idcuenta)
                .HasConstraintName("FK_TbCuentasCorreo_Carpetas_TbCuentasCorreo");
        });

        modelBuilder.Entity<TbDatosEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK_TbEmpresas");

            entity.ToTable("TbDatosEmpresa");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Administrador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADMINISTRADOR");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO2");
            entity.Property(e => e.Autogenerarasientosgolden).HasColumnName("AUTOGENERARASIENTOSGOLDEN");
            entity.Property(e => e.CodigoPostalSocial)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Codigoempresaa3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGOEMPRESAA3");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CuentaCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DireccionSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idcuentacorreo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcuentacorreo");
            entity.Property(e => e.Inactiva).HasColumnName("inactiva");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocalidadSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Nif)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nifadministrador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NIFADMINISTRADOR");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreFiscal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombrecomercial)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("NOMBRECOMERCIAL");
            entity.Property(e => e.Predeterminada).HasColumnName("predeterminada");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProvinciaSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Skin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skin");
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Texto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TEXTO");
            entity.Property(e => e.Tipoempresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPOEMPRESA");
            entity.Property(e => e.TraspasoContabilidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Versiona3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("VERSIONA3");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("web");

            entity.HasOne(d => d.IdcuentacorreoNavigation).WithMany(p => p.TbDatosEmpresas)
                .HasForeignKey(d => d.Idcuentacorreo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDatosEmpresa_TbCuentasCorreo");
        });

        modelBuilder.Entity<TbDestinatariosMensaje>(entity =>
        {
            entity.HasKey(e => new { e.IdCabeceraMensaje, e.IdUsuarioDestino });

            entity.ToTable("TbDestinatariosMensaje");

            entity.Property(e => e.IdCabeceraMensaje)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuarioDestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaLectura).HasColumnType("datetime");

            entity.HasOne(d => d.IdCabeceraMensajeNavigation).WithMany(p => p.TbDestinatariosMensajes)
                .HasForeignKey(d => d.IdCabeceraMensaje)
                .HasConstraintName("FK_TbDestinatariosMensaje_TbCabeceraMensaje");

            entity.HasOne(d => d.IdUsuarioDestinoNavigation).WithMany(p => p.TbDestinatariosMensajes)
                .HasForeignKey(d => d.IdUsuarioDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDestinatariosMensaje_TbUsuarios");
        });

        modelBuilder.Entity<TbDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK_TbAvisos_Material");

            entity.ToTable("TbDetalle", tb =>
                {
                    tb.HasTrigger("Actualizar_Detalle");
                    tb.HasTrigger("Borrar_Detalle");
                    tb.HasTrigger("Insertar_Detalle");
                    tb.HasTrigger("despues_actualizar");
                    tb.HasTrigger("despues_borrar");
                    tb.HasTrigger("despues_insertar");
                });

            entity.HasIndex(e => new { e.IdArticulo, e.Lote }, "NdxLoteyArticulo");

            entity.HasIndex(e => e.Idlineapedido, "NonClusteredIndex-20190110-124504");

            entity.HasIndex(e => new { e.Idfactura, e.Idvehiculo }, "NonClusteredIndex-20220818-135340");

            entity.HasIndex(e => e.Agrupacion, "NonClusteredIndex-20230908-105054");

            entity.Property(e => e.IdDetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Agrupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Alto).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigoretencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoretencion");
            entity.Property(e => e.Contracuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuentacontable");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.Engarantia).HasColumnName("ENGARANTIA");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.Idavisodestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idavisodestino");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Idlineapedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idlineapedido");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOBRA");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOPERARIO");
            entity.Property(e => e.Idvehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idvehiculo");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Importeii).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Lineaoculta).HasColumnName("lineaoculta");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioIi)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PrecioII");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROYECTO");
            entity.Property(e => e.Recargo)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("recargo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("retencion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbAvisos_Material_TbIvas");

            entity.HasOne(d => d.CodigoretencionNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Codigoretencion)
                .HasConstraintName("FK_TbDetalle_TbRetenciones");

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.IdAlmacen)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbAvisos_Material_TbAlmacenes");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbAvisos_Material_TbArticulos");

            entity.HasOne(d => d.IdAvisoNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.IdAviso)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbDetalle_TbAvisos");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbAvisos_Material_TbCabeceraTarifa");

            entity.HasOne(d => d.IdalbaranNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Idalbaran)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbDetalle_TBCabeceraAlbaran");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Idfactura)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbDetalle_TBCabeceraFactura");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Idobra)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetalle_TbObras");

            entity.HasOne(d => d.IdoperarioNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Idoperario)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetalle_TbOperarios");

            entity.HasOne(d => d.IdvehiculoNavigation).WithMany(p => p.TbDetalles)
                .HasForeignKey(d => d.Idvehiculo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetalle_TbVehiculos");
        });

        modelBuilder.Entity<TbDetalleCertificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdDetallePresupuesto, e.IdDetalleFactura });

            entity.ToTable("TbDetalleCertificacion");

            entity.Property(e => e.IdDetallePresupuesto)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDetalleFactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdDetalleFacturaNavigation).WithMany(p => p.TbDetalleCertificacions)
                .HasForeignKey(d => d.IdDetalleFactura)
                .HasConstraintName("FK_TbDetalleCertificacion_TbDetalle");

            entity.HasOne(d => d.IdDetallePresupuestoNavigation).WithMany(p => p.TbDetalleCertificacions)
                .HasForeignKey(d => d.IdDetallePresupuesto)
                .HasConstraintName("FK_TbDetalleCertificacion_TbDetallePresupuesto");
        });

        modelBuilder.Entity<TbDetalleContrato>(entity =>
        {
            entity.ToTable("TbDetalleContrato");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IdContrato)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImporteIvaIncluido).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PrecioUnidad).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbDetalleContratos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetalleContrato_TbIvas");

            entity.HasOne(d => d.IdContratoNavigation).WithMany(p => p.TbDetalleContratos)
                .HasForeignKey(d => d.IdContrato)
                .HasConstraintName("FK_TbDetalleContrato_TbContratos");
        });

        modelBuilder.Entity<TbDetalleDtoFactura>(entity =>
        {
            entity.ToTable("TbDetalleDtoFactura");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Descuento).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Iddescuento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddescuento");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IddescuentoNavigation).WithMany(p => p.TbDetalleDtoFacturas)
                .HasForeignKey(d => d.Iddescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetalleDtoFactura_TbTiposDescuento");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.TbDetalleDtoFacturas)
                .HasForeignKey(d => d.Idfactura)
                .HasConstraintName("FK_TbDetalleDtoFactura_TBCabeceraFactura");
        });

        modelBuilder.Entity<TbDetalleFabDe>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.HasIndex(e => new { e.IdArticulo, e.Numeroserie }, "NonClusteredIndex-20220328-170029").HasFilter("([numeroserie] IS NOT NULL)");

            entity.HasIndex(e => new { e.IdCabecera, e.IdArticulo, e.Idalmacen, e.Lote }, "lote-repetido")
                .IsUnique()
                .HasFilter("([lote] IS NOT NULL)");

            entity.HasIndex(e => new { e.IdArticulo, e.Lote, e.Idalmacen }, "ndxlote").HasFilter("([lote] IS NOT NULL)");

            entity.HasIndex(e => new { e.IdCabecera, e.IdArticulo, e.Numeroserie }, "numero serie repetido")
                .IsUnique()
                .HasFilter("([numeroserie] IS NOT NULL)");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCabecera)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("importe");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Numeroserie)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numeroserie");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("porcentaje");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("precio");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbDetalleFabDes)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetalleFabDes_TbArticulos");

            entity.HasOne(d => d.IdCabeceraNavigation).WithMany(p => p.TbDetalleFabDes)
                .HasForeignKey(d => d.IdCabecera)
                .HasConstraintName("FK_TbDetalleFabDes_TbCabeceraFabDes");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbDetalleFabDes)
                .HasForeignKey(d => d.Idalmacen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetalleFabDes_TbAlmacenes");
        });

        modelBuilder.Entity<TbDetalleMovimientoAlmacen>(entity =>
        {
            entity.ToTable("TbDetalleMovimientoAlmacen");

            entity.HasIndex(e => new { e.Idmovimiento, e.IdArticulo, e.LoteSerie }, "NdxArticuloLoteRepetido")
                .IsUnique()
                .HasFilter("([lote_Serie] IS NOT NULL)");

            entity.HasIndex(e => new { e.Idmovimiento, e.IdArticulo, e.Serie }, "NdxNumeroSerieDuplicado")
                .IsUnique()
                .HasFilter("([serie] IS NOT NULL)");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaCaducidad).HasColumnType("date");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idmovimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Incidencias)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LoteSerie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE_serie");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Serie)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("UNIDADES");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unidadmedida");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbDetalleMovimientoAlmacens)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK_TbDetalleMovimientoAlmacen_TbArticulos");

            entity.HasOne(d => d.IdmovimientoNavigation).WithMany(p => p.TbDetalleMovimientoAlmacens)
                .HasForeignKey(d => d.Idmovimiento)
                .HasConstraintName("FK_TbDetalleMovimientoAlmacen_TbCabeceraMovimientoAlmacen");
        });

        modelBuilder.Entity<TbDetalleParteOperario>(entity =>
        {
            entity.ToTable("TbDetalleParteOperario");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Concepto)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdParte)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idobra0)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra0");
            entity.Property(e => e.Idreferencia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idreferencia");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.PrecioHora).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Preciocoste)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PRECIOCOSTE");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROYECTO");
            entity.Property(e => e.Proyecto0)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("proyecto0");

            entity.HasOne(d => d.IdParteNavigation).WithMany(p => p.TbDetalleParteOperarios)
                .HasForeignKey(d => d.IdParte)
                .HasConstraintName("FK_TbDetalleParteOperario_TbParteOperario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbDetalleParteOperarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetalleParteOperario_TbUsuarios");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.TbDetalleParteOperarios)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_TbDetalleParteOperario_TbVehiculos");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbDetalleParteOperarios)
                .HasForeignKey(d => d.Idobra)
                .HasConstraintName("FK_TbDetalleParteOperario_TbObras");

            entity.HasOne(d => d.IdreferenciaNavigation).WithMany(p => p.TbDetalleParteOperarios)
                .HasForeignKey(d => d.Idreferencia)
                .HasConstraintName("FK_TbDetalleParteOperario_TbReferenciasPartes");
        });

        modelBuilder.Entity<TbDetallePedido>(entity =>
        {
            entity.ToTable("TbDetallePedido");

            entity.HasIndex(e => e.Idpedidocliente, "NonClusteredIndex-20220510-184536")
                .IsUnique()
                .HasFilter("([idpedidocliente] IS NOT NULL)");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Alto).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dto)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("DTO1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("DTO2");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idpedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpedido");
            entity.Property(e => e.Idpedidocliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpedidocliente");
            entity.Property(e => e.Idtarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTARIFA");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("importe");
            entity.Property(e => e.Importeii)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("importeii");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Lineaoculta).HasColumnName("lineaoculta");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("precio");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Precioii)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioii");
            entity.Property(e => e.Propuesta).HasColumnName("PROPUESTA");
            entity.Property(e => e.Recargo)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("recargo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Unidades).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.UnidadesRecibidas).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoivaNavigation).WithMany(p => p.TbDetallePedidos)
                .HasForeignKey(d => d.Codigoiva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetallePedido_TbIvas");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbDetallePedidos)
                .HasForeignKey(d => d.Idalmacen)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetallePedido_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbDetallePedidos)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetallePedido_TbArticulos");

            entity.HasOne(d => d.IdpedidoNavigation).WithMany(p => p.TbDetallePedidos)
                .HasForeignKey(d => d.Idpedido)
                .HasConstraintName("FK_TbDetallePedido_TbCabeceraPedido");

            entity.HasOne(d => d.IdtarifaNavigation).WithMany(p => p.TbDetallePedidos)
                .HasForeignKey(d => d.Idtarifa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetallePedido_TbCabeceraTarifa");
        });

        modelBuilder.Entity<TbDetallePerfil>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalle, e.IdPerfil });

            entity.ToTable("TbDetallePerfil");

            entity.Property(e => e.IdDetalle)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdPerfil)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Acceso).HasColumnName("acceso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grupo)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.TbDetallePerfils)
                .HasForeignKey(d => d.IdPerfil)
                .HasConstraintName("FK_TbDetallePerfil_TbPerfiles");
        });

        modelBuilder.Entity<TbDetallePresupuesto>(entity =>
        {
            entity.ToTable("TbDetallePresupuesto");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Alto).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Cantidadcertificar)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("CANTIDADCERTIFICAR");
            entity.Property(e => e.CodigoCapitulo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoSubCapituloTabla)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoSubcapitulo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionAdicional)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.FechaVersion).HasColumnType("date");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Imagen).HasColumnType("image");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ImporteIi)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ImporteII");
            entity.Property(e => e.Imprimirimportes).HasColumnName("imprimirimportes");
            entity.Property(e => e.Incrementogeneral)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("INCREMENTOGENERAL");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("MARGEN");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioIi)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PrecioII");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Recargo).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbDetallePresupuesto_TbIvas");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetallePresupuesto_TbArticulos");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbDetallePresupuesto_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbDetallePresupuesto_TbCabeceraTarifa");

            entity.HasOne(d => d.TbCapitulo).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => new { d.CodigoCapitulo, d.Version, d.IdDocumento })
                .HasConstraintName("FK_TbDetallePresupuesto_TbCapitulos");

            entity.HasOne(d => d.TbSubCapitulo).WithMany(p => p.TbDetallePresupuestos)
                .HasForeignKey(d => new { d.CodigoCapitulo, d.CodigoSubCapituloTabla, d.Version, d.IdDocumento })
                .HasConstraintName("FK_TbDetallePresupuesto_TbSubCapitulos");
        });

        modelBuilder.Entity<TbDetalleRetorno>(entity =>
        {
            entity.HasKey(e => e.IdRetorno);

            entity.ToTable("TbDetalle_retornos");

            entity.HasIndex(e => e.Fecha, "NonClusteredIndex-20200907-105606");

            entity.Property(e => e.IdRetorno)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdDetalleAlbaranCompra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDetalleAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdDetalleAvisoNavigation).WithMany(p => p.TbDetalleRetornos)
                .HasForeignKey(d => d.IdDetalleAviso)
                .HasConstraintName("FK_TbDetalle_retornos_TbDetalle");
        });

        modelBuilder.Entity<TbDiseñosSubInforme>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdDiseño, e.Idempresa });

            entity.Property(e => e.Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.PlantillaSubInforme).HasColumnType("text");

            entity.HasOne(d => d.IdDiseñoNavigation).WithMany(p => p.TbDiseñosSubInformes)
                .HasForeignKey(d => d.IdDiseño)
                .HasConstraintName("FK_TbDiseñosSubInformes_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.TbDiseñosSubInformes)
                .HasForeignKey(d => new { d.Id, d.Idempresa })
                .HasConstraintName("FK_TbDiseñosSubInformes_TbTiposDocumentoInternos");
        });

        modelBuilder.Entity<TbDocumentosCoste>(entity =>
        {
            entity.ToTable("TbDocumentosCoste");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdRegistroNavigation).WithMany(p => p.TbDocumentosCostes)
                .HasForeignKey(d => d.IdRegistro)
                .HasConstraintName("FK_TbDocumentosCoste_TbLineasCoste");
        });

        modelBuilder.Entity<TbEntradasTallerEstado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.HasIndex(e => new { e.IdEmpresa, e.Accion }, "AccionDuplicada")
                .IsUnique()
                .HasFilter("([ACCION]<>'O')");

            entity.Property(e => e.IdEstado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Accion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbEntradasTallerEstados)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbEntradasTallerEstados_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbEntradasTallerPieza>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Facturar).HasColumnName("facturar");
            entity.Property(e => e.IdEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iddetallepedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddetallepedido");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pedir).HasColumnName("pedir");
            entity.Property(e => e.Precioventa)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("precioventa");

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.TbEntradasTallerPiezas)
                .HasForeignKey(d => d.IdEntrada)
                .HasConstraintName("FK_TbEntradasTallerPiezas_TbentradasTaller");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbEntradasTallerPiezas)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbEntradasTallerPiezas_TbArticulos");

            entity.HasOne(d => d.IddetallepedidoNavigation).WithMany(p => p.TbEntradasTallerPiezas)
                .HasForeignKey(d => d.Iddetallepedido)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbEntradasTallerPiezas_TbDetallePedido");
        });

        modelBuilder.Entity<TbEntradasTallerSeguimiento>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TbEntradasTallerSeguimiento");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEstado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.TbEntradasTallerSeguimientos)
                .HasForeignKey(d => d.IdEntrada)
                .HasConstraintName("FK_TbEntradasTallerSeguimiento_TbentradasTaller");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TbEntradasTallerSeguimientos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbEntradasTallerSeguimiento_TbEntradasTallerEstados");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbEntradasTallerSeguimientos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbEntradasTallerSeguimiento_TbUsuarios");
        });

        modelBuilder.Entity<TbEstadosCartera>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCartera);

            entity.ToTable("TbEstadosCartera");

            entity.Property(e => e.IdEstadoCartera)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbEstadosCarteras)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbEstadosCartera_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbFabricacionDespieze>(entity =>
        {
            entity.ToTable("TbFabricacionDespieze");

            entity.HasIndex(e => e.IdPlantilla, "NonClusteredIndex-20220325-173416").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdPlantilla)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbFabricacionDespiezes)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK_TbFabricacionDespieze_TbArticulos");
        });

        modelBuilder.Entity<TbFabricacionDespiezeDetalle>(entity =>
        {
            entity.HasKey(e => e.Iddetalle).HasName("PK_TbFrabicacionDespiezeDetalle");

            entity.ToTable("TbFabricacionDespiezeDetalle");

            entity.Property(e => e.Iddetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.IdPlantilla)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdarticuloDetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PorcentajeDespieze).HasColumnType("decimal(7, 4)");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades");

            entity.HasOne(d => d.IdPlantillaNavigation).WithMany(p => p.TbFabricacionDespiezeDetalles)
                .HasPrincipalKey(p => p.IdPlantilla)
                .HasForeignKey(d => d.IdPlantilla)
                .HasConstraintName("FK_TbFabricacionDespiezeDetalle_TbFabricacionDespieze");

            entity.HasOne(d => d.IdarticuloDetalleNavigation).WithMany(p => p.TbFabricacionDespiezeDetalles)
                .HasForeignKey(d => d.IdarticuloDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbFrabicacionDespiezeDetalle_TbArticulos");
        });

        modelBuilder.Entity<TbFabricacionSalida>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.HasIndex(e => e.Lote, "NonClusteredIndex-20220422-094007").HasFilter("([lote] IS NOT NULL)");

            entity.HasIndex(e => e.FechaSalida, "NonClusteredIndex-20220422-094033");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.CosteUnidad).HasColumnType("decimal(11, 2)");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.FechaSalida).HasColumnType("date");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.IdFabricacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Serie)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades");

            entity.HasOne(d => d.IdFabricacionNavigation).WithMany(p => p.TbFabricacionSalida)
                .HasForeignKey(d => d.IdFabricacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbFabricacionSalidas_TbCabeceraFabDes");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbFabricacionSalida)
                .HasForeignKey(d => d.Idalmacen)
                .HasConstraintName("FK_TbFabricacionSalidas_TbAlmacenes");
        });

        modelBuilder.Entity<TbFacturaCertificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdFactura, e.IdDocumento });

            entity.ToTable("TbFacturaCertificacion");

            entity.Property(e => e.IdFactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbFacturaCertificacions)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbFacturaCertificacion_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbFacturaCertificacions)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK_TbFacturaCertificacion_TBCabeceraFactura");
        });

        modelBuilder.Entity<TbFacturaImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TbFacturaimpuestos");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Base).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Bruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdFactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.RecargoEquivalencia).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalIva).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalRetencion).HasColumnType("decimal(9, 2)");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbFacturaImpuestos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbFacturaImpuestos_TbIvas");

            entity.HasOne(d => d.CodigoRetencionNavigation).WithMany(p => p.TbFacturaImpuestos)
                .HasForeignKey(d => d.CodigoRetencion)
                .HasConstraintName("FK_TbFacturaImpuestos_Tbretenciones");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbFacturaImpuestos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK_TbFacturaImpuestos_TbCabeceraFactura");
        });

        modelBuilder.Entity<TbFamilia>(entity =>
        {
            entity.HasKey(e => e.IdFamilia);

            entity.Property(e => e.IdFamilia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("margen");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbFamilia)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbFamilias_TBEmpresas");
        });

        modelBuilder.Entity<TbFormasPago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago);

            entity.ToTable("TbFormasPago");

            entity.Property(e => e.IdFormaPago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoDatisa)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Descatalogado).HasColumnName("DESCATALOGADO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Diafijo).HasColumnName("diafijo");
            entity.Property(e => e.Diafijo2).HasColumnName("diafijo2");
            entity.Property(e => e.IdEstadoCartea)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Inicio).HasColumnName("inicio");
            entity.Property(e => e.Intervalo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("intervalo");
            entity.Property(e => e.Ivapagatitular).HasColumnName("IVAPAGATITULAR");
            entity.Property(e => e.Observacionesfactura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacionesfactura");
            entity.Property(e => e.Salto).HasColumnName("salto");
            entity.Property(e => e.Ultimodiames).HasColumnName("ULTIMODIAMES");
            entity.Property(e => e.Vencimientos).HasColumnName("vencimientos");

            entity.HasOne(d => d.IdEstadoCarteaNavigation).WithMany(p => p.TbFormasPagos)
                .HasForeignKey(d => d.IdEstadoCartea)
                .HasConstraintName("FK_TbFormasPago_TbEstadosCartera");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbFormasPagos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbFormasPago_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbFormato>(entity =>
        {
            entity.HasKey(e => e.Skin);

            entity.Property(e => e.Skin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skin");
        });

        modelBuilder.Entity<TbHistorialNumerosSerie>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("TbHistorialNumerosSerie");

            entity.HasIndex(e => e.NumeroLoteSerie, "NonClusteredIndex-20191212-104301");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.IdDetalleDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumeroLoteSerie)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDetalleDocumentoNavigation).WithMany(p => p.TbHistorialNumerosSeries)
                .HasForeignKey(d => d.IdDetalleDocumento)
                .HasConstraintName("FK_TbHistorialNumerosSerie_TbAvisos_Material");
        });

        modelBuilder.Entity<TbIva>(entity =>
        {
            entity.HasKey(e => e.Codigoiva).HasName("PK_TBivas");

            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Clase)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Claserecargo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CLASERECARGO");
            entity.Property(e => e.Claserecibidas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLASERECIBIDAS");
            entity.Property(e => e.CodigoA3)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IntraR)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Intra_R");
            entity.Property(e => e.IntraS)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Intra_S");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.Predeterminado).HasColumnName("predeterminado");
            entity.Property(e => e.RecargoEquivalencia).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Subclase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SUBCLASE");
            entity.Property(e => e.TextoContabilidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TextoContabilidadRecargo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipodatisa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPODATISA");
            entity.Property(e => e.Tipodatisarecargo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPODATISARECARGO");
            entity.Property(e => e.Tipoimpuestodatisa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TIPOIMPUESTODATISA");
            entity.Property(e => e.Tipoiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPOIVA");

            entity.HasOne(d => d.IntraRNavigation).WithMany(p => p.InverseIntraRNavigation)
                .HasForeignKey(d => d.IntraR)
                .HasConstraintName("FK_TbIvas_TbIvas");

            entity.HasOne(d => d.IntraSNavigation).WithMany(p => p.InverseIntraSNavigation)
                .HasForeignKey(d => d.IntraS)
                .HasConstraintName("FK_TbIvas_TbIvas1");
        });

        modelBuilder.Entity<TbIvasCuentasContable>(entity =>
        {
            entity.HasKey(e => new { e.Codigoiva, e.Idempresa });

            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Ccivarepercutido)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ccivarepercutido");
            entity.Property(e => e.Ccivasoportado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ccivasoportado");
            entity.Property(e => e.Ccrerepercutido)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ccrerepercutido");
            entity.Property(e => e.Ccsoportado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ccsoportado");

            entity.HasOne(d => d.CodigoivaNavigation).WithMany(p => p.TbIvasCuentasContables)
                .HasForeignKey(d => d.Codigoiva)
                .HasConstraintName("FK_TbIvasCuentasContables_TbIvas");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbIvasCuentasContables)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbIvasCuentasContables_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbLayout>(entity =>
        {
            entity.HasKey(e => new { e.CodigoFormulario, e.IdUsuario });

            entity.ToTable("TbLayout");

            entity.Property(e => e.CodigoFormulario)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Layout).HasColumnType("text");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbLayouts)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_TbLayout_TbUsuarios");
        });

        modelBuilder.Entity<TbLineasCoste>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("TbLineasCoste");

            entity.HasIndex(e => new { e.Fecha, e.Idempresa }, "NonClusteredIndex-20220530-182329");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaProximoMto).HasColumnType("date");
            entity.Property(e => e.IdReferencia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdResponsable)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTaller)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTipoMantenimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iddetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDETALLE");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Kilometros).HasColumnName("kilometros");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdReferenciaNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.IdReferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbLineasCoste_TbReferenciasGastos");

            entity.HasOne(d => d.IdResponsableNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.IdResponsable)
                .HasConstraintName("FK_TbLineasCoste_TbResponsables");

            entity.HasOne(d => d.IdTallerNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.IdTaller)
                .HasConstraintName("FK_TbLineasCoste_TbTalleres");

            entity.HasOne(d => d.IdTipoMantenimientoNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.IdTipoMantenimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbLineasCoste_TbTiposMantenimiento");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_TbLineasCoste_TbVehiculos");

            entity.HasOne(d => d.IddetalleNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.Iddetalle)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbLineasCoste_TbDetalle");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbLineasCostes)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbLineasCoste_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbMapeo>(entity =>
        {
            entity.ToTable("TbMapeo");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Sql)
                .HasColumnType("text")
                .HasColumnName("SQL");
        });

        modelBuilder.Entity<TbMaquinasCliente>(entity =>
        {
            entity.HasKey(e => e.Idmaquina);

            entity.ToTable("TbMaquinasCliente");

            entity.HasIndex(e => new { e.IdCliente, e.NumeroSerie }, "NonClusteredIndex-20221125-184205").IsUnique();

            entity.HasIndex(e => e.Referencia, "NonClusteredIndex-20221202-112644");

            entity.Property(e => e.Idmaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompra).HasColumnType("date");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdModelo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbMaquinasClientes)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMaquinasCliente_TbClientes");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.TbMaquinasClientes)
                .HasForeignKey(d => d.IdModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMaquinasCliente_TbModelos");
        });

        modelBuilder.Entity<TbMaquinasClienteCaracterística>(entity =>
        {
            entity.HasKey(e => e.Idcaracteristica);

            entity.HasIndex(e => new { e.Idmaquina, e.Descripcion }, "Característica_maquina_duplicada").IsUnique();

            entity.Property(e => e.Idcaracteristica)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcaracteristica");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idmaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdmaquinaNavigation).WithMany(p => p.TbMaquinasClienteCaracterísticas)
                .HasForeignKey(d => d.Idmaquina)
                .HasConstraintName("FK_TbMaquinasClienteCaracterísticas_TbMaquinasCliente");
        });

        modelBuilder.Entity<TbMarca>(entity =>
        {
            entity.HasKey(e => e.Idmarca);

            entity.Property(e => e.Idmarca)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idmarca");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("LOGO");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbMarcas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMarcas_TBEmpresas");
        });

        modelBuilder.Entity<TbModelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo);

            entity.Property(e => e.IdModelo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Catalogo).HasColumnName("catalogo");
            entity.Property(e => e.Descatalogado).HasColumnName("DESCATALOGADO");
            entity.Property(e => e.IdMarca)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idtipomaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTIPOMAQUINA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombredocumento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.TbModelos)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbModelos_TbMarcas");

            entity.HasOne(d => d.IdtipomaquinaNavigation).WithMany(p => p.TbModelos)
                .HasForeignKey(d => d.Idtipomaquina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbModelos_TbTiposMaquina");
        });

        modelBuilder.Entity<TbModelosCaracteristica>(entity =>
        {
            entity.HasKey(e => e.Idcaracteristica);

            entity.HasIndex(e => new { e.Idmodelo, e.Descripcion }, "Caracteristica Duplicada").IsUnique();

            entity.Property(e => e.Idcaracteristica)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idmodelo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdmodeloNavigation).WithMany(p => p.TbModelosCaracteristicas)
                .HasForeignKey(d => d.Idmodelo)
                .HasConstraintName("FK_TbModelosCaracteristicas_TbModelos");
        });

        modelBuilder.Entity<TbModosPago>(entity =>
        {
            entity.HasKey(e => e.IdModoPago);

            entity.ToTable("TbModosPago");

            entity.Property(e => e.IdModoPago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Defectorecibobancario).HasColumnName("defectorecibobancario");
            entity.Property(e => e.Descatalogado).HasColumnName("DESCATALOGADO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Predetermida).HasColumnName("predetermida");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbModosPagos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbModosPago_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbMovimientosBancariosDocumento>(entity =>
        {
            entity.ToTable("TbMovimientosBancarios_Documentos");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.TbMovimientosBancariosDocumento)
                .HasForeignKey<TbMovimientosBancariosDocumento>(d => d.Id)
                .HasConstraintName("FK_TbMovimientosBancarios_Documentos_Tbmovimientosbancarios");
        });

        modelBuilder.Entity<TbNumero>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK_Tb");

            entity.Property(e => e.Numero)
                .ValueGeneratedNever()
                .HasColumnName("numero");
            entity.Property(e => e.Texto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("texto");
        });

        modelBuilder.Entity<TbObra>(entity =>
        {
            entity.HasIndex(e => new { e.Idempresa, e.Referencia }, "NonClusteredIndex-20221019-180821");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoprovincia");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Fechafinalizacion)
                .HasColumnType("date")
                .HasColumnName("FECHAFINALIZACION");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("date")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idoperario");
            entity.Property(e => e.Idtipoobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idtipoobra");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAQUINAUSO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Tfno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tfno");
            entity.Property(e => e.TotalCostes).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CodigoprovinciaNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.Codigoprovincia)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbObras_TbProvincias");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbObras_TbCabeceraTarifa");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_TbClientes");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbObras_TBEmpresas");

            entity.HasOne(d => d.IdoperarioNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.Idoperario)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbObras_TbOperarios");

            entity.HasOne(d => d.IdtipoobraNavigation).WithMany(p => p.TbObras)
                .HasForeignKey(d => d.Idtipoobra)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbObras_TbTiposObra");
        });

        modelBuilder.Entity<TbObrasCuenta>(entity =>
        {
            entity.HasKey(e => e.Idcuenta).HasName("PK_DefinicionCuentas");

            entity.ToTable("TbObras_Cuentas");

            entity.Property(e => e.Idcuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcuenta");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.DescripcionCuenta)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Formula)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.FormulaInterna)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Idgrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idgrupo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");

            entity.HasOne(d => d.IdgrupoNavigation).WithMany(p => p.TbObrasCuenta)
                .HasForeignKey(d => d.Idgrupo)
                .HasConstraintName("FK_TbObras_Cuentas_TbObras_Grupos");
        });

        modelBuilder.Entity<TbObrasDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DetalleObras");

            entity.ToTable("TbObras_Detalle");

            entity.HasIndex(e => new { e.Idobra, e.IdGrupo, e.IdSubGrupo, e.IdCuenta, e.Orden }, "NonClusteredIndex-20210713-110125").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Coste).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.DescripcionCuenta)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdSubGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.TextoLista)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbObrasDetalles)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_Detalle_TbObras_Cuentas");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.TbObrasDetalles)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_Detalle_TbObras_Grupos");

            entity.HasOne(d => d.IdSubGrupoNavigation).WithMany(p => p.TbObrasDetalles)
                .HasForeignKey(d => d.IdSubGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_Detalle_TbObras_Subgrupos");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbObrasDetalles)
                .HasForeignKey(d => d.Idobra)
                .HasConstraintName("FK_TbObras_Detalle_TbObras");
        });

        modelBuilder.Entity<TbObrasDetalleListum>(entity =>
        {
            entity.ToTable("TbObras_DetalleLista");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdLista)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TextoLista)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.TbObrasDetalleLista)
                .HasForeignKey(d => d.IdLista)
                .HasConstraintName("FK_TbObras_DetalleLista_TbObras_Listas");
        });

        modelBuilder.Entity<TbObrasDetalleObservacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DetalleObservaciones");

            entity.ToTable("TbObras_DetalleObservaciones");

            entity.HasIndex(e => new { e.Idobra, e.Proyecto }, "NonClusteredIndex-20220527-164516");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("proyecto");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbObrasDetalleObservaciones)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_DetalleObservaciones_TbObras_Cuentas");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.TbObrasDetalleObservaciones)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_DetalleObservaciones_TbObras_Grupos");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbObrasDetalleObservaciones)
                .HasForeignKey(d => d.Idobra)
                .HasConstraintName("FK_TbObras_DetalleObservaciones_TbObras");
        });

        modelBuilder.Entity<TbObrasDocumento>(entity =>
        {
            entity.ToTable("TbObras_Documentos");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdObraNavigation).WithMany(p => p.TbObrasDocumentos)
                .HasForeignKey(d => d.IdObra)
                .HasConstraintName("FK_TbObras_Documentos_TbObras");
        });

        modelBuilder.Entity<TbObrasGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasName("PK_GrupoCuentas");

            entity.ToTable("TbObras_Grupos");

            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.DescripcionGrupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdLista)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Sqltexto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SQLTEXTO");
            entity.Property(e => e.TextoAgrupacion)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdListaNavigation).WithMany(p => p.TbObrasGrupos)
                .HasForeignKey(d => d.IdLista)
                .HasConstraintName("FK_TbObras_Grupos_TbObras_Listas");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbObrasGrupos)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbObras_Grupos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbObrasLista>(entity =>
        {
            entity.HasKey(e => e.IdLista);

            entity.ToTable("TbObras_Listas");

            entity.Property(e => e.IdLista)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sqltexto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SQLTEXTO");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbObrasLista)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbObras_Listas_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbObrasPreciosCoste>(entity =>
        {
            entity.ToTable("TbObras_PreciosCoste");

            entity.HasIndex(e => new { e.IdGrupo, e.IdCuenta, e.IdSubGrupo }, "NonClusteredIndex-20210701-114709").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdSubGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrecioCoste).HasColumnType("decimal(11, 4)");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbObrasPreciosCostes)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_PreciosCoste_TbObras_Cuentas");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.TbObrasPreciosCostes)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK_TbObras_PreciosCoste_TbObras_Grupos");

            entity.HasOne(d => d.IdSubGrupoNavigation).WithMany(p => p.TbObrasPreciosCostes)
                .HasForeignKey(d => d.IdSubGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbObras_PreciosCoste_TbObras_Subgrupos");
        });

        modelBuilder.Entity<TbObrasSubgrupo>(entity =>
        {
            entity.HasKey(e => e.IdSubgrupo).HasName("PK_SubgrupoCuentas");

            entity.ToTable("TbObras_Subgrupos");

            entity.HasIndex(e => new { e.IdGrupo, e.Subgrupo }, "NonClusteredIndex-20210721-094130").IsUnique();

            entity.Property(e => e.IdSubgrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.IdGrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Subgrupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.TbObrasSubgrupos)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK_TbObras_Subgrupos_TbObras_Grupos");
        });

        modelBuilder.Entity<TbObservacionesRevision>(entity =>
        {
            entity.HasKey(e => e.IdObservaciones);

            entity.ToTable("TbObservacionesRevision");

            entity.Property(e => e.IdObservaciones)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Revision)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbObservacionesRevisions)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbObservacionesRevision_TbCabeceraPresupuesto");
        });

        modelBuilder.Entity<TbOperario>(entity =>
        {
            entity.HasKey(e => e.IdOperario);

            entity.HasIndex(e => new { e.IdEmpresa, e.Dni }, "NonClusteredIndex-20181129-103113")
                .IsUnique()
                .HasFilter("([dni] IS NOT NULL)");

            entity.HasIndex(e => new { e.Usuario, e.Password }, "NonClusteredIndex-20200225-121516")
                .IsUnique()
                .HasFilter("([Usuario] IS NOT NULL AND [password] IS NOT NULL)");

            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contrato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceIdcuentaObras)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enlace_idcuenta_obras");
            entity.Property(e => e.FechaAlta).HasColumnType("date");
            entity.Property(e => e.FechaBaja).HasColumnType("date");
            entity.Property(e => e.FechaUltimoReconocimiento).HasColumnType("date");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.HorarioMañana)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.HorarioSabados)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.HorarioTarde)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.IdDispositivo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Preciocoste)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PRECIOCOSTE");
            entity.Property(e => e.Preciohora)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preciohora");
            entity.Property(e => e.Provincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TarjetaSanitaria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EnlaceIdcuentaObrasNavigation).WithMany(p => p.TbOperarios)
                .HasForeignKey(d => d.EnlaceIdcuentaObras)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbOperarios_TbObras_Cuentas");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbOperarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbOperarios_TbDatosEmpresa");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbOperarios)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbOperarios_TbArticulos");

            entity.HasOne(d => d.ProvinciaNavigation).WithMany(p => p.TbOperarios)
                .HasForeignKey(d => d.Provincia)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbOperarios_TbProvincias");
        });

        modelBuilder.Entity<TbOperariosCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdOperario });

            entity.ToTable("TbOperarios_Clientes");

            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fechafin)
                .HasColumnType("date")
                .HasColumnName("fechafin");
            entity.Property(e => e.Fechainicio).HasColumnType("date");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbOperariosClientes)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_TbOperarios_Clientes_TbClientes");

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbOperariosClientes)
                .HasForeignKey(d => d.IdOperario)
                .HasConstraintName("FK_TbOperarios_Clientes_TbOperarios");
        });

        modelBuilder.Entity<TbOperariosDocumento>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbOperariosDocumentos)
                .HasForeignKey(d => d.IdOperario)
                .HasConstraintName("FK_TbOperariosDocumentos_TbOperarios");
        });

        modelBuilder.Entity<TbOperariosRutasDocumento>(entity =>
        {
            entity.HasKey(e => e.IdRuta);

            entity.Property(e => e.IdRuta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionRuta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbOperariosRutasDocumentos)
                .HasForeignKey(d => d.IdOperario)
                .HasConstraintName("FK_TbOperariosRutasDocumentos_TbOperarios");
        });

        modelBuilder.Entity<TbOperariosVacacione>(entity =>
        {
            entity.HasIndex(e => new { e.IdOperario, e.Fecha }, "NonClusteredIndex-20181129-124756").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Motivo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbOperariosVacaciones)
                .HasForeignKey(d => d.IdOperario)
                .HasConstraintName("FK_TbOperariosVacaciones_TbOperarios");
        });

        modelBuilder.Entity<TbOrganizacionArticulo>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacion);

            entity.Property(e => e.IdOrganizacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Organizacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbOrganizacionArticulos)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbOrganizacionArticulos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPaise>(entity =>
        {
            entity.HasKey(e => e.CodigoPais);

            entity.Property(e => e.CodigoPais)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbParametrosFirma>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.TipoDocumento });

            entity.ToTable("TbParametrosFirma");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImagenFirma).HasColumnType("image");
            entity.Property(e => e.Llx).HasColumnName("llx");
            entity.Property(e => e.Lly).HasColumnName("lly");
            entity.Property(e => e.Rotacion).HasColumnName("rotacion");
            entity.Property(e => e.Urx).HasColumnName("urx");
            entity.Property(e => e.Ury).HasColumnName("ury");
            entity.Property(e => e.XimagenFirma).HasColumnName("XImagenFirma");
            entity.Property(e => e.YimagenFirma).HasColumnName("YImagenFirma");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbParametrosFirmas)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbParametrosFirma_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbParteOperario>(entity =>
        {
            entity.HasKey(e => e.IdParte);

            entity.ToTable("TbParteOperario");

            entity.HasIndex(e => new { e.IdEmpresa, e.FechaParte }, "NonClusteredIndex-20220720-130059");

            entity.HasIndex(e => new { e.IdEmpresa, e.Idnumero }, "NonClusteredIndex-20220816-111747").IsUnique();

            entity.Property(e => e.IdParte)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaParte).HasColumnType("date");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idnumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDNUMERO");
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Importecoste)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("importecoste");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbParteOperarios)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbParteOperario_TbDatosEmpresa");

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbParteOperarios)
                .HasForeignKey(d => d.IdOperario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbParteOperario_TbOperarios");
        });

        modelBuilder.Entity<TbPedidoImpuesto>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Base).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Bruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdPedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.RecargoEquivalencia).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.TotalIva).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalPedido).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(9, 2)");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbPedidoImpuestos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPedidoImpuestos_TbIvas");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.TbPedidoImpuestos)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK_TbPedidoImpuestos_TbCabeceraPedido");
        });

        modelBuilder.Entity<TbPedidosEstado>(entity =>
        {
            entity.HasKey(e => new { e.CodigoEstado, e.Idempresa, e.Tipo }).HasName("PK_TbEstadosPedidos");

            entity.ToTable("TbPedidosEstado");

            entity.Property(e => e.CodigoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Definicioncolor).HasColumnName("DEFINICIONCOLOR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Servido).HasColumnName("servido");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPedidosEstados)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbEstadosPedidos_TBEmpresas");
        });

        modelBuilder.Entity<TbPerfile>(entity =>
        {
            entity.HasKey(e => e.IdPerfil);

            entity.Property(e => e.IdPerfil)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPerfiles)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPerfiles_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPlanContable>(entity =>
        {
            entity.HasKey(e => new { e.Cuenta, e.Idempresa });

            entity.ToTable("TbPlanContable");

            entity.Property(e => e.Cuenta)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Fechaexportado).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPlanContables)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPlanContable_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPlantillasCuboCostesVehiculo>(entity =>
        {
            entity.HasKey(e => e.Idlayout);

            entity.Property(e => e.Idlayout)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDLAYOUT");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Strlayout)
                .HasColumnType("text")
                .HasColumnName("STRLAYOUT");
            entity.Property(e => e.Textototalgeneral)
                .HasMaxLength(25)
                .HasColumnName("TEXTOTOTALGENERAL");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbPlantillasCuboCostesVehiculos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbPlantillasCuboCostesVehiculos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPosicionamientoOperario>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("TbPosicionamientoOperario");

            entity.HasIndex(e => new { e.FechaRegistro, e.Idoperario }, "NonClusteredIndex-20200309-100705");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idoperario");
            entity.Property(e => e.Latitud).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.Longitud).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdoperarioNavigation).WithMany(p => p.TbPosicionamientoOperarios)
                .HasForeignKey(d => d.Idoperario)
                .HasConstraintName("FK_TbPosicionamientoOperario_TbOperarios");
        });

        modelBuilder.Entity<TbPotenciale>(entity =>
        {
            entity.HasKey(e => e.IdPotencial);

            entity.HasIndex(e => new { e.Dni, e.Idempresa }, "DNI-Duplicado")
                .IsUnique()
                .HasFilter("([dni] IS NOT NULL)");

            entity.HasIndex(e => new { e.Movil, e.Idempresa }, "Movil-Duplicado")
                .IsUnique()
                .HasFilter("([movil] IS NOT NULL)");

            entity.Property(e => e.IdPotencial)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoprovincia");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Fecharregistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharregistro");
            entity.Property(e => e.IdAccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGrupoPotencial)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idclasificacion");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nombrecomercial)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombrecomercial");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Web)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("web");

            entity.HasOne(d => d.IdAccionNavigation).WithMany(p => p.TbPotenciales)
                .HasForeignKey(d => d.IdAccion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbPotenciales_TbPotencialesEstados");

            entity.HasOne(d => d.IdGrupoPotencialNavigation).WithMany(p => p.TbPotenciales)
                .HasForeignKey(d => d.IdGrupoPotencial)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbPotenciales_TbPotencialesGrupos");

            entity.HasOne(d => d.IdclasificacionNavigation).WithMany(p => p.TbPotenciales)
                .HasForeignKey(d => d.Idclasificacion)
                .HasConstraintName("FK_TbPotenciales_TbClasificacion");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPotenciales)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbPotenciales_TbDatosEmpresa");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbPotenciales)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotenciales_TbUsuarios");
        });

        modelBuilder.Entity<TbPotencialesEstado>(entity =>
        {
            entity.HasKey(e => e.IdAccion);

            entity.Property(e => e.IdAccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Colorcalendario).HasColumnName("colorcalendario");
            entity.Property(e => e.Definicioncolor).HasColumnName("DEFINICIONCOLOR");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPotencialesEstados)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesEstados_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPotencialesGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupoPotencial);

            entity.Property(e => e.IdGrupoPotencial)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPotencialesGrupos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesGrupos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPotencialesSeguimiento>(entity =>
        {
            entity.ToTable("TbPotencialesSeguimiento");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaOperacion).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro).HasColumnType("datetime");
            entity.Property(e => e.IdAccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdPotencial)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAccionNavigation).WithMany(p => p.TbPotencialesSeguimientos)
                .HasForeignKey(d => d.IdAccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesSeguimiento_TbPotencialesEstados");

            entity.HasOne(d => d.IdPotencialNavigation).WithMany(p => p.TbPotencialesSeguimientos)
                .HasForeignKey(d => d.IdPotencial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesSeguimiento_TbPotenciales");

            entity.HasOne(d => d.IdPotencial1).WithMany(p => p.TbPotencialesSeguimientos)
                .HasForeignKey(d => d.IdPotencial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesSeguimiento_TbClientes");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbPotencialesSeguimientos)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPotencialesSeguimiento_TbUsuarios");
        });

        modelBuilder.Entity<TbPresupuestoImpuesto>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Base).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Bruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImporteBeneficioIndustrial).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImporteGastosGenerales).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.RecargoEquivalencia).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.TotalIva).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalPresupuesto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("version");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TbPresupuestoImpuestos)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPresupuestoImpuestos_TbIvas");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbPresupuestoImpuestos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TbPresupuestoImpuestos_TbCabeceraPresupuesto");
        });

        modelBuilder.Entity<TbPresupuestosEstado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.Property(e => e.IdEstado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Accion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPresupuestosEstados)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPresupuestosEstados_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbPrevisione>(entity =>
        {
            entity.HasKey(e => e.IdPrevision);

            entity.HasIndex(e => new { e.Mes, e.IdAcreedor }, "NdxMesAcreedor").IsUnique();

            entity.Property(e => e.IdPrevision)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdAcreedor)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idestado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idestado");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("IMPORTE");

            entity.HasOne(d => d.IdAcreedorNavigation).WithMany(p => p.TbPrevisiones)
                .HasForeignKey(d => d.IdAcreedor)
                .HasConstraintName("FK_TbPrevisiones_TbClientes");

            entity.HasOne(d => d.IdestadoNavigation).WithMany(p => p.TbPrevisiones)
                .HasForeignKey(d => d.Idestado)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbPrevisiones_TbEstadosCartera");
        });

        modelBuilder.Entity<TbPrevisionesTemporal>(entity =>
        {
            entity.HasKey(e => new { e.IdAcreedor, e.Mes });

            entity.ToTable("TbPrevisionesTemporal");

            entity.Property(e => e.IdAcreedor)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Idestado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idestado");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdAcreedorNavigation).WithMany(p => p.TbPrevisionesTemporals)
                .HasForeignKey(d => d.IdAcreedor)
                .HasConstraintName("FK_TbPrevisionesTemporal_TbClientes");

            entity.HasOne(d => d.IdestadoNavigation).WithMany(p => p.TbPrevisionesTemporals)
                .HasForeignKey(d => d.Idestado)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbPrevisionesTemporal_TbEstadosCartera");
        });

        modelBuilder.Entity<TbProgramacion>(entity =>
        {
            entity.HasKey(e => e.IdProgramacion);

            entity.ToTable("TbProgramacion");

            entity.Property(e => e.IdProgramacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoClasificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.Fechafin)
                .HasColumnType("datetime")
                .HasColumnName("fechafin");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbProgramacions)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbProgramacion_TbDatosEmpresa");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbProgramacions)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbProgramacion_TbUsuarios");

            entity.HasOne(d => d.TbProgramacionClasificacion).WithMany(p => p.TbProgramacions)
                .HasForeignKey(d => new { d.CodigoClasificacion, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbProgramacion_TbProgramacion_clasificacion");
        });

        modelBuilder.Entity<TbProgramacionClasificacion>(entity =>
        {
            entity.HasKey(e => new { e.CodigoClasificacion, e.IdEmpresa });

            entity.ToTable("TbProgramacion_clasificacion");

            entity.Property(e => e.CodigoClasificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Color).HasColumnName("color");
            entity.Property(e => e.Colorrejilla).HasColumnName("colorrejilla");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Predeterminada).HasColumnName("predeterminada");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbProgramacionClasificacions)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbProgramacion_clasificacion_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbProgramacionDiariaDetalle>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TbProgramacionDiaria_Detalle");

            entity.HasIndex(e => e.Combo, "NonClusteredIndex-20230210-174403");

            entity.HasIndex(e => new { e.IdDiario, e.IdOperario }, "NonClusteredIndex-20230213-161828").IsUnique();

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Combo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdDiario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra1)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra2)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra3)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra4)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra5)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idvehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idvehiculo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones3)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones4)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones5)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDiarioNavigation).WithMany(p => p.TbProgramacionDiariaDetalles)
                .HasForeignKey(d => d.IdDiario)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbProgramacionDiaria");

            entity.HasOne(d => d.IdObra1Navigation).WithMany(p => p.TbProgramacionDiariaDetalleIdObra1Navigations)
                .HasForeignKey(d => d.IdObra1)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbObras1");

            entity.HasOne(d => d.IdObra2Navigation).WithMany(p => p.TbProgramacionDiariaDetalleIdObra2Navigations)
                .HasForeignKey(d => d.IdObra2)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbObras");

            entity.HasOne(d => d.IdObra3Navigation).WithMany(p => p.TbProgramacionDiariaDetalleIdObra3Navigations)
                .HasForeignKey(d => d.IdObra3)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbObras2");

            entity.HasOne(d => d.IdObra4Navigation).WithMany(p => p.TbProgramacionDiariaDetalleIdObra4Navigations)
                .HasForeignKey(d => d.IdObra4)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbObras3");

            entity.HasOne(d => d.IdObra5Navigation).WithMany(p => p.TbProgramacionDiariaDetalleIdObra5Navigations)
                .HasForeignKey(d => d.IdObra5)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbObras4");

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TbProgramacionDiariaDetalles)
                .HasForeignKey(d => d.IdOperario)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbOperarios");

            entity.HasOne(d => d.IdvehiculoNavigation).WithMany(p => p.TbProgramacionDiariaDetalles)
                .HasForeignKey(d => d.Idvehiculo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbProgramacionDiaria_Detalle_TbVehiculos");
        });

        modelBuilder.Entity<TbProgramacionDiarium>(entity =>
        {
            entity.HasKey(e => e.IdDiario);

            entity.HasIndex(e => new { e.IdEmpresa, e.Fecha, e.Idusuario }, "Programacion_Duplicada").IsUnique();

            entity.Property(e => e.IdDiario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Publicacion).HasColumnType("datetime");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbProgramacionDiaria)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbProgramacionDiaria_TbDatosEmpresa");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbProgramacionDiaria)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbProgramacionDiaria_TbUsuarios");
        });

        modelBuilder.Entity<TbPropuestum>(entity =>
        {
            entity.HasKey(e => e.IdPropuesta);

            entity.Property(e => e.IdPropuesta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdDetallePedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDALMACEN");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idpiezataller)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpiezataller");
            entity.Property(e => e.Idproveedor)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Preciocompra)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompra");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDetallePedidoNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.IdDetallePedido)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbPropuesta_TbDetallePedido");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idalmacen)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbPropuesta_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbPropuesta_TbArticulos");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbPropuesta_TbDatosEmpresa");

            entity.HasOne(d => d.IdpiezatallerNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idpiezataller)
                .HasConstraintName("FK_TbPropuesta_TbEntradasTallerPiezas");

            entity.HasOne(d => d.IdproveedorNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idproveedor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbPropuesta_TbClientes");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbPropuesta)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK_TbPropuesta_TbUsuarios");
        });

        modelBuilder.Entity<TbProvincia>(entity =>
        {
            entity.HasKey(e => e.CodigoProvincia);

            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbPuntosVentum>(entity =>
        {
            entity.HasKey(e => new { e.PuntoVenta, e.Idempresa });

            entity.Property(e => e.PuntoVenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbPuntosVenta)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbPuntosVenta_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbReferenciasGasto>(entity =>
        {
            entity.HasKey(e => e.IdReferencia);

            entity.Property(e => e.IdReferencia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idtipomantenimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTIPOMANTENIMIENTO");
            entity.Property(e => e.Idunidad)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDUNIDAD");
            entity.Property(e => e.Medidasalto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEDIDASALTO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Predeterminado).HasColumnName("PREDETERMINADO");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Salto).HasColumnName("SALTO");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbReferenciasGastos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbReferenciasGastos_TbDatosEmpresa");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbReferenciasGastos)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbReferenciasGastos_TbArticulos");

            entity.HasOne(d => d.IdtipomantenimientoNavigation).WithMany(p => p.TbReferenciasGastos)
                .HasForeignKey(d => d.Idtipomantenimiento)
                .HasConstraintName("FK_TbReferenciasGastos_TbTiposMantenimiento");

            entity.HasOne(d => d.IdunidadNavigation).WithMany(p => p.TbReferenciasGastos)
                .HasForeignKey(d => d.Idunidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbReferenciasGastos_TbUnidades");
        });

        modelBuilder.Entity<TbReferenciasParte>(entity =>
        {
            entity.HasKey(e => e.IdReferencia);

            entity.Property(e => e.IdReferencia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Precio).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Referencia2)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbReferenciasPartes)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbReferenciasPartes_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbRepositorio>(entity =>
        {
            entity.ToTable("TbRepositorio");

            entity.HasIndex(e => new { e.Tipo, e.Documento, e.Repositorio, e.IdEmpresa }, "NonClusteredIndex-20230508-101105").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Documento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Formato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Repositorio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbRepositorios)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbRepositorio_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbResponsable>(entity =>
        {
            entity.HasKey(e => e.IdResponsable);

            entity.Property(e => e.IdResponsable)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOPERARIO");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbResponsables)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbResponsables_TbDatosEmpresa");

            entity.HasOne(d => d.IdoperarioNavigation).WithMany(p => p.TbResponsables)
                .HasForeignKey(d => d.Idoperario)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbResponsables_TbOperarios");
        });

        modelBuilder.Entity<TbRetencione>(entity =>
        {
            entity.HasKey(e => e.CodigoRetencion);

            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Clase)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Retencion).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.TextoContabilidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoDatisa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoDatisa");
        });

        modelBuilder.Entity<TbRetencionesCuentasContable>(entity =>
        {
            entity.HasKey(e => new { e.CodigoRetencion, e.IdEmpresa });

            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CuentaRetencionRepercutido)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CuentaRetencionSoportado)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoRetencionNavigation).WithMany(p => p.TbRetencionesCuentasContables)
                .HasForeignKey(d => d.CodigoRetencion)
                .HasConstraintName("FK_TbRetencionesCuentasContables_TbRetenciones");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbRetencionesCuentasContables)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbRetencionesCuentasContables_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbRuta>(entity =>
        {
            entity.HasKey(e => e.Idruta);

            entity.Property(e => e.Idruta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDruta");
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbRuta)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbRutas_TBEmpresas");
        });

        modelBuilder.Entity<TbSeriesDiseñoDocumento>(entity =>
        {
            entity.ToTable("TbSeriesDiseñoDocumento");

            entity.HasIndex(e => new { e.Seriefactura, e.Descripcion, e.Idempresa }, "NonClusteredIndex-20181119-170712").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Copias).HasColumnName("copias");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Iddiseñocopia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddiseñocopia");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Plantillafactura)
                .HasColumnType("text")
                .HasColumnName("plantillafactura");
            entity.Property(e => e.Predeterminada).HasColumnName("predeterminada");
            entity.Property(e => e.Seriefactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriefactura");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbSeriesDiseñoDocumentos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbSeriesDiseñoDocumento_TbDatosEmpresa");

            entity.HasOne(d => d.TbSeriesFactura).WithMany(p => p.TbSeriesDiseñoDocumentos)
                .HasForeignKey(d => new { d.Seriefactura, d.Idempresa })
                .HasConstraintName("FK_TbSeriesDiseñoDocumento_TbSeriesFactura");
        });

        modelBuilder.Entity<TbSeriesFactura>(entity =>
        {
            entity.HasKey(e => new { e.Seriefactura, e.Idempresa });

            entity.ToTable("TbSeriesFactura");

            entity.Property(e => e.Seriefactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriefactura");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Contador).HasColumnName("contador");
            entity.Property(e => e.Contracuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTRACUENTA");
            entity.Property(e => e.CuerpoOutlook)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Documento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("documento");
            entity.Property(e => e.Esobra).HasColumnName("esobra");
            entity.Property(e => e.FechaCierre).HasColumnType("date");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDALMACEN");
            entity.Property(e => e.Idtarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTARIFA");
            entity.Property(e => e.Inactiva).HasColumnName("inactiva");
            entity.Property(e => e.Layoutfactura)
                .HasColumnType("text")
                .HasColumnName("layoutfactura");
            entity.Property(e => e.Layoutfactura2)
                .HasColumnType("text")
                .HasColumnName("layoutfactura2");
            entity.Property(e => e.Predeterminada).HasColumnName("predeterminada");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUNTOVENTA");
            entity.Property(e => e.Seriedatisa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SERIEDATISA");
            entity.Property(e => e.Serierectificativa).HasColumnName("SERIERECTIFICATIVA");
            entity.Property(e => e.Tabletafirma).HasColumnName("TABLETAFIRMA");
            entity.Property(e => e.TextoContabilidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");

            entity.HasOne(d => d.CodigoivaNavigation).WithMany(p => p.TbSeriesFacturas)
                .HasForeignKey(d => d.Codigoiva)
                .HasConstraintName("FK_TbSeriesFactura_TbIvas");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbSeriesFacturas)
                .HasForeignKey(d => d.Idalmacen)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbSeriesFactura_TbAlmacenes");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbSeriesFacturas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbSeriesFactura_TbDatosEmpresa");

            entity.HasOne(d => d.IdtarifaNavigation).WithMany(p => p.TbSeriesFacturas)
                .HasForeignKey(d => d.Idtarifa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TbSeriesFactura_TbCabeceraTarifa");

            entity.HasOne(d => d.TbPuntosVentum).WithMany(p => p.TbSeriesFacturas)
                .HasForeignKey(d => new { d.Puntoventa, d.Idempresa })
                .HasConstraintName("FK_TbSeriesFactura_TbPuntosVenta");
        });

        modelBuilder.Entity<TbSubCapitulo>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCapitulo, e.CodigoSubCapitulo, e.Version, e.IdDocumento });

            entity.Property(e => e.CodigoCapitulo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoSubCapitulo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubCapitulo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TbCapitulo).WithMany(p => p.TbSubCapitulos)
                .HasForeignKey(d => new { d.CodigoCapitulo, d.Version, d.IdDocumento })
                .HasConstraintName("FK_TbSubCapitulos_TbCapitulos");
        });

        modelBuilder.Entity<TbSubfamilia>(entity =>
        {
            entity.HasKey(e => e.IdSubfamilia);

            entity.Property(e => e.IdSubfamilia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.IdFamilia)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("margen");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Subfamilia)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdFamiliaNavigation).WithMany(p => p.TbSubfamilia)
                .HasForeignKey(d => d.IdFamilia)
                .HasConstraintName("FK_TbSubfamilias_TbFamilias");
        });

        modelBuilder.Entity<TbTallere>(entity =>
        {
            entity.HasKey(e => e.IdTaller);

            entity.Property(e => e.IdTaller)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idacreedor)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDACREEDOR");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Taller)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdacreedorNavigation).WithMany(p => p.TbTalleres)
                .HasForeignKey(d => d.Idacreedor)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbTalleres_TbClientes");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbTalleres)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbTalleres_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTiposArticulo>(entity =>
        {
            entity.HasKey(e => e.IdtipoArticulo);

            entity.ToTable("TbTiposArticulo");

            entity.Property(e => e.IdtipoArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Contracuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuenta");
            entity.Property(e => e.Contracuentacompras)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuentacompras");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LlevaStock).HasColumnName("llevaStock");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Predeterminado).HasColumnName("PREDETERMINADO");
            entity.Property(e => e.TipoArticulo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoivaNavigation).WithMany(p => p.TbTiposArticulos)
                .HasForeignKey(d => d.Codigoiva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbTiposArticulo_TbIvas");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbTiposArticulos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbTiposArticulo_TBEmpresas");

            entity.HasOne(d => d.TbPlanContable).WithMany(p => p.TbTiposArticulos)
                .HasForeignKey(d => new { d.Contracuenta, d.Idempresa })
                .HasConstraintName("FK_TbTiposArticulo_TbPlanContable");
        });

        modelBuilder.Entity<TbTiposDescuento>(entity =>
        {
            entity.HasKey(e => e.Iddescuento).HasName("PK_TpTiposDescuento");

            entity.ToTable("TbTiposDescuento");

            entity.Property(e => e.Iddescuento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddescuento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbTiposDescuentos)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbTiposDescuento_TBEmpresas");
        });

        modelBuilder.Entity<TbTiposDocumentoInterno>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Idempresa });

            entity.Property(e => e.Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clasificacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Plantilla)
                .HasColumnType("text")
                .HasColumnName("PLANTILLA");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbTiposDocumentoInternos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbTiposDocumentoInternos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTiposMantenimiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoMantenimiento);

            entity.ToTable("TbTiposMantenimiento");

            entity.Property(e => e.IdTipoMantenimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdLayout)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Predeterminado).HasColumnName("predeterminado");
            entity.Property(e => e.ProximoMtoen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ProximoMTOen");
            entity.Property(e => e.TipoMantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbTiposMantenimientos)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TbTiposMantenimiento_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTiposMaquina>(entity =>
        {
            entity.HasKey(e => e.IdTipoMaquina);

            entity.ToTable("TbTiposMaquina");

            entity.Property(e => e.IdTipoMaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbTiposMaquinas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbTiposMaquina_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTiposObra>(entity =>
        {
            entity.HasKey(e => e.IdTipoObra);

            entity.ToTable("TbTiposObra");

            entity.Property(e => e.IdTipoObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbTiposObras)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_TbTiposObra_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTpv>(entity =>
        {
            entity.HasKey(e => e.IdPuntoVenta).HasName("PK_Tbtpv");

            entity.ToTable("TbTPV");

            entity.Property(e => e.IdPuntoVenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idPuntoVenta");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGOPOSTAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCALIDAD");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVINCIA");
            entity.Property(e => e.Skin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skin");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbTpvs)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbTPV_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbTpvUsuario>(entity =>
        {
            entity.ToTable("TbTPV_Usuarios");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdpuntVenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbTpvUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_TbTPV_Usuarios_TbUsuarios");

            entity.HasOne(d => d.IdpuntVentaNavigation).WithMany(p => p.TbTpvUsuarios)
                .HasForeignKey(d => d.IdpuntVenta)
                .HasConstraintName("FK_TbTPV_Usuarios_TbTPV");
        });

        modelBuilder.Entity<TbUnidade>(entity =>
        {
            entity.HasKey(e => e.Idunidad);

            entity.HasIndex(e => new { e.Idunidad, e.Unidad }, "NonClusteredIndex-20210330-132924").IsUnique();

            entity.Property(e => e.Idunidad)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descatalogada).HasColumnName("descatalogada");
            entity.Property(e => e.FactorConversion).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbUnidades)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbUnidades_TBEmpresas");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.HasIndex(e => new { e.Nombre, e.Idempresa }, "NonClusteredIndex-20161111-132141").IsUnique();

            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Contraseña)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Foto)
                .HasColumnType("image")
                .HasColumnName("foto");
            entity.Property(e => e.IdPerfil)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.TbUsuarios)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbUsuarios_TbPerfiles");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbUsuarios)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbUsuarios_TbDatosEmpresa");

            entity.HasOne(d => d.TbPuntosVentum).WithMany(p => p.TbUsuarios)
                .HasForeignKey(d => new { d.Puntoventa, d.Idempresa })
                .HasConstraintName("FK_TbUsuarios_TbPuntosVenta");
        });

        modelBuilder.Entity<TbVehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo);

            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bastidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASTIDOR");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Compañia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceIdcuentaObras)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enlace_idcuenta_obras");
            entity.Property(e => e.FechaAmortizacion).HasColumnType("date");
            entity.Property(e => e.FechaCompra).HasColumnType("date");
            entity.Property(e => e.FechaPrimeraMatriculacion).HasColumnType("date");
            entity.Property(e => e.Fechaitv)
                .HasColumnType("date")
                .HasColumnName("FECHAITV");
            entity.Property(e => e.Fechavencimientoseguro)
                .HasColumnType("date")
                .HasColumnName("FECHAVENCIMIENTOSEGURO");
            entity.Property(e => e.Foto)
                .HasColumnType("image")
                .HasColumnName("foto");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.ImporteAmortizado).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ImporteFijoAmortizacion).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ImporteMinimoAmortizacion).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Kilometrosiniciales).HasColumnName("kilometrosiniciales");
            entity.Property(e => e.Lugartrabajo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LUGARTRABAJO");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Numeropoliza)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NUMEROPOLIZA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PorAmortizacion).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Preciocompra)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("preciocompra");
            entity.Property(e => e.Preciohora)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PRECIOHORA");
            entity.Property(e => e.Precioseguro)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("PRECIOSEGURO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO");

            entity.HasOne(d => d.EnlaceIdcuentaObrasNavigation).WithMany(p => p.TbVehiculos)
                .HasForeignKey(d => d.EnlaceIdcuentaObras)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbVehiculos_TbObras_Cuentas");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbVehiculos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbVehiculos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbVehiculosAmortizacione>(entity =>
        {
            entity.ToTable("TbVehiculos_Amortizaciones");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaAmortizacion).HasColumnType("date");
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImporteAmortizacion).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.TbVehiculosAmortizaciones)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_TbVehiculos_Amortizaciones_TbVehiculos");
        });

        modelBuilder.Entity<TbVehiculosDocumento>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescripcionDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.TbVehiculosDocumentos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_TbVehiculosDocumentos_TbVehiculos");
        });

        modelBuilder.Entity<TbVehiculosParte>(entity =>
        {
            entity.HasKey(e => e.IdParte);

            entity.ToTable("TbVehiculos_partes");

            entity.Property(e => e.IdParte)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Conductor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaParte).HasColumnType("datetime");
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Responsabilidad)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.TbVehiculosPartes)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK_TbVehiculos_partes_TbVehiculos");
        });

        modelBuilder.Entity<TbalmacenesStock>(entity =>
        {
            entity.ToTable("TBAlmacenes_stock");

            entity.HasIndex(e => new { e.Idarticulo, e.Idalmacen }, "NonClusteredIndex-20230522-175918").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Fechainventario)
                .HasColumnType("datetime")
                .HasColumnName("fechainventario");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Minimo)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("minimo");
            entity.Property(e => e.Stock).HasColumnType("decimal(9, 3)");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbalmacenesStocks)
                .HasForeignKey(d => d.Idalmacen)
                .HasConstraintName("FK_TBAlmacenes_stock_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbalmacenesStocks)
                .HasForeignKey(d => d.Idarticulo)
                .HasConstraintName("FK_TBAlmacenes_stock_TbArticulos");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbalmacenesStocks)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBAlmacenes_stock_TbDatosEmpresa");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbalmacenesStocks)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBAlmacenes_stock_TBUsuarios");
        });

        modelBuilder.Entity<TbcabeceraAlbaran>(entity =>
        {
            entity.HasKey(e => e.Idalbaran);

            entity.ToTable("TBCabeceraAlbaran", tb =>
                {
                    tb.HasTrigger("Actualizar_CabeceraAlbaran");
                    tb.HasTrigger("Borrar_CabeceraAlbaran");
                });

            entity.HasIndex(e => new { e.Numeroalbaran, e.Seriealbaran, e.Idempresa, e.Tipo }, "NonClusteredIndex-20190107-120449").IsUnique();

            entity.HasIndex(e => new { e.FechaAlbaran, e.Idempresa, e.Tipo }, "NonClusteredIndex-20190107-120541");

            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.DocumentoFactura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Documentorecibido).HasColumnName("DOCUMENTORECIBIDO");
            entity.Property(e => e.Facturado).HasColumnName("FACTURADO");
            entity.Property(e => e.FechaAlbaran).HasColumnType("date");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("FECHAENVIOEMAIL");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Iddireccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDIRECCION");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("mantenerdetalleiva");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modocalculoiva).HasColumnName("modocalculoiva");
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Numeroalbaran).HasColumnName("numeroalbaran");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");
            entity.Property(e => e.Seriealbaran)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriealbaran");
            entity.Property(e => e.Sualbaran)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUALBARAN");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalalbaran)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalalbaran");
            entity.Property(e => e.Totalbase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbase");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Totalimpuestos)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALimpuestos");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbClientes1");

            entity.HasOne(d => d.IddelegacionNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Iddelegacion)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbClientesSucursales");

            entity.HasOne(d => d.IddireccionNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Iddireccion)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbClientesDirecciones");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCabeceraALBARAN_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IddocumentoNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Iddocumento)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbDatosEmpresa");

            entity.HasOne(d => d.IdobraNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Idobra)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbObras");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbcabeceraAlbarans)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraAlbaran_TbUsuarios");
        });

        modelBuilder.Entity<TbcabeceraFactura>(entity =>
        {
            entity.HasKey(e => e.Idfactura);

            entity.ToTable("TBCabeceraFactura", tb =>
                {
                    tb.HasTrigger("Actualizar_CabeceraFactura");
                    tb.HasTrigger("Borrar_CabeceraFactura");
                });

            entity.HasIndex(e => new { e.Numerofactura, e.Seriefactura, e.Tipofactura, e.Idempresa }, "NonClusteredIndex-20181121-112330").IsUnique();

            entity.HasIndex(e => new { e.FechaFactura, e.Idempresa }, "NonClusteredIndex-20181121-112440");

            entity.HasIndex(e => new { e.Sufecha, e.Idempresa }, "NonClusteredIndex-20181121-112529");

            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Abonado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ABONADO");
            entity.Property(e => e.Baseimponible)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BASEIMPONIBLE");
            entity.Property(e => e.Baseimponiblecompra)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("baseimponiblecompra");
            entity.Property(e => e.Bienesinversion).HasColumnName("BIENESINVERSION");
            entity.Property(e => e.Bruto)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BRUTO");
            entity.Property(e => e.CentroTrabajo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoprovincia");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTACONTABLE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Documentorecibido).HasColumnName("DOCUMENTORECIBIDO");
            entity.Property(e => e.FechaContabilizado).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("date");
            entity.Property(e => e.FechaRecepcion).HasColumnType("date");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdDelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdFacturaRectificada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCLASIFICACION");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idformapago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idformapago");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("MANTENERDETALLEIVA");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modulocalculoiva).HasColumnName("modulocalculoiva");
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Nombrefiscal)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombrefiscal");
            entity.Property(e => e.Numerofactura).HasColumnName("numerofactura");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(7, 5)")
                .HasColumnName("retencion");
            entity.Property(e => e.Seriefactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriefactura");
            entity.Property(e => e.Sufactura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUFACTURA");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Textolibre)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TEXTOLIBRE");
            entity.Property(e => e.Tipofactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipofactura");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Totalfactura)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("TOTALFACTURA");
            entity.Property(e => e.Totaliva)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTALIVA");
            entity.Property(e => e.Totalretencion)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALRETENCION");
            entity.Property(e => e.UltimaFechaPago).HasColumnType("date");

            entity.HasOne(d => d.CodigoRetencionNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.CodigoRetencion)
                .HasConstraintName("FK_TBCabeceraFactura_TbRetenciones");

            entity.HasOne(d => d.CodigoprovinciaNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Codigoprovincia)
                .HasConstraintName("FK_TBCabeceraFactura_TbProvincias");

            entity.HasOne(d => d.IdDelegacionNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.IdDelegacion)
                .HasConstraintName("FK_TBCabeceraFactura_TbClientesDelegaciones");

            entity.HasOne(d => d.IdFacturaRectificadaNavigation).WithMany(p => p.InverseIdFacturaRectificadaNavigation)
                .HasForeignKey(d => d.IdFacturaRectificada)
                .HasConstraintName("FK_TBCabeceraFactura_TBCabeceraFactura");

            entity.HasOne(d => d.IdObraNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.IdObra)
                .HasConstraintName("FK_TBCabeceraFactura_TbObras");

            entity.HasOne(d => d.IdclasificacionNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Idclasificacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbClasificacion");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbClientes");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IddocumentoNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Iddocumento)
                .HasConstraintName("FK_TBCabeceraFactura_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbDatosEmpresa");

            entity.HasOne(d => d.IdformapagoNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Idformapago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbFormasPago");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBCabeceraFactura_TbUsuarios");

            entity.HasOne(d => d.TbPuntosVentum).WithMany(p => p.TbcabeceraFacturas)
                .HasForeignKey(d => new { d.CentroTrabajo, d.Idempresa })
                .HasConstraintName("FK_TBCabeceraFactura_TbPuntosVenta");
        });

        modelBuilder.Entity<Tbcartera>(entity =>
        {
            entity.HasKey(e => e.Idcartera).HasName("PK_TBCarteraclientes_1");

            entity.ToTable("TBCartera");

            entity.Property(e => e.Idcartera)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcartera");
            entity.Property(e => e.Abonado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("abonado");
            entity.Property(e => e.FechaReclamacion).HasColumnType("datetime");
            entity.Property(e => e.Fechavencimiento)
                .HasColumnType("date")
                .HasColumnName("fechavencimiento");
            entity.Property(e => e.IdbancoCargo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDBancoCargo");
            entity.Property(e => e.Idcuentabancaria)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCUENTABANCARIA");
            entity.Property(e => e.Idestado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idestado");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Importearemesar)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("IMPORTEAREMESAR");
            entity.Property(e => e.Importevencimiento)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importevencimiento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remesar).HasColumnName("REMESAR");

            entity.HasOne(d => d.IdbancoCargoNavigation).WithMany(p => p.Tbcarteras)
                .HasForeignKey(d => d.IdbancoCargo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TBCarteraclientes_TbBancos");

            entity.HasOne(d => d.IdcuentabancariaNavigation).WithMany(p => p.Tbcarteras)
                .HasForeignKey(d => d.Idcuentabancaria)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TBCarteraclientes_TbClientesCuentasBancarias");

            entity.HasOne(d => d.IdestadoNavigation).WithMany(p => p.Tbcarteras)
                .HasForeignKey(d => d.Idestado)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TBCartera_TbEstadosCartera");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.Tbcarteras)
                .HasForeignKey(d => d.Idfactura)
                .HasConstraintName("FK_TBCartera_TBCabeceraFactura");
        });

        modelBuilder.Entity<TbdetalleTarifa>(entity =>
        {
            entity.ToTable("TBDetalleTarifa");

            entity.HasIndex(e => new { e.IdTarifa, e.IdArticulo }, "NonClusteredIndex-20181114-170721").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrecioTarifa).HasColumnType("decimal(11, 4)");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbdetalleTarifas)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK_TBDetalleTarifa_TbArticulos");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.TbdetalleTarifas)
                .HasForeignKey(d => d.IdTarifa)
                .HasConstraintName("FK_TBDetalleTarifa_TbCabeceraTarifa");
        });

        modelBuilder.Entity<TbentradasTaller>(entity =>
        {
            entity.HasKey(e => e.IdEntrada);

            entity.ToTable("TbentradasTaller");

            entity.HasIndex(e => new { e.NumeroEntrada, e.SerieEntrada, e.IdEmpresa }, "NonClusteredIndex-20221125-180126").IsUnique();

            entity.HasIndex(e => new { e.FechaEntrada, e.IdEmpresa }, "NonClusteredIndex-20221125-180229");

            entity.Property(e => e.IdEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Averia)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ConceptoDocumento)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.Fechafin)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.IdAlbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEstadoEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdFactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddiseño");
            entity.Property(e => e.Idmaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idpresupuesto)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.SerieEntrada)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAlbaranNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.IdAlbaran)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbentradasTaller_TBCabeceraAlbaran");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbentradasTaller_TbArticulos");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbentradasTaller_TbDatosEmpresa");

            entity.HasOne(d => d.IdEstadoEntradaNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.IdEstadoEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbentradasTaller_TbEntradasTallerEstados");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbentradasTaller_TBCabeceraFactura");

            entity.HasOne(d => d.IddiseñoNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.Iddiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbentradasTaller_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdmaquinaNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.Idmaquina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbentradasTaller_TbMaquinasCliente");

            entity.HasOne(d => d.IdpresupuestoNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.Idpresupuesto)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TbentradasTaller_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.TbentradasTallers)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbentradasTaller_TbUsuarios");
        });

        modelBuilder.Entity<TbhistorialRegularizacion>(entity =>
        {
            entity.HasKey(e => e.IdActualizacionStock);

            entity.ToTable("TBHistorialRegularizacion");

            entity.HasIndex(e => new { e.Idarticulo, e.Fechainventario }, "NonClusteredIndex-20190115-175458");

            entity.HasIndex(e => new { e.Idarticulo, e.LoteSerie }, "ndxloteyarticulo");

            entity.Property(e => e.IdActualizacionStock)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("FECHACADUCIDAD");
            entity.Property(e => e.Fechainventario)
                .HasColumnType("datetime")
                .HasColumnName("fechainventario");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.LoteSerie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE_serie");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Precioregularizacion)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("precioregularizacion");
            entity.Property(e => e.StockActual).HasColumnType("decimal(11, 3)");
            entity.Property(e => e.StockDiferencia).HasColumnType("decimal(11, 3)");
            entity.Property(e => e.UnidadesDiferencia).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbhistorialRegularizacions)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBHistorialRegularizacion_TbUsuarios");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TbhistorialRegularizacions)
                .HasForeignKey(d => d.Idalmacen)
                .HasConstraintName("FK_TBHistorialRegularizacion_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TbhistorialRegularizacions)
                .HasForeignKey(d => d.Idarticulo)
                .HasConstraintName("FK_TBHistorialRegularizacion_TbArticulos");
        });

        modelBuilder.Entity<Tblayoutspivot>(entity =>
        {
            entity.HasKey(e => e.Idlayout);

            entity.ToTable("TBLAYOUTSPIVOT");

            entity.Property(e => e.Idlayout)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDLAYOUT");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Predeterminada).HasColumnName("PREDETERMINADA");
            entity.Property(e => e.Strlayout)
                .HasColumnType("text")
                .HasColumnName("STRLAYOUT");
            entity.Property(e => e.Textototalgeneral)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TEXTOTOTALGENERAL");
            entity.Property(e => e.Tipoplantilla)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPOPLANTILLA");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Tblayoutspivots)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_TBLAYOUTSPIVOT_TBTiposDocumento");
        });

        modelBuilder.Entity<Tblog>(entity =>
        {
            entity.ToTable("Tblog");

            entity.HasIndex(e => e.FechaHora, "NonClusteredIndex-20221115-110759");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Accion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.IdExterno)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Tblogs)
                .HasForeignKey(d => d.Idusuario)
                .HasConstraintName("FK_Tblog_TbUsuarios");
        });

        modelBuilder.Entity<Tbmovimientosbancario>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("despues_actualizar_pago");
                    tb.HasTrigger("despues_borrar_pago");
                    tb.HasTrigger("despues_insertar_pago");
                });

            entity.HasIndex(e => new { e.Fechapago, e.Idbanco }, "NonClusteredIndex-20190205-094703");

            entity.HasIndex(e => e.Idmovimientoasociado, "NonClusteredIndex-20190208-184900");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTACONTABLE");
            entity.Property(e => e.Devuelto).HasColumnName("devuelto");
            entity.Property(e => e.FechaContabilizado)
                .HasColumnType("datetime")
                .HasColumnName("FechaCONTABILIZADO");
            entity.Property(e => e.Fechapago)
                .HasColumnType("date")
                .HasColumnName("fechapago");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdAsociacionEntregaAcuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCaja)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.Idautonumerico)
                .ValueGeneratedOnAdd()
                .HasColumnName("idautonumerico");
            entity.Property(e => e.Idbanco)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idbanco");
            entity.Property(e => e.Idcartera)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcartera");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idcuentabancaria)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcuentabancaria");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idgrupo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idgrupo");
            entity.Property(e => e.Idmodopago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idmodopago");
            entity.Property(e => e.Idmovimientoasociado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDMOVIMIENTOASOCIADO");
            entity.Property(e => e.Idpedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpedido");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Oculta).HasColumnName("oculta");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Punteado).HasColumnName("PUNTEADO");
            entity.Property(e => e.ReferenciaMantado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdCajaNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.IdCaja)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbCajas");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbDatosEmpresa");

            entity.HasOne(d => d.IdalbaranNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idalbaran)
                .HasConstraintName("FK_Tbmovimientosbancarios_TBCabeceraAlbaran");

            entity.HasOne(d => d.IdbancoNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TBbancos");

            entity.HasOne(d => d.IdcarteraNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idcartera)
                .HasConstraintName("FK_Tbmovimientosbancarios_TBCartera");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbClientes");

            entity.HasOne(d => d.IdcuentabancariaNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idcuentabancaria)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbClientesCuentasBancarias");

            entity.HasOne(d => d.IddocumentoNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Iddocumento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbCabeceraPresupuesto");

            entity.HasOne(d => d.IdgrupoNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idgrupo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbClasificacionesApuntes");

            entity.HasOne(d => d.IdmodopagoNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idmodopago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbModosPago");

            entity.HasOne(d => d.IdpedidoNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idpedido)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbCabeceraPedido");

            entity.HasOne(d => d.IdusuarioNavigation).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => d.Idusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbUsuarios");

            entity.HasOne(d => d.TbCabeceraRemesa).WithMany(p => p.Tbmovimientosbancarios)
                .HasForeignKey(d => new { d.NumeroRemesa, d.IdEmpresa })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tbmovimientosbancarios_TbCabeceraRemesa");
        });

        modelBuilder.Entity<Tbparametro>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Idempresa }).HasName("PK_TBParametros_1");

            entity.ToTable("TBParametros");

            entity.Property(e => e.Id)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.Tbparametros)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBParametros_TbDatosEmpresa");
        });

        modelBuilder.Entity<TbtiposDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento);

            entity.ToTable("TBTiposDocumento");

            entity.Property(e => e.IdTipoDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grupoinforme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Plantilla).HasColumnType("text");
            entity.Property(e => e.Sql)
                .HasColumnType("text")
                .HasColumnName("sql");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tratamiento");
            entity.Property(e => e.Vistaprevia).HasColumnName("vistaprevia");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TbtiposDocumentos)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBTiposDocumento_TbDatosEmpresa");
        });

        modelBuilder.Entity<TmpCabeceraTicket>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("TmpCabeceraTicket");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAQUINAUSO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SerieTicket)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TmpCabeceraTickets)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TmpCabeceraTicket_TbClientes");

            entity.HasOne(d => d.IdDiseñoNavigation).WithMany(p => p.TmpCabeceraTickets)
                .HasForeignKey(d => d.IdDiseño)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TmpCabeceraTicket_TbSeriesDiseñoDocumento");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TmpCabeceraTickets)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TmpCabeceraTicket_TbDatosEmpresa");

            entity.HasOne(d => d.TbSeriesFactura).WithMany(p => p.TmpCabeceraTickets)
                .HasForeignKey(d => new { d.SerieTicket, d.Idempresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TmpCabeceraTicket_TbSeriesFactura");
        });

        modelBuilder.Entity<TmpDetalleTicket>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("TmpDetalleTicket", tb =>
                {
                    tb.HasTrigger("despues_actualizar_ticket");
                    tb.HasTrigger("despues_borrar_ticket");
                    tb.HasTrigger("despues_insertar_ticket");
                });

            entity.HasIndex(e => new { e.Lote, e.Idarticulo, e.Idcabeceraticket }, "ndxLoteRepetido")
                .IsUnique()
                .HasFilter("([Lote] IS NOT NULL)");

            entity.Property(e => e.IdRegistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigobarras)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDALMACEN");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idcabeceraticket)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcabeceraticket");
            entity.Property(e => e.Importeii).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Lote)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Precioii)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("precioii");

            entity.HasOne(d => d.CodigoIvaNavigation).WithMany(p => p.TmpDetalleTickets)
                .HasForeignKey(d => d.CodigoIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TmpDetalleTicket_TbIvas");

            entity.HasOne(d => d.IdalmacenNavigation).WithMany(p => p.TmpDetalleTickets)
                .HasForeignKey(d => d.Idalmacen)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TmpDetalleTicket_TbAlmacenes");

            entity.HasOne(d => d.IdarticuloNavigation).WithMany(p => p.TmpDetalleTickets)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TmpDetalleTicket_TbArticulos");

            entity.HasOne(d => d.IdcabeceraticketNavigation).WithMany(p => p.TmpDetalleTickets)
                .HasForeignKey(d => d.Idcabeceraticket)
                .HasConstraintName("FK_TmpDetalleTicket_TmpCabeceraTicket");
        });

        modelBuilder.Entity<TmpEtiqueta>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Codigobarras1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras1");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Iddetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDETALLE");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pvp");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpExistencia>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE");
            entity.Property(e => e.Stock).HasColumnType("decimal(9, 3)");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("UNIDADES");
        });

        modelBuilder.Entity<TmpInforme>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TmpInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TmpInventario");

            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE");
            entity.Property(e => e.Preciocoste)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocoste");
            entity.Property(e => e.Precioventa)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("precioventa");
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("stock");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("UNIDADES");
        });

        modelBuilder.Entity<TmpRetorno>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TmpRetornos)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK_TmpRetornos_TbArticulos");

            entity.HasOne(d => d.IdAvisoNavigation).WithMany(p => p.TmpRetornos)
                .HasForeignKey(d => d.IdAviso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TmpRetornos_TbAvisos");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TmpRetornos)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_TmpRetornos_TbDatosEmpresa");
        });

        modelBuilder.Entity<TmpTbAvisosOperario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TmpTbAvisos_operarios_1");

            entity.ToTable("Tmp_TbAvisos_operarios");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaHoraIntervencion).HasColumnType("datetime");
            entity.Property(e => e.FicheroFirma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Horasintervencion)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("HORASINTERVENCION");
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Preciohora)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preciohora");

            entity.HasOne(d => d.IdAvisoNavigation).WithMany(p => p.TmpTbAvisosOperarios)
                .HasForeignKey(d => d.IdAviso)
                .HasConstraintName("FK_Tmp_TbAvisos_operarios_TbAvisos");

            entity.HasOne(d => d.IdOperarioNavigation).WithMany(p => p.TmpTbAvisosOperarios)
                .HasForeignKey(d => d.IdOperario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tmp_TbAvisos_operarios_TbOperarios");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TmpTbAvisosOperarios)
                .HasForeignKey(d => d.Idempresa)
                .HasConstraintName("FK_Tmp_TbAvisos_operarios_TbDatosEmpresa");
        });

        modelBuilder.Entity<TrCabeceraAlbaran>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("Tr_CabeceraAlbaran");

            entity.HasIndex(e => new { e.Numeroalbaran, e.Seriealbaran, e.Idempresa }, "NonClusteredIndex-20211022-122039");

            entity.HasIndex(e => e.FechaHoraRegistro, "NonClusteredIndex-20211022-122059");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idregistro");
            entity.Property(e => e.Accion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.DocumentoFactura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Documentorecibido).HasColumnName("DOCUMENTORECIBIDO");
            entity.Property(e => e.Facturado).HasColumnName("FACTURADO");
            entity.Property(e => e.FechaAlbaran).HasColumnType("date");
            entity.Property(e => e.FechaHoraRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("FECHAENVIOEMAIL");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Iddireccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDIRECCION");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("mantenerdetalleiva");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modocalculoiva).HasColumnName("modocalculoiva");
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Numeroalbaran).HasColumnName("numeroalbaran");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");
            entity.Property(e => e.Seriealbaran)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriealbaran");
            entity.Property(e => e.Sualbaran)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUALBARAN");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalalbaran)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalalbaran");
            entity.Property(e => e.Totalbase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbase");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Totalimpuestos)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALimpuestos");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.TrCabeceraAlbarans)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tr_CabeceraAlbaran_TbClientes");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TrCabeceraAlbarans)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tr_CabeceraAlbaran_TBDATOSEMPRESA");
        });

        modelBuilder.Entity<TrCabeceraFactura>(entity =>
        {
            entity.HasKey(e => e.Idregistro).HasName("PK_trCabeceraFactura");

            entity.ToTable("Tr_CabeceraFactura");

            entity.HasIndex(e => new { e.Numerofactura, e.Seriefactura, e.Idempresa }, "NonClusteredIndex-20211022-125341");

            entity.HasIndex(e => e.Fechahoraregistro, "NonClusteredIndex-20211022-125355");

            entity.HasIndex(e => new { e.FechaFactura, e.Idempresa }, "NonClusteredIndex-20211022-125406");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idregistro");
            entity.Property(e => e.Abonado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ABONADO");
            entity.Property(e => e.Accion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Baseimponible)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BASEIMPONIBLE");
            entity.Property(e => e.Baseimponiblecompra)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("baseimponiblecompra");
            entity.Property(e => e.Bienesinversion).HasColumnName("BIENESINVERSION");
            entity.Property(e => e.Bruto)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BRUTO");
            entity.Property(e => e.CentroTrabajo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Codigoprovincia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoprovincia");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTACONTABLE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Documentorecibido).HasColumnName("DOCUMENTORECIBIDO");
            entity.Property(e => e.FechaContabilizado).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("date");
            entity.Property(e => e.FechaRecepcion).HasColumnType("date");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechahoraregistro)
                .HasColumnType("datetime")
                .HasColumnName("fechahoraregistro");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdDelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdFacturaRectificada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idclasificacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDCLASIFICACION");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddocumento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Idformapago)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idformapago");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idusuario");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Mantenerdetalleiva).HasColumnName("MANTENERDETALLEIVA");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Modulocalculoiva).HasColumnName("modulocalculoiva");
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Nombrefiscal)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombrefiscal");
            entity.Property(e => e.Numerofactura).HasColumnName("numerofactura");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(7, 5)")
                .HasColumnName("retencion");
            entity.Property(e => e.Seriefactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriefactura");
            entity.Property(e => e.Sufactura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUFACTURA");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Textolibre)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TEXTOLIBRE");
            entity.Property(e => e.Tipofactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipofactura");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Totalfactura)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("TOTALFACTURA");
            entity.Property(e => e.Totaliva)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTALIVA");
            entity.Property(e => e.Totalretencion)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALRETENCION");
            entity.Property(e => e.UltimaFechaPago).HasColumnType("date");

            entity.HasOne(d => d.IdempresaNavigation).WithMany(p => p.TrCabeceraFacturas)
                .HasForeignKey(d => d.Idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tr_CabeceraFactura_TBDATOSEMPRESA");
        });

        modelBuilder.Entity<TrDetalle>(entity =>
        {
            entity.HasKey(e => e.Idregistro).HasName("PK_trAvisos_Material");

            entity.ToTable("Tr_Detalle");

            entity.HasIndex(e => e.Idfactura, "NonClusteredIndex-20211022-162215");

            entity.HasIndex(e => e.Idalbaran, "NonClusteredIndex-20211022-162247");

            entity.HasIndex(e => e.Fechahoraregistro, "NonClusteredIndex-20211022-162315");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idregistro");
            entity.Property(e => e.Accion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Agrupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Alto).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.CodigoIva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigoretencion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoretencion");
            entity.Property(e => e.Contracuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuentacontable");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.Engarantia).HasColumnName("ENGARANTIA");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechahoraregistro)
                .HasColumnType("datetime")
                .HasColumnName("fechahoraregistro");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTarifa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.Idavisodestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idavisodestino");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Idlineapedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idlineapedido");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOBRA");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOPERARIO");
            entity.Property(e => e.Idvehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idvehiculo");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Importeii).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Lineaoculta).HasColumnName("lineaoculta");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioIi)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PrecioII");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROYECTO");
            entity.Property(e => e.Recargo)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("recargo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("retencion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades).HasColumnType("decimal(8, 2)");
        });

        //modelBuilder.Entity<Version>(entity =>
        //{
        //    entity.HasKey(e => e.Version1);

        //    entity.ToTable("version");

        //    entity.Property(e => e.Version1)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("version");
        //    entity.Property(e => e.Versiongm)
        //        .HasMaxLength(15)
        //        .IsUnicode(false)
        //        .HasColumnName("VERSIONGM");
        //});

        modelBuilder.Entity<Vw347>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw347");

            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("provincia");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("total");
            entity.Property(e => e.Trim1).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Trim2).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Trim3).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Trim4).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VwAlbarane>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwAlbaranes");

            entity.Property(e => e.Beneficio)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("beneficio");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.DocumentoFactura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DreccionEntrega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dreccion entrega");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Entregas)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("entregas");
            entity.Property(e => e.Facturado).HasColumnName("FACTURADO");
            entity.Property(e => e.FechaAlbaran).HasColumnType("date");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("FECHAENVIOEMAIL");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Formapago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formapago");
            entity.Property(e => e.Idalbaran)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalbaran");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Numeroalbaran).HasColumnName("numeroalbaran");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observacionesinternas)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observacionesinternas");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("presupuesto");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");
            entity.Property(e => e.Ruta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seriealbaran)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriealbaran");
            entity.Property(e => e.Sualbaran)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUALBARAN");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalalbaran)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalalbaran");
            entity.Property(e => e.Totalbase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbase");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Totalimpuestos)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALimpuestos");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwArticulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwArticulos");

            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ALTO");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ANCHO");
            entity.Property(e => e.Codigobarras1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras1");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionAdicional)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaModificacionPrecioVenta).HasColumnType("datetime");
            entity.Property(e => e.Fechacambiostock)
                .HasColumnType("datetime")
                .HasColumnName("fechacambiostock");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Hipervinculo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hipervinculo");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IvaCompra)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva compra");
            entity.Property(e => e.IvaVenta)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva venta");
            entity.Property(e => e.Largo)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("LARGO");
            entity.Property(e => e.Loteado).HasColumnName("LOTEado");
            entity.Property(e => e.MaquinaModificaPrecioVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquinaregistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinaregistro");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("margen");
            entity.Property(e => e.Organizacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("organizacion");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("PESO");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pvp");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("stock");
            entity.Property(e => e.Subfamilia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoArticulo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimoDto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwArticulosFoto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwArticulosFoto");

            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ALTO");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("ANCHO");
            entity.Property(e => e.Codigobarras1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigobarras1");
            entity.Property(e => e.Descatalogado).HasColumnName("descatalogado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionAdicional)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaModificacionPrecioVenta).HasColumnType("datetime");
            entity.Property(e => e.Fechacambiostock)
                .HasColumnType("datetime")
                .HasColumnName("fechacambiostock");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Hipervinculo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hipervinculo");
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.IvaCompra)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva compra");
            entity.Property(e => e.IvaVenta)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("iva venta");
            entity.Property(e => e.Largo)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("LARGO");
            entity.Property(e => e.Loteado).HasColumnName("LOTEado");
            entity.Property(e => e.MaquinaModificaPrecioVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquinaregistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinaregistro");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("margen");
            entity.Property(e => e.Organizacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("organizacion");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(8, 3)")
                .HasColumnName("PESO");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pvp");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("stock");
            entity.Property(e => e.Subfamilia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoArticulo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimoDto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAviso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwAvisos");

            entity.Property(e => e.Administrador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Beneficio)
                .HasColumnType("decimal(13, 4)")
                .HasColumnName("beneficio");
            entity.Property(e => e.CentroTrabajo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Certificacion).HasColumnName("certificacion");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Esobra).HasColumnName("esobra");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Factura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("factura");
            entity.Property(e => e.Facturar).HasColumnName("facturar");
            entity.Property(e => e.FechaAviso).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.Garantia).HasColumnName("garantia");
            entity.Property(e => e.IdAviso)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdDelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdObra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImporteAviso).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ImporteCompraAviso).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Incidencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaquinaUso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeMosobreMat)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("PorcentajeMOsobreMAT");
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Rutadocumentos)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RUTADOCUMENTOS");
            entity.Property(e => e.SerieAviso)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Trimestre).HasColumnName("trimestre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwConceptosFacturado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwConceptosFacturados");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("alto");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("ancho");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Contracuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuentacontable");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("delegacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.Engarantia).HasColumnName("engarantia");
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAviso).HasColumnType("datetime");
            entity.Property(e => e.FechaCaducidad).HasColumnType("date");
            entity.Property(e => e.Fechaalbaran)
                .HasColumnType("date")
                .HasColumnName("fechaalbaran");
            entity.Property(e => e.Fechafactura)
                .HasColumnType("date")
                .HasColumnName("fechafactura");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddetalle)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddetalle");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Importecompra)
                .HasColumnType("decimal(22, 7)")
                .HasColumnName("importecompra");
            entity.Property(e => e.Importeii).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("largo");
            entity.Property(e => e.Lineaoculta).HasColumnName("lineaoculta");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOTE");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Numeroalbaran)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numeroalbaran");
            entity.Property(e => e.Numeroaviso)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("numeroaviso");
            entity.Property(e => e.Numerofactura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numerofactura");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("obra");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Pedido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pedido");
            entity.Property(e => e.Precio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioIi)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("PrecioII");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Recargo)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("recargo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("retencion");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades");
        });

        modelBuilder.Entity<VwDetallePartesOperario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwDetallePartesOperarios");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Concepto)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.FechaParte).HasColumnType("date");
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idnumero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDNUMERO");
            entity.Property(e => e.Ingreso)
                .HasColumnType("decimal(17, 5)")
                .HasColumnName("ingreso");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("obra");
            entity.Property(e => e.Preciocoste)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("PRECIOCOSTE");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Referenciaobra)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referenciaobra");
        });

        modelBuilder.Entity<VwDetallePedidosVentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwDetallePedidosVenta");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pedido)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("pedido");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Stock)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("stock");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VwEntradasTaller>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwEntradasTaller");

            entity.Property(e => e.Albaran)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("albaran");
            entity.Property(e => e.Averia)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Factura)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("factura");
            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.Fechafin)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEstadoEntrada)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idmaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idmaquina");
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observacionesentrada)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("observacionesentrada");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("presupuesto");
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SerieEntrada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwFacturas");

            entity.Property(e => e.Abonado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ABONADO");
            entity.Property(e => e.Administrador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Baseimponible)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BASEIMPONIBLE");
            entity.Property(e => e.Baseimponiblecompra)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("baseimponiblecompra");
            entity.Property(e => e.Beneficio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("beneficio");
            entity.Property(e => e.Bienesinversion).HasColumnName("BIENESINVERSION");
            entity.Property(e => e.Bruto)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("BRUTO");
            entity.Property(e => e.CentroTrabajo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clasificacion");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Contracuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contracuenta");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTACONTABLE");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Documento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("documento");
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Entregas)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("entregas");
            entity.Property(e => e.FechaContabilizado).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("date");
            entity.Property(e => e.FechaRecepcion).HasColumnType("date");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Formapago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formapago");
            entity.Property(e => e.Idadministrador)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idadministrador");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfactura)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idfactura");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Nombredocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCUMENTO");
            entity.Property(e => e.Nombrefiscal)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombrefiscal");
            entity.Property(e => e.Numerofactura).HasColumnName("numerofactura");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesInternas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Pendiente)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("pendiente");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(132)
                .IsUnicode(false)
                .HasColumnName("presupuesto");
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Rectificada)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("rectificada");
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(7, 5)")
                .HasColumnName("retencion");
            entity.Property(e => e.Ruta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seriefactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriefactura");
            entity.Property(e => e.Soporte)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("soporte");
            entity.Property(e => e.Sufactura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUFACTURA");
            entity.Property(e => e.Sufecha)
                .HasColumnType("date")
                .HasColumnName("SUFECHA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Textolibre)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TEXTOLIBRE");
            entity.Property(e => e.Tipocliente)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("tipocliente");
            entity.Property(e => e.Tipofactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipofactura");
            entity.Property(e => e.TotalRecargo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Totalfactura)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("TOTALFACTURA");
            entity.Property(e => e.Totaliva)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTALIVA");
            entity.Property(e => e.Totalretencion)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("TOTALRETENCION");
            entity.Property(e => e.Trimestre).HasColumnName("trimestre");
            entity.Property(e => e.UltimaFechaPago).HasColumnType("date");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwFechasMto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwFechasMto");

            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dato).HasColumnName("dato");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.FechaProximoMto).HasColumnType("date");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.TipoMantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwHistorialArticulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwHistorialArticulo");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlmacenOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("alto");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("idobra");
            entity.Property(e => e.Importe).HasColumnType("decimal(36, 16)");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Lote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBruto).HasColumnType("decimal(25, 13)");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Precioneto)
                .HasColumnType("decimal(32, 16)")
                .HasColumnName("precioneto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Sunumero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sunumero");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipodocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipodocumento");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("unidades");
        });

        modelBuilder.Entity<VwHistorialArticuloConSaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwHistorialArticulo_ConSaldo");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlmacenOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("alto");
            entity.Property(e => e.Ancho).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdArticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddelegacion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("iddelegacion");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("idobra");
            entity.Property(e => e.Importe).HasColumnType("decimal(36, 16)");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Lote)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBruto).HasColumnType("decimal(25, 13)");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Precioneto)
                .HasColumnType("decimal(32, 16)")
                .HasColumnName("precioneto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("saldo");
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Sunumero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sunumero");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipodocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipodocumento");
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("unidades");
        });

        modelBuilder.Entity<VwHistorialCuentasObra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwHistorialCuentasObras");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Coste).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.DescripcionCuenta)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionGrupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Fechafinalizacion)
                .HasColumnType("date")
                .HasColumnName("FECHAFINALIZACION");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("date")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(22, 7)")
                .HasColumnName("importe");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Subgrupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TextoLista)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwKilometrosMto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwKilometrosMto");

            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoMantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwLineasDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwLineasDocumentos");

            entity.Property(e => e.Agrupacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("agrupacion");
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("alto");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("ancho");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.Codigoiva)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigoiva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Dto2)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto2");
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idobra");
            entity.Property(e => e.Idoperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idoperario");
            entity.Property(e => e.Importe).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ImporteIi)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ImporteII");
            entity.Property(e => e.Incrementogeneral)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("incrementogeneral");
            entity.Property(e => e.Iva).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Largo)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("largo");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Margen)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("margen");
            entity.Property(e => e.Numerodocumento).HasColumnName("numerodocumento");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("obra");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Precio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.PrecioIi)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PrecioII");
            entity.Property(e => e.Preciocompraneto)
                .HasColumnType("decimal(11, 4)")
                .HasColumnName("preciocompraneto");
            entity.Property(e => e.Recargo).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ReferenciaDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referenciaDocumento");
            entity.Property(e => e.Seriedocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriedocumento");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("unidades");
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwListaObra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwListaObras");

            entity.Property(e => e.Albaranesventa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Facturado)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("facturado");
            entity.Property(e => e.Fechafinalizacion)
                .HasColumnType("date")
                .HasColumnName("FECHAFINALIZACION");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("date")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idtipoobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idtipoobra");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAQUINAUSO");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Presupuestado)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("presupuestado");
            entity.Property(e => e.Provincia)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Tecnico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tecnico");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tfno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tfno");
            entity.Property(e => e.Tipoobra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoobra");
            entity.Property(e => e.TotalCostes).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<VwLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwLog");

            entity.Property(e => e.Accion)
                .HasMaxLength(164)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.IdExterno)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquina");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<VwMaquinasCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwMaquinasCliente");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompra).HasColumnType("date");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdModelo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idmaquina)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAQUINAUSO");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TipoMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ultimaentrada)
                .HasColumnType("datetime")
                .HasColumnName("ultimaentrada");
        });

        modelBuilder.Entity<VwMovimientosAlmacen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwMovimientosAlmacen");

            entity.Property(e => e.AlmacenDestino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlmacenOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.FechaFin).HasColumnType("date");
            entity.Property(e => e.FechaMovimiento).HasColumnType("date");
            entity.Property(e => e.IdAlmacenDestino)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAlmacenOrigen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdMovimiento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwObrasCoste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwObrasCoste");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Coste).HasColumnType("decimal(32, 16)");
            entity.Property(e => e.DescripcionCuenta)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("Descripcion Cuenta");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Registro");
            entity.Property(e => e.Grupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrupoAgrupacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Grupo Agrupacion");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDEMPRESA");
            entity.Property(e => e.Idobra)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDOBRA");
            entity.Property(e => e.Importe).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ObraCliente)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("Obra Cliente");
            entity.Property(e => e.ObraCodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Obra Codigo Postal");
            entity.Property(e => e.ObraDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Obra Direccion");
            entity.Property(e => e.ObraDniCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Obra Dni Cliente");
            entity.Property(e => e.ObraFechaFinalizacion)
                .HasColumnType("date")
                .HasColumnName("Obra Fecha Finalizacion");
            entity.Property(e => e.ObraFechaInicio)
                .HasColumnType("date")
                .HasColumnName("Obra Fecha Inicio");
            entity.Property(e => e.ObraLocalidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Obra Localidad");
            entity.Property(e => e.ObraObservaciones)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Obra Observaciones");
            entity.Property(e => e.ObraPresupuestado)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Obra Presupuestado");
            entity.Property(e => e.ObraProvincia)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Obra Provincia");
            entity.Property(e => e.ObraReferencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Obra Referencia");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("proyecto");
            entity.Property(e => e.ReferenciaCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Referencia Cuenta");
            entity.Property(e => e.Subgrupo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TextoLista)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("Texto lista");
        });

        modelBuilder.Entity<VwPartesOperario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPartesOperarios");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaParte).HasColumnType("date");
            entity.Property(e => e.IdOperario)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idnumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDNUMERO");
            entity.Property(e => e.Idparte)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idparte");
            entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Importecoste)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("importecoste");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPedidos");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adjunto");
            entity.Property(e => e.Beneficio)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("beneficio");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.CodigoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DatosDescarga)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Definicioncolor).HasColumnName("DEFINICIONCOLOR");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Descripciondireccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Entregas)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("entregas");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaPrevistaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("FECHAIMPRESION");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("iddiseño");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idpedido)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpedido");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Numeropedido).HasColumnName("numeropedido");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("presupuesto");
            entity.Property(e => e.Puntoventa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puntoventa");
            entity.Property(e => e.Ruta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seriepedido)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriepedido");
            entity.Property(e => e.Servido).HasColumnName("servido");
            entity.Property(e => e.Supedido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("supedido");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalbase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbase");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Totalimpuestos)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("totalimpuestos");
            entity.Property(e => e.Totalpedido)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalpedido");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPresupuesto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPresupuestos");

            entity.Property(e => e.Aviso)
                .HasMaxLength(47)
                .IsUnicode(false)
                .HasColumnName("aviso");
            entity.Property(e => e.Beneficio)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("beneficio");
            entity.Property(e => e.Beneficioindustrial)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("beneficioindustrial");
            entity.Property(e => e.CampoLibre1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CarpetaRuta)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("carpeta_ruta");
            entity.Property(e => e.Certificacionaorigen).HasColumnName("certificacionaorigen");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clasificacion");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DescuentoEuros).HasColumnType("decimal(11, 2)");
            entity.Property(e => e.Direccioncliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccioncliente");
            entity.Property(e => e.Direccionobra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccionobra");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Entrega).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaAceptacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDocumento).HasColumnType("date");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fechaenvioemail)
                .HasColumnType("datetime")
                .HasColumnName("fechaenvioemail");
            entity.Property(e => e.Fechaimpresion)
                .HasColumnType("datetime")
                .HasColumnName("fechaimpresion");
            entity.Property(e => e.Gastosgenerales)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("gastosgenerales");
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idcliente)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idcliente");
            entity.Property(e => e.Iddiseño)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDISEÑO");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idestado)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDESTADO");
            entity.Property(e => e.ImporteBeneficioIndustrial).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ImporteGastosGenerales).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Localidadcliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localidadcliente");
            entity.Property(e => e.Localidadobra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("localidadobra");
            entity.Property(e => e.Maquinauso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maquinauso");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Numerodocumento).HasColumnName("numerodocumento");
            entity.Property(e => e.Obra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Porcentajefacturado)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("porcentajefacturado");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Seriedocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seriedocumento");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalBase).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalImpuestos).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TotalPresupuesto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Totalbruto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalbruto");
            entity.Property(e => e.Totalcompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalcompra");
            entity.Property(e => e.Ultimaversion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ultimaversion");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Versionaceptada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERSIONACEPTADA");
        });

        modelBuilder.Entity<VwRegistroPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwRegistroPedidos");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Depedidocliente)
                .HasMaxLength(147)
                .IsUnicode(false)
                .HasColumnName("depedidocliente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Detaller)
                .HasMaxLength(147)
                .IsUnicode(false)
                .HasColumnName("detaller");
            entity.Property(e => e.Documento)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(22, 7)")
                .HasColumnName("importe");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pendiente)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("pendiente");
            entity.Property(e => e.Tipo)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VwRegistrosCoste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwRegistrosCoste");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Concepto)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Descripcion Vehiculo");
            entity.Property(e => e.Descuento).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaProximoMto).HasColumnType("date");
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Importe).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Kilometros).HasColumnName("kilometros");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PrecioBAse");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Rendimiento)
                .HasColumnType("decimal(36, 18)")
                .HasColumnName("rendimiento");
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Taller)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.TipoMantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Trimestre).HasColumnName("trimestre");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwRegistrosCosteCubo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwRegistrosCosteCubos");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Concepto)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Descripcion Vehiculo");
            entity.Property(e => e.Descuento).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ejercicio).HasColumnName("ejercicio");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdVehiculo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Importe).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("PrecioBAse");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Rendimiento)
                .HasColumnType("decimal(36, 18)")
                .HasColumnName("rendimiento");
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Semana).HasColumnName("semana");
            entity.Property(e => e.Taller)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.TipoMantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Trimestre).HasColumnName("trimestre");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSeguimientoPotenciale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwSeguimientoPotenciales");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Colorcalendario).HasColumnName("colorcalendario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(114)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdAccion)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Idempresa)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idempresa");
            entity.Property(e => e.Idpotencial)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idpotencial");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("importe");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<VwTrazabilidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwTrazabilidad");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Dto).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Dto1)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("dto1");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fechacaducidad)
                .HasColumnType("date")
                .HasColumnName("fechacaducidad");
            entity.Property(e => e.Idalmacen)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idalmacen");
            entity.Property(e => e.Idarticulo)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idarticulo");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(25, 6)")
                .HasColumnName("importe");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lote");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(25, 13)")
                .HasColumnName("precio");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Sudocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sudocumento");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
