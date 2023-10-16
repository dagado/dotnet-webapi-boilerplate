using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbEntradasTallerPieza
{
    public string IdRegistro { get; set; } = null!;

    public string IdEntrada { get; set; } = null!;

    public string? Idarticulo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal Cantidad { get; set; }

    public string? Iddetallepedido { get; set; }

    public bool Pedir { get; set; }

    public bool Facturar { get; set; }

    public decimal Precioventa { get; set; }

    public virtual TbentradasTaller IdEntradaNavigation { get; set; } = null!;

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbDetallePedido? IddetallepedidoNavigation { get; set; }

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();
}
