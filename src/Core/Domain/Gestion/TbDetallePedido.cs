using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetallePedido
{
    public string Id { get; set; } = null!;

    public string Idpedido { get; set; } = null!;

    public short Orden { get; set; }

    public string? Referencia { get; set; }

    public string? Idarticulo { get; set; }

    public string? Descripcion { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public decimal Dto1 { get; set; }

    public decimal Dto2 { get; set; }

    public decimal Importe { get; set; }

    public string? Observaciones { get; set; }

    public decimal Precioii { get; set; }

    public decimal Importeii { get; set; }

    public string Codigoiva { get; set; } = null!;

    public decimal Iva { get; set; }

    public string? Idtarifa { get; set; }

    public string? Unidadmedida { get; set; }

    public decimal Recargo { get; set; }

    public bool Lineaoculta { get; set; }

    public decimal UnidadesRecibidas { get; set; }

    public string? Idalmacen { get; set; }

    public decimal Preciocompraneto { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public string? Idpedidocliente { get; set; }

    public bool Propuesta { get; set; }

    public virtual TbIva CodigoivaNavigation { get; set; } = null!;

    public virtual TbAlmacene? IdalmacenNavigation { get; set; }

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbCabeceraPedido IdpedidoNavigation { get; set; } = null!;

    public virtual TbCabeceraTarifa? IdtarifaNavigation { get; set; }

    public virtual ICollection<TbEntradasTallerPieza> TbEntradasTallerPiezas { get; } = new List<TbEntradasTallerPieza>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();
}
