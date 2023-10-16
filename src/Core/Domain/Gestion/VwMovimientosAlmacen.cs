using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwMovimientosAlmacen
{
    public string? Maquinauso { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public string IdMovimiento { get; set; } = null!;

    public int? Ejercicio { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public string Usuario { get; set; } = null!;

    public string AlmacenOrigen { get; set; } = null!;

    public string AlmacenDestino { get; set; } = null!;

    public int? Articulosmovidos { get; set; }

    public string IdAlmacenOrigen { get; set; } = null!;

    public string IdAlmacenDestino { get; set; } = null!;

    public int Numero { get; set; }
}
