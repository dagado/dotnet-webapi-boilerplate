using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOperariosCliente
{
    public string IdCliente { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime? Fechainicio { get; set; }

    public DateTime? Fechafin { get; set; }

    public virtual TbCliente IdClienteNavigation { get; set; } = null!;

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;
}
