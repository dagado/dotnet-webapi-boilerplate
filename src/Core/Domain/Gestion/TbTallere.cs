using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTallere
{
    public string IdTaller { get; set; } = null!;

    public string Taller { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public bool Descatalogado { get; set; }

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Idacreedor { get; set; }

    public virtual TbCliente? IdacreedorNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbLineasCoste> TbLineasCostes { get; } = new List<TbLineasCoste>();
}
