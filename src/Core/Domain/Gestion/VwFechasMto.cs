using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwFechasMto
{
    public string Idempresa { get; set; } = null!;

    public string Matricula { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public DateTime? FechaProximoMto { get; set; }

    public string Referencia { get; set; } = null!;

    public string Concepto { get; set; } = null!;

    public string TipoMantenimiento { get; set; } = null!;

    public int? Ejercicio { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public int Dato { get; set; }
}
