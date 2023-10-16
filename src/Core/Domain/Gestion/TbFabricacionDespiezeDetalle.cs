using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFabricacionDespiezeDetalle
{
    public string Iddetalle { get; set; } = null!;

    public string IdPlantilla { get; set; } = null!;

    public string IdarticuloDetalle { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal PorcentajeDespieze { get; set; }

    public int Orden { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Unidades { get; set; }

    public virtual TbFabricacionDespieze IdPlantillaNavigation { get; set; } = null!;

    public virtual TbArticulo IdarticuloDetalleNavigation { get; set; } = null!;
}
