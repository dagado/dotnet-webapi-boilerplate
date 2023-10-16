using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwLog
{
    public string Idempresa { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime FechaHora { get; set; }

    public string? Accion { get; set; }

    public string? Maquina { get; set; }

    public string? IdExterno { get; set; }

    public string? Tabla { get; set; }
}
