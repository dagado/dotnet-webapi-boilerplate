using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasDetalle
{
    public string Id { get; set; } = null!;

    public string Idobra { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string IdGrupo { get; set; } = null!;

    public string IdSubGrupo { get; set; } = null!;

    public string IdCuenta { get; set; } = null!;

    public string DescripcionCuenta { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Coste { get; set; }

    public string? TextoLista { get; set; }

    public int Orden { get; set; }

    public virtual TbObrasCuenta IdCuentaNavigation { get; set; } = null!;

    public virtual TbObrasGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual TbObrasSubgrupo IdSubGrupoNavigation { get; set; } = null!;

    public virtual TbObra IdobraNavigation { get; set; } = null!;
}
