using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbModelosCaracteristica
{
    public string Idcaracteristica { get; set; } = null!;

    public string Idmodelo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual TbModelo IdmodeloNavigation { get; set; } = null!;
}
