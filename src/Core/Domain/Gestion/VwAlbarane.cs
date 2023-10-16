using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwAlbarane
{
    public string Iddiseño { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime FechaAlbaran { get; set; }

    public int Numeroalbaran { get; set; }

    public string Seriealbaran { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public string Dni { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Sualbaran { get; set; }

    public DateTime? Sufecha { get; set; }

    public string? Obra { get; set; }

    public string? Nombredocumento { get; set; }

    public string? Delegacion { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalbase { get; set; }

    public decimal Totalimpuestos { get; set; }

    public decimal Totalalbaran { get; set; }

    public decimal Totalcompra { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public string Idalbaran { get; set; } = null!;

    public string? Ruta { get; set; }

    public string? Puntoventa { get; set; }

    public bool Facturado { get; set; }

    public string? DocumentoFactura { get; set; }

    public string Idcliente { get; set; } = null!;

    public decimal? Beneficio { get; set; }

    public int Codigo { get; set; }

    public decimal? Entregas { get; set; }

    public string? DreccionEntrega { get; set; }

    public string? Presupuesto { get; set; }

    public string? Observacionesinternas { get; set; }

    public string? Formapago { get; set; }
}
