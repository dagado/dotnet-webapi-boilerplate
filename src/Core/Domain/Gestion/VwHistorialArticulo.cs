using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwHistorialArticulo
{
    public string Idempresa { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? IdArticulo { get; set; }

    public string? Referencia { get; set; }

    public string Tipodocumento { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? IdAlmacen { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Serie { get; set; }

    public int Numero { get; set; }

    public string? Sunumero { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? PrecioBruto { get; set; }

    public decimal Iva { get; set; }

    public decimal Dto { get; set; }

    public decimal Dto1 { get; set; }

    public decimal Dto2 { get; set; }

    public decimal? Importe { get; set; }

    public string? Observaciones { get; set; }

    public int? Ejercicio { get; set; }

    public string? Nombre { get; set; }

    public decimal Preciocompraneto { get; set; }

    public string? Almacen { get; set; }

    public string? Idobra { get; set; }

    public string? Iddelegacion { get; set; }

    public decimal? Precioneto { get; set; }

    public string? Idcliente { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public string? Lote { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public string? AlmacenOrigen { get; set; }
}
