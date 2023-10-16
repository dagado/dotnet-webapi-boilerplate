using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwLineasDocumento
{
    public string Tipo { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? Idarticulo { get; set; }

    public string? Descripcion { get; set; }

    public string? Referencia { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public decimal Importe { get; set; }

    public short Orden { get; set; }

    public decimal PrecioIi { get; set; }

    public decimal ImporteIi { get; set; }

    public string Codigoiva { get; set; } = null!;

    public decimal Iva { get; set; }

    public decimal Dto2 { get; set; }

    public decimal Dto1 { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal Recargo { get; set; }

    public bool LineaOculta { get; set; }

    public string Version { get; set; } = null!;

    public int Numerodocumento { get; set; }

    public string Seriedocumento { get; set; } = null!;

    public DateTime? FechaDocumento { get; set; }

    public string Idcliente { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal Preciocompraneto { get; set; }

    public string? ReferenciaDocumento { get; set; }

    public string? Agrupacion { get; set; }

    public string? Obra { get; set; }

    public string? Idobra { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Alto { get; set; }

    public decimal? Largo { get; set; }

    public string? Lote { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public decimal Margen { get; set; }

    public decimal? Incrementogeneral { get; set; }

    public string? Idoperario { get; set; }
}
