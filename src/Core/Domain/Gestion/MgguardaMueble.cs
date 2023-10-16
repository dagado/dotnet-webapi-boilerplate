using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class MgguardaMueble
{
    public string IdGm { get; set; } = null!;

    public string IdZona { get; set; } = null!;

    public string GuardaMueble { get; set; } = null!;

    public decimal Ancho { get; set; }

    public decimal Largo { get; set; }

    public decimal Alto { get; set; }

    public string? Observaciones { get; set; }

    public decimal PrecioMensual { get; set; }

    public bool Descatalogado { get; set; }

    public virtual Mgzona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<MgpedidoMudanza> MgpedidoMudanzas { get; } = new List<MgpedidoMudanza>();

    public virtual ICollection<TbContrato> TbContratos { get; } = new List<TbContrato>();
}
