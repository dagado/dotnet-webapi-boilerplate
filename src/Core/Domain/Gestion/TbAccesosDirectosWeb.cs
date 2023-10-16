using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAccesosDirectosWeb
{
    public string IdWeb { get; set; } = null!;

    public string Web { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public short Orden { get; set; }

    public string? Maquina { get; set; }
}
