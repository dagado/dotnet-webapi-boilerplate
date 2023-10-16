using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbVehiculosAmortizacione
{
    public string Id { get; set; } = null!;

    public string IdVehiculo { get; set; } = null!;

    public DateTime FechaAmortizacion { get; set; }

    public decimal ImporteAmortizacion { get; set; }

    public bool EsInicial { get; set; }

    public virtual TbVehiculo IdVehiculoNavigation { get; set; } = null!;
}
