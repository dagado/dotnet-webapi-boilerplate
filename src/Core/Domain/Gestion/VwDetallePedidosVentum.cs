using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwDetallePedidosVentum
{
    public string Tipo { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? Idarticulo { get; set; }

    public string? Referencia { get; set; }

    public decimal Cantidad { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Stock { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Pedido { get; set; }

    public string? Proveedor { get; set; }

    public DateTime Fecha { get; set; }
}
