using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbUnidade
{
    public string IdEmpresa { get; set; } = null!;

    public string Idunidad { get; set; } = null!;

    public string Unidad { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public decimal FactorConversion { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();

    public virtual ICollection<TbReferenciasGasto> TbReferenciasGastos { get; } = new List<TbReferenciasGasto>();
}
