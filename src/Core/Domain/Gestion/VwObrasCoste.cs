using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwObrasCoste
{
    public string? Idempresa { get; set; }

    public string Idobra { get; set; } = null!;

    public string Obra { get; set; } = null!;

    public string? ObraDireccion { get; set; }

    public string? ObraCodigoPostal { get; set; }

    public string? ObraLocalidad { get; set; }

    public string? ObraObservaciones { get; set; }

    public DateTime? ObraFechaFinalizacion { get; set; }

    public DateTime? ObraFechaInicio { get; set; }

    public string? ObraReferencia { get; set; }

    public string? ObraProvincia { get; set; }

    public string ObraCliente { get; set; } = null!;

    public string ObraDniCliente { get; set; } = null!;

    public decimal? ObraPresupuestado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string Grupo { get; set; } = null!;

    public string? GrupoAgrupacion { get; set; }

    public string Subgrupo { get; set; } = null!;

    public string? DescripcionCuenta { get; set; }

    public string? ReferenciaCuenta { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Coste { get; set; }

    public string? TextoLista { get; set; }

    public decimal? Importe { get; set; }

    public string? Observaciones { get; set; }

    public string? Proyecto { get; set; }
}
