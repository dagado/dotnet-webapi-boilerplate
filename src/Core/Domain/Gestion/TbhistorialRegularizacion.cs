using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbhistorialRegularizacion
{
    public string IdActualizacionStock { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public string Idarticulo { get; set; } = null!;

    public string Idalmacen { get; set; } = null!;

    public DateTime Fechainventario { get; set; }

    public decimal StockActual { get; set; }

    public decimal StockDiferencia { get; set; }

    public decimal? Precioregularizacion { get; set; }

    public string? Observaciones { get; set; }

    public string? LoteSerie { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public decimal? UnidadesDiferencia { get; set; }

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual TbAlmacene IdalmacenNavigation { get; set; } = null!;

    public virtual TbArticulo IdarticuloNavigation { get; set; } = null!;
}
