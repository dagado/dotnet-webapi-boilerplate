using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposMantenimiento
{
    public string IdTipoMantenimiento { get; set; } = null!;

    public string TipoMantenimiento { get; set; } = null!;

    public string ProximoMtoen { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string IdLayout { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public bool Predeterminado { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbLineasCoste> TbLineasCostes { get; } = new List<TbLineasCoste>();

    public virtual ICollection<TbReferenciasGasto> TbReferenciasGastos { get; } = new List<TbReferenciasGasto>();
}
