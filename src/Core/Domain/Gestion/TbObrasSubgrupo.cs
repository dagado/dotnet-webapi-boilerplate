using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasSubgrupo
{
    public string IdSubgrupo { get; set; } = null!;

    public string IdGrupo { get; set; } = null!;

    public string Subgrupo { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public short Factorsigno { get; set; }

    public int? AnchoColCoste { get; set; }

    public short Orden { get; set; }

    public virtual TbObrasGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual ICollection<TbObrasDetalle> TbObrasDetalles { get; } = new List<TbObrasDetalle>();

    public virtual ICollection<TbObrasPreciosCoste> TbObrasPreciosCostes { get; } = new List<TbObrasPreciosCoste>();
}
