using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPosicionamientoOperario
{
    public string IdRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public decimal Longitud { get; set; }

    public decimal Latitud { get; set; }

    public string? Observaciones { get; set; }

    public string Idoperario { get; set; } = null!;

    public virtual TbOperario IdoperarioNavigation { get; set; } = null!;
}
