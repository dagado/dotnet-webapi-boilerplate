using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPlantillasCuboCostesVehiculo
{
    public string Idlayout { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Strlayout { get; set; }

    public string? Textototalgeneral { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;
}
