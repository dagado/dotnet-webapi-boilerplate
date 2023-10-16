using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasDetalleListum
{
    public string Id { get; set; } = null!;

    public string IdLista { get; set; } = null!;

    public string TextoLista { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public virtual TbObrasLista IdListaNavigation { get; set; } = null!;
}
