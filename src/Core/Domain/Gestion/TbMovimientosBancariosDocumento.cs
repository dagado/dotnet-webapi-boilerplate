using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbMovimientosBancariosDocumento
{
    public string Id { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public string NombreDocumento { get; set; } = null!;

    public virtual Tbmovimientosbancario IdNavigation { get; set; } = null!;
}
