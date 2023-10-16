using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCliente
{
    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Localidad { get; set; }

    public string? CodigoProvincia { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Fax { get; set; }

    public string? Observaciones { get; set; }

    public string? Email { get; set; }

    public string? IdFormaPago { get; set; }

    public string Tipo { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public string? Observacionesfactura { get; set; }

    public string? EmpresaoParticular { get; set; }

    public bool Incluir347 { get; set; }

    public decimal? Retencion { get; set; }

    public string? Cuentacontable { get; set; }

    public string? Web { get; set; }

    public string? Contracuentacontable { get; set; }

    public int Codigo { get; set; }

    public string? Idbanco { get; set; }

    public bool Forzariva { get; set; }

    public string? Puntoventa { get; set; }

    public DateTime Fecharegistro { get; set; }

    public string Idusuario { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? CodigoIva { get; set; }

    public short? Diafijopago1 { get; set; }

    public short? Diafijopago2 { get; set; }

    public DateTime? FechaExportadoContabilidad { get; set; }

    public string? CodigoRetencion { get; set; }

    public bool RecargoEquivalencia { get; set; }

    public bool? Modificado { get; set; }

    public string? Idmodopago { get; set; }

    public string SoporteFactura { get; set; } = null!;

    public string? Contacto { get; set; }

    public string Pais { get; set; } = null!;

    public decimal? Riesgo { get; set; }

    public string? Idruta { get; set; }

    public string? Idclasificacion { get; set; }

    public string? SerieFacturacion { get; set; }

    public string? Idadministrador { get; set; }

    public string? ModoFacturacion { get; set; }

    public string? Iddiseñofactura { get; set; }

    public string? Cuerpomensajeemail { get; set; }

    public string? CodigoAdministracion { get; set; }

    public string? OrganoGestor { get; set; }

    public string? UnidadTramitadora { get; set; }

    public string? OrganoProponente { get; set; }

    public string? IdEstadoCartera { get; set; }

    public string? Seriealbaran { get; set; }

    public virtual TbIva? CodigoIvaNavigation { get; set; }

    public virtual TbProvincia? CodigoProvinciaNavigation { get; set; }

    public virtual TbRetencione? CodigoRetencionNavigation { get; set; }

    public virtual TbEstadosCartera? IdEstadoCarteraNavigation { get; set; }

    public virtual TbFormasPago? IdFormaPagoNavigation { get; set; }

    public virtual TbAdministadoresFinca? IdadministradorNavigation { get; set; }

    public virtual TbBanco? IdbancoNavigation { get; set; }

    public virtual TbClasificacion? IdclasificacionNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento? IddiseñofacturaNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbModosPago? IdmodopagoNavigation { get; set; }

    public virtual TbRuta? IdrutaNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<MgpedidoMudanza> MgpedidoMudanzas { get; } = new List<MgpedidoMudanza>();

    public virtual TbPaise PaisNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulosReferenciasCompra> TbArticulosReferenciasCompras { get; } = new List<TbArticulosReferenciasCompra>();

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbClientesContacto> TbClientesContactos { get; } = new List<TbClientesContacto>();

    public virtual ICollection<TbClientesCuentasBancaria> TbClientesCuentasBancaria { get; } = new List<TbClientesCuentasBancaria>();

    public virtual ICollection<TbClientesDelegacione> TbClientesDelegaciones { get; } = new List<TbClientesDelegacione>();

    public virtual ICollection<TbClientesDireccione> TbClientesDirecciones { get; } = new List<TbClientesDireccione>();

    public virtual ICollection<TbClientesDocumento> TbClientesDocumentos { get; } = new List<TbClientesDocumento>();

    public virtual ICollection<TbClientesFacturacionPeriodica> TbClientesFacturacionPeriodicas { get; } = new List<TbClientesFacturacionPeriodica>();

    public virtual ICollection<TbClientesRutasDocumento> TbClientesRutasDocumentos { get; } = new List<TbClientesRutasDocumento>();

    public virtual ICollection<TbClientesTarifaDto> TbClientesTarifaDtos { get; } = new List<TbClientesTarifaDto>();

    public virtual ICollection<TbClientesTarifa> TbClientesTarifas { get; } = new List<TbClientesTarifa>();

    public virtual ICollection<TbContrato> TbContratos { get; } = new List<TbContrato>();

    public virtual ICollection<TbMaquinasCliente> TbMaquinasClientes { get; } = new List<TbMaquinasCliente>();

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();

    public virtual ICollection<TbOperariosCliente> TbOperariosClientes { get; } = new List<TbOperariosCliente>();

    public virtual TbPlanContable? TbPlanContable { get; set; }

    public virtual ICollection<TbPotencialesSeguimiento> TbPotencialesSeguimientos { get; } = new List<TbPotencialesSeguimiento>();

    public virtual ICollection<TbPrevisione> TbPrevisiones { get; } = new List<TbPrevisione>();

    public virtual ICollection<TbPrevisionesTemporal> TbPrevisionesTemporals { get; } = new List<TbPrevisionesTemporal>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();

    public virtual TbPuntosVentum? TbPuntosVentum { get; set; }

    public virtual ICollection<TbTallere> TbTalleres { get; } = new List<TbTallere>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();

    public virtual ICollection<TmpCabeceraTicket> TmpCabeceraTickets { get; } = new List<TmpCabeceraTicket>();

    public virtual ICollection<TrCabeceraAlbaran> TrCabeceraAlbarans { get; } = new List<TrCabeceraAlbaran>();
}
