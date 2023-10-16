using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwEntradasTaller
{
    public int NumeroEntrada { get; set; }

    public string SerieEntrada { get; set; } = null!;

    public DateTime FechaEntrada { get; set; }

    public string? NumeroSerie { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Averia { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string IdEstadoEntrada { get; set; } = null!;

    public decimal Importe { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Maquinauso { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public DateTime? Fechafin { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public string? Presupuesto { get; set; }

    public string? Albaran { get; set; }

    public string? Factura { get; set; }

    public string Cliente { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string Dni { get; set; } = null!;

    public string IdEntrada { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Localidad { get; set; }

    public string? Observacionesentrada { get; set; }

    public string? Provincia { get; set; }

    public string Idmaquina { get; set; } = null!;
}
