using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class FacturasVencimientosManuale
{
    public string Idfactura { get; set; } = null!;

    public virtual TbcabeceraFactura IdfacturaNavigation { get; set; } = null!;
}
