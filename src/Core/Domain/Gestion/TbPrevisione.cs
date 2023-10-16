using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPrevisione
{
    public string IdPrevision { get; set; } = null!;

    public short Mes { get; set; }

    public short Dia { get; set; }

    public string IdAcreedor { get; set; } = null!;

    public string? Concepto { get; set; }

    public decimal Importe { get; set; }

    public string? Idestado { get; set; }

    public virtual TbCliente IdAcreedorNavigation { get; set; } = null!;

    public virtual TbEstadosCartera? IdestadoNavigation { get; set; }
}
