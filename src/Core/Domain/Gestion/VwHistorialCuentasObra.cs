using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwHistorialCuentasObra
{
    public string IdCuenta { get; set; } = null!;

    public string Obra { get; set; } = null!;

    public DateTime? Fechainicio { get; set; }

    public DateTime? Fechafinalizacion { get; set; }

    public string? Referencia { get; set; }

    public DateTime Fecha { get; set; }

    public string DescripcionGrupo { get; set; } = null!;

    public string Subgrupo { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public string DescripcionCuenta { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Coste { get; set; }

    public string? TextoLista { get; set; }

    public decimal? Importe { get; set; }

    public string? Observaciones { get; set; }
}
