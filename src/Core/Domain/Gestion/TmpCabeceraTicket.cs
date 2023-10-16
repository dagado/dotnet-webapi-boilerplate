using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpCabeceraTicket
{
    public string IdRegistro { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string SerieTicket { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string IdDiseño { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public virtual TbCliente IdClienteNavigation { get; set; } = null!;

    public virtual TbSeriesDiseñoDocumento IdDiseñoNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbSeriesFactura TbSeriesFactura { get; set; } = null!;

    public virtual ICollection<TmpDetalleTicket> TmpDetalleTickets { get; } = new List<TmpDetalleTicket>();
}
