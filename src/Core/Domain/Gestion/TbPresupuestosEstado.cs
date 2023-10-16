using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPresupuestosEstado
{
    public string IdEstado { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public int? DefinicionColor { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();
}
