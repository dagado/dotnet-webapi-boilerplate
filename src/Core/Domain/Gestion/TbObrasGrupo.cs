using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasGrupo
{
    public string IdGrupo { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string DescripcionGrupo { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public string? TextoAgrupacion { get; set; }

    public string? IdLista { get; set; }

    public string? Sqltexto { get; set; }

    public short Orden { get; set; }

    public bool ProgramacionTecnicos { get; set; }

    public virtual TbObrasLista? IdListaNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbObrasCuenta> TbObrasCuenta { get; } = new List<TbObrasCuenta>();

    public virtual ICollection<TbObrasDetalleObservacione> TbObrasDetalleObservaciones { get; } = new List<TbObrasDetalleObservacione>();

    public virtual ICollection<TbObrasDetalle> TbObrasDetalles { get; } = new List<TbObrasDetalle>();

    public virtual ICollection<TbObrasPreciosCoste> TbObrasPreciosCostes { get; } = new List<TbObrasPreciosCoste>();

    public virtual ICollection<TbObrasSubgrupo> TbObrasSubgrupos { get; } = new List<TbObrasSubgrupo>();
}
