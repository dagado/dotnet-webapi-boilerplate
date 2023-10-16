using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwTrazabilidad
{
    public string? Idarticulo { get; set; }

    public string? Lote { get; set; }

    public string? Idalmacen { get; set; }

    public string? Almacen { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Nombre { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Precio { get; set; }

    public string? Documento { get; set; }

    public string? Sudocumento { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal Dto { get; set; }

    public decimal Dto1 { get; set; }

    public DateTime? Fechacaducidad { get; set; }
}
