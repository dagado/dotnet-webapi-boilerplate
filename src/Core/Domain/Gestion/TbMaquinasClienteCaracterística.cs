using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbMaquinasClienteCaracterística
{
    public string Idcaracteristica { get; set; } = null!;

    public string Idmaquina { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual TbMaquinasCliente IdmaquinaNavigation { get; set; } = null!;
}
