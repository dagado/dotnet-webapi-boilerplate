using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbEntradasTallerSeguimiento
{
    public string Idregistro { get; set; } = null!;

    public string IdEntrada { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string IdEstado { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public virtual TbentradasTaller IdEntradaNavigation { get; set; } = null!;

    public virtual TbEntradasTallerEstado IdEstadoNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
