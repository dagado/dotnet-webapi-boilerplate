using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Tbparametro
{
    public string Id { get; set; } = null!;

    public string? Valor { get; set; }

    public string? Descripcion { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;
}
