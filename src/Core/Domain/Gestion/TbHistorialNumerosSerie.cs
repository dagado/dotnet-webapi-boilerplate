using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbHistorialNumerosSerie
{
    public string IdRegistro { get; set; } = null!;

    public string IdDetalleDocumento { get; set; } = null!;

    public string NumeroLoteSerie { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbDetalle IdDetalleDocumentoNavigation { get; set; } = null!;
}
