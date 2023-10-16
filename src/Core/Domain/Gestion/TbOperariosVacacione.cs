using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOperariosVacacione
{
    public string Id { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public short Horas { get; set; }

    public string Motivo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public short Color { get; set; }

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;
}
