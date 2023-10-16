using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAccesosDirecto
{
    public string Id { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public short Orden { get; set; }

    public string? Maquina { get; set; }
}
