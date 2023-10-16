using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPotencialesGrupo
{
    public string IdGrupoPotencial { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbPotenciale> TbPotenciales { get; } = new List<TbPotenciale>();
}
