using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDestinatariosMensaje
{
    public string IdCabeceraMensaje { get; set; } = null!;

    public string IdUsuarioDestino { get; set; } = null!;

    public DateTime? FechaLectura { get; set; }

    public virtual TbCabeceraMensaje IdCabeceraMensajeNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioDestinoNavigation { get; set; } = null!;
}
