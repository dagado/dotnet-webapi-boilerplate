using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOperariosRutasDocumento
{
    public string IdRuta { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string DescripcionRuta { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;
}
