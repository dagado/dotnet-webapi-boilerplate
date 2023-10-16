using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwDetallePartesOperario
{
    public string? IdOperario { get; set; }

    public int? Ejercicio { get; set; }

    public DateTime FechaParte { get; set; }

    public string? Descripcion { get; set; }

    public string? Idnumero { get; set; }

    public string? Matricula { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal Preciocoste { get; set; }

    public decimal? Ingreso { get; set; }

    public string Concepto { get; set; } = null!;

    public string? Referencia { get; set; }

    public string? Referenciaobra { get; set; }

    public string? Obra { get; set; }
}
