using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlbaranImpuesto
{
    public string Id { get; set; } = null!;

    public string IdAlbaran { get; set; } = null!;

    public decimal Bruto { get; set; }

    public decimal Base { get; set; }

    public decimal Iva { get; set; }

    public string CodigoIva { get; set; } = null!;

    public decimal TotalIva { get; set; }

    public decimal RecargoEquivalencia { get; set; }

    public decimal TotalRecargo { get; set; }

    public decimal TotalAlbaran { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbcabeceraAlbaran IdAlbaranNavigation { get; set; } = null!;
}
