using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbIvasCuentasContable
{
    public string Codigoiva { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? Ccivarepercutido { get; set; }

    public string? Ccivasoportado { get; set; }

    public string? Ccrerepercutido { get; set; }

    public string? Ccsoportado { get; set; }

    public virtual TbIva CodigoivaNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;
}
