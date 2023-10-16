using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraMensaje
{
    public string Id { get; set; } = null!;

    public string IdUsuarioOrigen { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public DateTime FechaHora { get; set; }

    public string Observaciones { get; set; } = null!;

    public string Asunto { get; set; } = null!;

    public string? IdForo { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioOrigenNavigation { get; set; } = null!;

    public virtual ICollection<TbDestinatariosMensaje> TbDestinatariosMensajes { get; } = new List<TbDestinatariosMensaje>();
}
