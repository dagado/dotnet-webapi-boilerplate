using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbRetencionesCuentasContable
{
    public string CodigoRetencion { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string? CuentaRetencionRepercutido { get; set; }

    public string? CuentaRetencionSoportado { get; set; }

    public virtual TbRetencione CodigoRetencionNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;
}
