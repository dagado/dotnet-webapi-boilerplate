using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbdetalleTarifa
{
    public string Id { get; set; } = null!;

    public string IdTarifa { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public decimal PrecioTarifa { get; set; }

    public decimal? Dto { get; set; }

    public virtual TbArticulo IdArticuloNavigation { get; set; } = null!;

    public virtual TbCabeceraTarifa IdTarifaNavigation { get; set; } = null!;
}
