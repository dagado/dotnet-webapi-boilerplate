using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPotencialesSeguimiento
{
    public string Id { get; set; } = null!;

    public string IdPotencial { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public string IdAccion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idusuario { get; set; } = null!;

    public virtual TbPotencialesEstado IdAccionNavigation { get; set; } = null!;

    public virtual TbCliente IdPotencial1 { get; set; } = null!;

    public virtual TbPotenciale IdPotencialNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;
}
