using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpInventario
{
    public string Idarticulo { get; set; } = null!;

    public string Idalmacen { get; set; } = null!;

    public decimal Stock { get; set; }

    public decimal Preciocoste { get; set; }

    public decimal Precioventa { get; set; }

    public decimal? Unidades { get; set; }

    public string? Lote { get; set; }
}
