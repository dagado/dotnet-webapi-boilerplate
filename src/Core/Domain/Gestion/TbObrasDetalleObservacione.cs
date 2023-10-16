using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasDetalleObservacione
{
    public string Id { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string IdCuenta { get; set; } = null!;

    public string IdGrupo { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Idobra { get; set; } = null!;

    public int Orden { get; set; }

    public string? Proyecto { get; set; }

    public virtual TbObrasCuenta IdCuentaNavigation { get; set; } = null!;

    public virtual TbObrasGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual TbObra IdobraNavigation { get; set; } = null!;
}
