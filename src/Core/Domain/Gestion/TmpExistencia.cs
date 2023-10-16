using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpExistencia
{
    public string Idarticulo { get; set; } = null!;

    public decimal? Stock { get; set; }

    public string? Idalmacen { get; set; }

    public decimal? Unidades { get; set; }

    public string? Lote { get; set; }
}
