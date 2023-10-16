using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleMovimientoAlmacen
{
    public string Id { get; set; } = null!;

    public string Idmovimiento { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string? Incidencias { get; set; }

    public int Orden { get; set; }

    public string? LoteSerie { get; set; }

    public string? Unidadmedida { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public decimal? Unidades { get; set; }

    public string? Serie { get; set; }

    public virtual TbArticulo IdArticuloNavigation { get; set; } = null!;

    public virtual TbCabeceraMovimientoAlmacen IdmovimientoNavigation { get; set; } = null!;
}
