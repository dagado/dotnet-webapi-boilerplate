using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpEtiqueta
{
    public string? Referencia { get; set; }

    public string? Descripcion { get; set; }

    public string? Codigobarras1 { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? Pvp { get; set; }

    public string? Unidad { get; set; }

    public short? Orden { get; set; }

    public string Id { get; set; } = null!;

    public string? Iddetalle { get; set; }
}
