using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbMapeo
{
    public string Id { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Sql { get; set; } = null!;
}
