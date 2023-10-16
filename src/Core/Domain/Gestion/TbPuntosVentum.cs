using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPuntosVentum
{
    public string PuntoVenta { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbBanco> TbBancos { get; } = new List<TbBanco>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbSeriesFactura> TbSeriesFacturas { get; } = new List<TbSeriesFactura>();

    public virtual ICollection<TbUsuario> TbUsuarios { get; } = new List<TbUsuario>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
