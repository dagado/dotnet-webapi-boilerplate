using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposArticulo
{
    public string Idempresa { get; set; } = null!;

    public string IdtipoArticulo { get; set; } = null!;

    public string TipoArticulo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool LlevaStock { get; set; }

    public bool Descatalogado { get; set; }

    public bool Predeterminado { get; set; }

    public string Codigoiva { get; set; } = null!;

    public string? Contracuenta { get; set; }

    public string? Contracuentacompras { get; set; }

    public virtual TbIva CodigoivaNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();

    public virtual TbPlanContable? TbPlanContable { get; set; }
}
