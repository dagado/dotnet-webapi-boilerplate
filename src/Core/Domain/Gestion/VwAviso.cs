using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwAviso
{
    public string IdAviso { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public string? IdObra { get; set; }

    public string? IdDelegacion { get; set; }

    public int NumeroAviso { get; set; }

    public string SerieAviso { get; set; } = null!;

    public DateTime FechaAviso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string Observaciones { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Incidencia { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Delegacion { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public string? MaquinaUso { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Obra { get; set; }

    public string? CentroTrabajo { get; set; }

    public string? Direccion { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public decimal ImporteAviso { get; set; }

    public int? Ejercicio { get; set; }

    public int? Mes { get; set; }

    public int? Trimestre { get; set; }

    public decimal ImporteCompraAviso { get; set; }

    public string? Rutadocumentos { get; set; }

    public bool Facturar { get; set; }

    public string? Referencia { get; set; }

    public bool Esobra { get; set; }

    public string? Factura { get; set; }

    public short? Certificacion { get; set; }

    public bool Garantia { get; set; }

    public string? ObservacionesInternas { get; set; }

    public string? Administrador { get; set; }

    public decimal PorcentajeMosobreMat { get; set; }

    public decimal? Beneficio { get; set; }
}
