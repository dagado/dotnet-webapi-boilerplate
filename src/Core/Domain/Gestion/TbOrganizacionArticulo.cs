using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOrganizacionArticulo
{
    public string IdOrganizacion { get; set; } = null!;

    public string Organizacion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();
}
