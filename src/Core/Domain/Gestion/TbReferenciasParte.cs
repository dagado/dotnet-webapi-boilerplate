using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbReferenciasParte
{
    public string IdReferencia { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public decimal Precio { get; set; }

    public string? Descripcion2 { get; set; }

    public string? Referencia2 { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleParteOperario> TbDetalleParteOperarios { get; } = new List<TbDetalleParteOperario>();
}
