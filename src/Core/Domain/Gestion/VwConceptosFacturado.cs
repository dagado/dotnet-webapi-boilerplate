using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwConceptosFacturado
{
    public string Iddetalle { get; set; } = null!;

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public decimal Importe { get; set; }

    public string? Observaciones { get; set; }

    public short Orden { get; set; }

    public string? Almacen { get; set; }

    public decimal PrecioIi { get; set; }

    public decimal Importeii { get; set; }

    public decimal Iva { get; set; }

    public string? Tarifa { get; set; }

    public decimal Dto2 { get; set; }

    public DateTime Fecharegistro { get; set; }

    public decimal Dto1 { get; set; }

    public string? Tipo { get; set; }

    public decimal Preciocompraneto { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal Recargo { get; set; }

    public bool Lineaoculta { get; set; }

    public string? Contracuentacontable { get; set; }

    public decimal? Retencion { get; set; }

    public string? Matricula { get; set; }

    public string? Numeroaviso { get; set; }

    public DateTime? FechaAviso { get; set; }

    public string? Numeroalbaran { get; set; }

    public DateTime? Fechaalbaran { get; set; }

    public string? Numerofactura { get; set; }

    public DateTime? Fechafactura { get; set; }

    public string? Idcliente { get; set; }

    public string? Obra { get; set; }

    public string? Delegacion { get; set; }

    public decimal? Importecompra { get; set; }

    public bool Engarantia { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public string? Lote { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public string? Familia { get; set; }

    public string? Pedido { get; set; }
}
