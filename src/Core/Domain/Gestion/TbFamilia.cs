using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFamilia
{
    public string Idempresa { get; set; } = null!;

    public string IdFamilia { get; set; } = null!;

    public string? Familia { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Margen { get; set; }

    public bool Descatalogada { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();

    public virtual ICollection<TbSubfamilia> TbSubfamilia { get; } = new List<TbSubfamilia>();
}
