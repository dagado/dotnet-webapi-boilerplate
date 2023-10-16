using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwRegistrosCosteCubo
{
    public string Idempresa { get; set; } = null!;

    public string TipoMantenimiento { get; set; } = null!;

    public string? IdVehiculo { get; set; }

    public string Matricula { get; set; } = null!;

    public string DescripcionVehiculo { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string? Referencia { get; set; }

    public string? Concepto { get; set; }

    public decimal? Cantidad { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal? PrecioBase { get; set; }

    public decimal Descuento { get; set; }

    public decimal? Importe { get; set; }

    public string? Documento { get; set; }

    public string? Taller { get; set; }

    public string? Responsable { get; set; }

    public int? Ejercicio { get; set; }

    public int? Mes { get; set; }

    public int? Trimestre { get; set; }

    public int? Semana { get; set; }

    public string? Modelo { get; set; }

    public string? Color { get; set; }

    public string? Marca { get; set; }

    public decimal? Rendimiento { get; set; }
}
