using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDatosEmpresa
{
    public string IdEmpresa { get; set; } = null!;

    public string NombreFiscal { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public byte[]? Logo { get; set; }

    public string? Nif { get; set; }

    public string? Telefono { get; set; }

    public string? Tipoempresa { get; set; }

    public string? Nombrecomercial { get; set; }

    public string? Texto { get; set; }

    public string? Administrador { get; set; }

    public string? Nifadministrador { get; set; }

    public string? DireccionSocial { get; set; }

    public string? CodigoPostalSocial { get; set; }

    public string? LocalidadSocial { get; set; }

    public string? ProvinciaSocial { get; set; }

    public bool Inactiva { get; set; }

    public bool Predeterminada { get; set; }

    public string? Skin { get; set; }

    public string? Idcuentacorreo { get; set; }

    public string? Web { get; set; }

    public string? CuentaCorreo { get; set; }

    public string? TraspasoContabilidad { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string? Codigoempresaa3 { get; set; }

    public string? Versiona3 { get; set; }

    public bool? Autogenerarasientosgolden { get; set; }

    public virtual TbCuentasCorreo? IdcuentacorreoNavigation { get; set; }

    public virtual ICollection<MgpedidoMudanza> MgpedidoMudanzas { get; } = new List<MgpedidoMudanza>();

    public virtual ICollection<Mgzona> Mgzonas { get; } = new List<Mgzona>();

    public virtual ICollection<TbAdministadoresFinca> TbAdministadoresFincas { get; } = new List<TbAdministadoresFinca>();

    public virtual ICollection<TbAlerta> TbAlerta { get; } = new List<TbAlerta>();

    public virtual ICollection<TbAlmacene> TbAlmacenes { get; } = new List<TbAlmacene>();

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbBanco> TbBancos { get; } = new List<TbBanco>();

    public virtual ICollection<TbCabeceraMensaje> TbCabeceraMensajes { get; } = new List<TbCabeceraMensaje>();

    public virtual ICollection<TbCabeceraMovimientoAlmacen> TbCabeceraMovimientoAlmacens { get; } = new List<TbCabeceraMovimientoAlmacen>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbCabeceraRemesa> TbCabeceraRemesas { get; } = new List<TbCabeceraRemesa>();

    public virtual ICollection<TbCabeceraTarifa> TbCabeceraTarifas { get; } = new List<TbCabeceraTarifa>();

    public virtual ICollection<TbCaja> TbCajas { get; } = new List<TbCaja>();

    public virtual ICollection<TbClasificacion> TbClasificacions { get; } = new List<TbClasificacion>();

    public virtual ICollection<TbClausulasContrato> TbClausulasContratos { get; } = new List<TbClausulasContrato>();

    public virtual ICollection<TbClausulasDocumento> TbClausulasDocumentos { get; } = new List<TbClausulasDocumento>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbEntradasTallerEstado> TbEntradasTallerEstados { get; } = new List<TbEntradasTallerEstado>();

    public virtual ICollection<TbEstadosCartera> TbEstadosCarteras { get; } = new List<TbEstadosCartera>();

    public virtual ICollection<TbFamilia> TbFamilia { get; } = new List<TbFamilia>();

    public virtual ICollection<TbFormasPago> TbFormasPagos { get; } = new List<TbFormasPago>();

    public virtual ICollection<TbIvasCuentasContable> TbIvasCuentasContables { get; } = new List<TbIvasCuentasContable>();

    public virtual ICollection<TbLineasCoste> TbLineasCostes { get; } = new List<TbLineasCoste>();

    public virtual ICollection<TbMarca> TbMarcas { get; } = new List<TbMarca>();

    public virtual ICollection<TbModosPago> TbModosPagos { get; } = new List<TbModosPago>();

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();

    public virtual ICollection<TbObrasGrupo> TbObrasGrupos { get; } = new List<TbObrasGrupo>();

    public virtual ICollection<TbObrasLista> TbObrasLista { get; } = new List<TbObrasLista>();

    public virtual ICollection<TbOperario> TbOperarios { get; } = new List<TbOperario>();

    public virtual ICollection<TbOrganizacionArticulo> TbOrganizacionArticulos { get; } = new List<TbOrganizacionArticulo>();

    public virtual ICollection<TbParametrosFirma> TbParametrosFirmas { get; } = new List<TbParametrosFirma>();

    public virtual ICollection<TbParteOperario> TbParteOperarios { get; } = new List<TbParteOperario>();

    public virtual ICollection<TbPedidosEstado> TbPedidosEstados { get; } = new List<TbPedidosEstado>();

    public virtual ICollection<TbPerfile> TbPerfiles { get; } = new List<TbPerfile>();

    public virtual ICollection<TbPlanContable> TbPlanContables { get; } = new List<TbPlanContable>();

    public virtual ICollection<TbPlantillasCuboCostesVehiculo> TbPlantillasCuboCostesVehiculos { get; } = new List<TbPlantillasCuboCostesVehiculo>();

    public virtual ICollection<TbPotenciale> TbPotenciales { get; } = new List<TbPotenciale>();

    public virtual ICollection<TbPotencialesEstado> TbPotencialesEstados { get; } = new List<TbPotencialesEstado>();

    public virtual ICollection<TbPotencialesGrupo> TbPotencialesGrupos { get; } = new List<TbPotencialesGrupo>();

    public virtual ICollection<TbPresupuestosEstado> TbPresupuestosEstados { get; } = new List<TbPresupuestosEstado>();

    public virtual ICollection<TbProgramacionClasificacion> TbProgramacionClasificacions { get; } = new List<TbProgramacionClasificacion>();

    public virtual ICollection<TbProgramacionDiarium> TbProgramacionDiaria { get; } = new List<TbProgramacionDiarium>();

    public virtual ICollection<TbProgramacion> TbProgramacions { get; } = new List<TbProgramacion>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();

    public virtual ICollection<TbPuntosVentum> TbPuntosVenta { get; } = new List<TbPuntosVentum>();

    public virtual ICollection<TbReferenciasGasto> TbReferenciasGastos { get; } = new List<TbReferenciasGasto>();

    public virtual ICollection<TbReferenciasParte> TbReferenciasPartes { get; } = new List<TbReferenciasParte>();

    public virtual ICollection<TbRepositorio> TbRepositorios { get; } = new List<TbRepositorio>();

    public virtual ICollection<TbResponsable> TbResponsables { get; } = new List<TbResponsable>();

    public virtual ICollection<TbRetencionesCuentasContable> TbRetencionesCuentasContables { get; } = new List<TbRetencionesCuentasContable>();

    public virtual ICollection<TbRuta> TbRuta { get; } = new List<TbRuta>();

    public virtual ICollection<TbSeriesDiseñoDocumento> TbSeriesDiseñoDocumentos { get; } = new List<TbSeriesDiseñoDocumento>();

    public virtual ICollection<TbSeriesFactura> TbSeriesFacturas { get; } = new List<TbSeriesFactura>();

    public virtual ICollection<TbTallere> TbTalleres { get; } = new List<TbTallere>();

    public virtual ICollection<TbTiposArticulo> TbTiposArticulos { get; } = new List<TbTiposArticulo>();

    public virtual ICollection<TbTiposDescuento> TbTiposDescuentos { get; } = new List<TbTiposDescuento>();

    public virtual ICollection<TbTiposDocumentoInterno> TbTiposDocumentoInternos { get; } = new List<TbTiposDocumentoInterno>();

    public virtual ICollection<TbTiposMantenimiento> TbTiposMantenimientos { get; } = new List<TbTiposMantenimiento>();

    public virtual ICollection<TbTiposMaquina> TbTiposMaquinas { get; } = new List<TbTiposMaquina>();

    public virtual ICollection<TbTiposObra> TbTiposObras { get; } = new List<TbTiposObra>();

    public virtual ICollection<TbTpv> TbTpvs { get; } = new List<TbTpv>();

    public virtual ICollection<TbUnidade> TbUnidades { get; } = new List<TbUnidade>();

    public virtual ICollection<TbUsuario> TbUsuarios { get; } = new List<TbUsuario>();

    public virtual ICollection<TbVehiculo> TbVehiculos { get; } = new List<TbVehiculo>();

    public virtual ICollection<TbalmacenesStock> TbalmacenesStocks { get; } = new List<TbalmacenesStock>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();

    public virtual ICollection<Tbparametro> Tbparametros { get; } = new List<Tbparametro>();

    public virtual ICollection<TbtiposDocumento> TbtiposDocumentos { get; } = new List<TbtiposDocumento>();

    public virtual ICollection<TmpCabeceraTicket> TmpCabeceraTickets { get; } = new List<TmpCabeceraTicket>();

    public virtual ICollection<TmpRetorno> TmpRetornos { get; } = new List<TmpRetorno>();

    public virtual ICollection<TmpTbAvisosOperario> TmpTbAvisosOperarios { get; } = new List<TmpTbAvisosOperario>();

    public virtual ICollection<TrCabeceraAlbaran> TrCabeceraAlbarans { get; } = new List<TrCabeceraAlbaran>();

    public virtual ICollection<TrCabeceraFactura> TrCabeceraFacturas { get; } = new List<TrCabeceraFactura>();
}
