using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetallePerfil
{
    public string IdDetalle { get; set; } = null!;

    public string IdPerfil { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Acceso { get; set; }

    public virtual TbPerfile IdPerfilNavigation { get; set; } = null!;
}
