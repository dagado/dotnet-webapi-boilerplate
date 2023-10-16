using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlertasDestinatario
{
    public string Id { get; set; } = null!;

    public string IdAlerta { get; set; } = null!;

    public string IdUsuarioDestino { get; set; } = null!;

    public DateTime? FechaTramitacion { get; set; }

    public bool Tramitada { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbAlerta IdAlertaNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioDestinoNavigation { get; set; } = null!;
}
