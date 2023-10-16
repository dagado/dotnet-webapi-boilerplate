using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwPartesOperario
{
    public string Idparte { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaParte { get; set; }

    public string? Observaciones { get; set; }

    public string? NombreDocumento { get; set; }

    public decimal Importe { get; set; }

    public decimal Importecoste { get; set; }

    public string? Descripcion { get; set; }

    public string? Maquinauso { get; set; }

    public string Idnumero { get; set; } = null!;
}
