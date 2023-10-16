using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbSubfamilia
{
    public string IdFamilia { get; set; } = null!;

    public string IdSubfamilia { get; set; } = null!;

    public string Subfamilia { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal? Margen { get; set; }

    public bool Descatalogada { get; set; }

    public virtual TbFamilia IdFamiliaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();
}
