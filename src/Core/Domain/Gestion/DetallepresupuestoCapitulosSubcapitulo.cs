using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class DetallepresupuestoCapitulosSubcapitulo
{
    public string Iddetallefactura { get; set; } = null!;

    public string Capitulo { get; set; } = null!;

    public string? Subcapitulo { get; set; }
}
