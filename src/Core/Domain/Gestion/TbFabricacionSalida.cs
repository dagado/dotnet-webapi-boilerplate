using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFabricacionSalida
{
    public string Idregistro { get; set; } = null!;

    public string IdFabricacion { get; set; } = null!;

    public DateTime FechaSalida { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Unidades { get; set; }

    public string Idalmacen { get; set; } = null!;

    public decimal CosteUnidad { get; set; }

    public string? Lote { get; set; }

    public string? Serie { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public string? Documento { get; set; }

    public virtual TbCabeceraFabDe IdFabricacionNavigation { get; set; } = null!;

    public virtual TbAlmacene IdalmacenNavigation { get; set; } = null!;
}
