using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwRegistroPedido
{
    public string? Idarticulo { get; set; }

    public string? Descripcion { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Pendiente { get; set; }

    public decimal? Importe { get; set; }

    public string? Observaciones { get; set; }

    public DateTime Fecha { get; set; }

    public string? Documento { get; set; }

    public string Tipo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Depedidocliente { get; set; }

    public string? Detaller { get; set; }
}
