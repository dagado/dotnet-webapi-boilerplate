using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwPresupuesto
{
    public int Numerodocumento { get; set; }

    public string Seriedocumento { get; set; } = null!;

    public DateTime FechaDocumento { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaAceptacion { get; set; }

    public string? Obra { get; set; }

    public string Iddiseño { get; set; } = null!;

    public string? Versionaceptada { get; set; }

    public string? Delegacion { get; set; }

    public decimal TotalBase { get; set; }

    public decimal TotalImpuestos { get; set; }

    public decimal TotalPresupuesto { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime? Fechaimpresion { get; set; }

    public string? Maquinauso { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public decimal Porcentajefacturado { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalcompra { get; set; }

    public decimal? Beneficio { get; set; }

    public string Ultimaversion { get; set; } = null!;

    public decimal? DescuentoEuros { get; set; }

    public decimal? Entrega { get; set; }

    public int Codigo { get; set; }

    public string? Referencia { get; set; }

    public string? Aviso { get; set; }

    public string? CampoLibre1 { get; set; }

    public bool Certificacionaorigen { get; set; }

    public string? CarpetaRuta { get; set; }

    public string? Idestado { get; set; }

    public string? Estado { get; set; }

    public string? Clasificacion { get; set; }

    public string? Direccioncliente { get; set; }

    public string? Localidadcliente { get; set; }

    public string? Direccionobra { get; set; }

    public string? Localidadobra { get; set; }

    public decimal Gastosgenerales { get; set; }

    public decimal Beneficioindustrial { get; set; }

    public decimal ImporteGastosGenerales { get; set; }

    public decimal ImporteBeneficioIndustrial { get; set; }
}
