using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPrevisionesTemporal
{
    public string IdAcreedor { get; set; } = null!;

    public short Mes { get; set; }

    public string? Observaciones { get; set; }

    public string? Idestado { get; set; }

    public int Año { get; set; }

    public virtual TbCliente IdAcreedorNavigation { get; set; } = null!;

    public virtual TbEstadosCartera? IdestadoNavigation { get; set; }
}
