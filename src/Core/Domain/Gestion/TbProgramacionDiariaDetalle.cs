using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbProgramacionDiariaDetalle
{
    public string Idregistro { get; set; } = null!;

    public string IdDiario { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string? Idvehiculo { get; set; }

    public string? IdObra1 { get; set; }

    public string? IdObra2 { get; set; }

    public string? IdObra3 { get; set; }

    public string? IdObra4 { get; set; }

    public string? IdObra5 { get; set; }

    public string? Combo { get; set; }

    public string? Observaciones { get; set; }

    public string? Observaciones2 { get; set; }

    public string? Observaciones3 { get; set; }

    public string? Observaciones4 { get; set; }

    public string? Observaciones5 { get; set; }

    public virtual TbProgramacionDiarium IdDiarioNavigation { get; set; } = null!;

    public virtual TbObra? IdObra1Navigation { get; set; }

    public virtual TbObra? IdObra2Navigation { get; set; }

    public virtual TbObra? IdObra3Navigation { get; set; }

    public virtual TbObra? IdObra4Navigation { get; set; }

    public virtual TbObra? IdObra5Navigation { get; set; }

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;

    public virtual TbVehiculo? IdvehiculoNavigation { get; set; }
}
