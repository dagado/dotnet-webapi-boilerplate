using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbSeriesDiseñoDocumento
{
    public string Id { get; set; } = null!;

    public string Seriefactura { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Plantillafactura { get; set; }

    public bool Descatalogado { get; set; }

    public bool Predeterminada { get; set; }

    public short Copias { get; set; }

    public string? Iddiseñocopia { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbCaja> TbCajas { get; } = new List<TbCaja>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbDiseñosSubInforme> TbDiseñosSubInformes { get; } = new List<TbDiseñosSubInforme>();

    public virtual TbSeriesFactura TbSeriesFactura { get; set; } = null!;

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<TmpCabeceraTicket> TmpCabeceraTickets { get; } = new List<TmpCabeceraTicket>();
}
