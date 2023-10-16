using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPresupuestoImpuesto
{
    public string Id { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public decimal Bruto { get; set; }

    public decimal Base { get; set; }

    public decimal Iva { get; set; }

    public string CodigoIva { get; set; } = null!;

    public decimal TotalIva { get; set; }

    public decimal RecargoEquivalencia { get; set; }

    public decimal TotalRecargo { get; set; }

    public decimal TotalPresupuesto { get; set; }

    public string Version { get; set; } = null!;

    public decimal ImporteGastosGenerales { get; set; }

    public decimal ImporteBeneficioIndustrial { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;
}
