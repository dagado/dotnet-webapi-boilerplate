using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleParteOperario
{
    public string Id { get; set; } = null!;

    public string IdParte { get; set; } = null!;

    public string? Idobra { get; set; }

    public string? IdVehiculo { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioHora { get; set; }

    public string? Observaciones { get; set; }

    public string Concepto { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string IdUsuario { get; set; } = null!;

    public decimal Preciocoste { get; set; }

    public string? Proyecto { get; set; }

    public string? Idreferencia { get; set; }

    public int Orden { get; set; }

    public string? Idobra0 { get; set; }

    public string? Proyecto0 { get; set; }

    public virtual TbParteOperario IdParteNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual TbVehiculo? IdVehiculoNavigation { get; set; }

    public virtual TbObra? IdobraNavigation { get; set; }

    public virtual TbReferenciasParte? IdreferenciaNavigation { get; set; }
}
