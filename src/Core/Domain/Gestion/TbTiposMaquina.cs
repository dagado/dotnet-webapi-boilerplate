using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposMaquina
{
    public string IdTipoMaquina { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbModelo> TbModelos { get; } = new List<TbModelo>();
}
