using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwSeguimientoPotenciale
{
    public string Id { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public decimal? Importe { get; set; }

    public string? IdAccion { get; set; }

    public string? Idpotencial { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public string? Accion { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public int? Colorcalendario { get; set; }
}
