using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasPreciosCoste
{
    public string Id { get; set; } = null!;

    public string IdGrupo { get; set; } = null!;

    public string IdCuenta { get; set; } = null!;

    public string IdSubGrupo { get; set; } = null!;

    public decimal PrecioCoste { get; set; }

    public virtual TbObrasCuenta IdCuentaNavigation { get; set; } = null!;

    public virtual TbObrasGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual TbObrasSubgrupo IdSubGrupoNavigation { get; set; } = null!;
}
