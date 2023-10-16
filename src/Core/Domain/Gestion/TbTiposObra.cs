using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposObra
{
    public string IdTipoObra { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Color { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();
}
