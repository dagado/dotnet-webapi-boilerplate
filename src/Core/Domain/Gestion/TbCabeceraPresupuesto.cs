using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraPresupuesto
{
    public string IdDocumento { get; set; } = null!;

    public int Numerodocumento { get; set; }

    public string Seriedocumento { get; set; } = null!;

    public DateTime FechaDocumento { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime? FechaAceptacion { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Idobra { get; set; }

    public string Iddiseño { get; set; } = null!;

    public string? Versionaceptada { get; set; }

    public string? Iddelegacion { get; set; }

    public decimal TotalBase { get; set; }

    public decimal TotalImpuestos { get; set; }

    public decimal TotalPresupuesto { get; set; }

    public string Idusuario { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string RazonSocial { get; set; } = null!;

    public bool Modocalculoiva { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public string? Maquinauso { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public decimal Porcentajefacturado { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalcompra { get; set; }

    public bool Mantenerdetalleiva { get; set; }

    public string Ultimaversion { get; set; } = null!;

    public string? Referencia { get; set; }

    public string? IdAviso { get; set; }

    public string? IdClausula { get; set; }

    public string? CampoLibre1 { get; set; }

    public bool CertificacionAorigen { get; set; }

    public string? CarpetaRuta { get; set; }

    public string? Idestado { get; set; }

    public string? Idclasificacion { get; set; }

    public bool ImprimirTotal { get; set; }

    public decimal GastosGenerales { get; set; }

    public decimal BeneficioIndustrial { get; set; }

    public decimal ImporteGastosGenerales { get; set; }

    public decimal ImporteBeneficioIndustrial { get; set; }

    public virtual TbAviso? IdAvisoNavigation { get; set; }

    public virtual TbClausulasDocumento? IdClausulaNavigation { get; set; }

    public virtual TbClasificacion? IdclasificacionNavigation { get; set; }

    public virtual TbCliente Idcliente1 { get; set; } = null!;

    public virtual TbPotenciale IdclienteNavigation { get; set; } = null!;

    public virtual TbClientesDelegacione? IddelegacionNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbPresupuestosEstado? IdestadoNavigation { get; set; }

    public virtual TbObra? IdobraNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbAlbaranCertificacion> TbAlbaranCertificacions { get; } = new List<TbAlbaranCertificacion>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuestoDocumento> TbCabeceraPresupuestoDocumentos { get; } = new List<TbCabeceraPresupuestoDocumento>();

    public virtual ICollection<TbCapitulo> TbCapitulos { get; } = new List<TbCapitulo>();

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();

    public virtual ICollection<TbFacturaCertificacion> TbFacturaCertificacions { get; } = new List<TbFacturaCertificacion>();

    public virtual ICollection<TbObservacionesRevision> TbObservacionesRevisions { get; } = new List<TbObservacionesRevision>();

    public virtual ICollection<TbPresupuestoImpuesto> TbPresupuestoImpuestos { get; } = new List<TbPresupuestoImpuesto>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
