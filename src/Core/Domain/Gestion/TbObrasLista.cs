using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasLista
{
    public string IdLista { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Descatalogada { get; set; }

    public string? Observaciones { get; set; }

    public string? Sqltexto { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbObrasDetalleListum> TbObrasDetalleLista { get; } = new List<TbObrasDetalleListum>();

    public virtual ICollection<TbObrasGrupo> TbObrasGrupos { get; } = new List<TbObrasGrupo>();
}
