using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbLayout
{
    public string CodigoFormulario { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public string Layout { get; set; } = null!;

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
