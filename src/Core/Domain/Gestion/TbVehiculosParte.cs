using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbVehiculosParte
{
    public string IdParte { get; set; } = null!;

    public string IdVehiculo { get; set; } = null!;

    public DateTime FechaParte { get; set; }

    public string Conductor { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? Responsabilidad { get; set; }

    public string? Matricula { get; set; }

    public virtual TbVehiculo IdVehiculoNavigation { get; set; } = null!;
}
