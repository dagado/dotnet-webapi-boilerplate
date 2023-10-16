using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwPedido
{
    public string Iddiseño { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int Numeropedido { get; set; }

    public string Seriepedido { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string? Usuario { get; set; }

    public string? Maquinauso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public string Dni { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Supedido { get; set; }

    public string? Obra { get; set; }

    public string? Descripciondireccion { get; set; }

    public string? Delegacion { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public DateTime? FechaPrevistaEntrega { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalbase { get; set; }

    public decimal Totalpedido { get; set; }

    public decimal Totalimpuestos { get; set; }

    public string Idpedido { get; set; } = null!;

    public decimal Totalcompra { get; set; }

    public string? Ruta { get; set; }

    public string? Puntoventa { get; set; }

    public string CodigoEstado { get; set; } = null!;

    public bool Cerrado { get; set; }

    public bool Servido { get; set; }

    public int? Definicioncolor { get; set; }

    public string Estado { get; set; } = null!;

    public decimal? Beneficio { get; set; }

    public string? Presupuesto { get; set; }

    public decimal? Entregas { get; set; }

    public string Idcliente { get; set; } = null!;

    public int Codigo { get; set; }

    public string? DatosDescarga { get; set; }

    public string? Adjunto { get; set; }
}
