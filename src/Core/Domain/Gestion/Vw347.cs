using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Vw347
{
    public string Idempresa { get; set; } = null!;

    public int? Ejercicio { get; set; }

    public string Tipo { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public decimal? Trim1 { get; set; }

    public decimal? Trim2 { get; set; }

    public decimal? Trim3 { get; set; }

    public decimal? Trim4 { get; set; }

    public decimal? Total { get; set; }
}
