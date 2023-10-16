using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTpvUsuario
{
    public string Id { get; set; } = null!;

    public string IdpuntVenta { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual TbTpv IdpuntVentaNavigation { get; set; } = null!;
}
