using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFormasPago
{
    public string IdFormaPago { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Intervalo { get; set; } = null!;

    public short Salto { get; set; }

    public short Vencimientos { get; set; }

    public short? Inicio { get; set; }

    public short? Diafijo { get; set; }

    public string? Observacionesfactura { get; set; }

    public short? Diafijo2 { get; set; }

    public bool Predeterminada { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? CodigoDatisa { get; set; }

    public bool Ivapagatitular { get; set; }

    public bool Ultimodiames { get; set; }

    public string? IdEstadoCartea { get; set; }

    public bool Descatalogado { get; set; }

    public virtual TbEstadosCartera? IdEstadoCarteaNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbBancosTpv> TbBancosTpvs { get; } = new List<TbBancosTpv>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
