using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TrDetalle
{
    public string Idregistro { get; set; } = null!;

    public DateTime Fechahoraregistro { get; set; }

    public string Maquina { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string? IdAviso { get; set; }

    public string IdDetalle { get; set; } = null!;

    public string? IdArticulo { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public decimal Importe { get; set; }

    public string? Observaciones { get; set; }

    public short Orden { get; set; }

    public string? IdAlmacen { get; set; }

    public decimal PrecioIi { get; set; }

    public decimal Importeii { get; set; }

    public string CodigoIva { get; set; } = null!;

    public decimal Iva { get; set; }

    public string? IdTarifa { get; set; }

    public decimal Dto2 { get; set; }

    public DateTime Fecharegistro { get; set; }

    public string? Tipo { get; set; }

    public decimal Dto1 { get; set; }

    public string? Idalbaran { get; set; }

    public string? Idfactura { get; set; }

    public decimal Preciocompraneto { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal Recargo { get; set; }

    public bool Lineaoculta { get; set; }

    public string? Idlineapedido { get; set; }

    public string? Contracuentacontable { get; set; }

    public string? Codigoretencion { get; set; }

    public decimal? Retencion { get; set; }

    public string? Idavisodestino { get; set; }

    public string? Idvehiculo { get; set; }

    public string? Agrupacion { get; set; }

    public bool Engarantia { get; set; }

    public string? Idobra { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public string? Lote { get; set; }

    public string? Proyecto { get; set; }

    public string? Idoperario { get; set; }
}
