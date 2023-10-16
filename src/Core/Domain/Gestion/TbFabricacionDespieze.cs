using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFabricacionDespieze
{
    public string Id { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public string IdPlantilla { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual TbArticulo IdArticuloNavigation { get; set; } = null!;

    public virtual ICollection<TbFabricacionDespiezeDetalle> TbFabricacionDespiezeDetalles { get; } = new List<TbFabricacionDespiezeDetalle>();
}
