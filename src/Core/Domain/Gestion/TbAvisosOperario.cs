using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAvisosOperario
{
    public string IdAviso { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime? FechaHoraIntervencion { get; set; }

    public short? MinutosIntervencion { get; set; }

    public string Id { get; set; } = null!;

    public decimal Preciohora { get; set; }

    public decimal Importe { get; set; }

    public decimal? HorasIntervencion { get; set; }

    public bool Engarantia { get; set; }

    public string? FicheroFirma { get; set; }

    public virtual TbAviso IdAvisoNavigation { get; set; } = null!;

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;
}
