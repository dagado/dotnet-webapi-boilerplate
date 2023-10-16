using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleFabDe
{
    public string IdRegistro { get; set; } = null!;

    public string IdCabecera { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Porcentaje { get; set; }

    public int Orden { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Unidades { get; set; }

    public string Idalmacen { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal Importe { get; set; }

    public string? Unidadmedida { get; set; }

    public string? Lote { get; set; }

    public string? Numeroserie { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public virtual TbArticulo IdArticuloNavigation { get; set; } = null!;

    public virtual TbCabeceraFabDe IdCabeceraNavigation { get; set; } = null!;

    public virtual TbAlmacene IdalmacenNavigation { get; set; } = null!;
}
