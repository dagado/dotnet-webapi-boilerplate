using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbEntradasTallerEstado
{
    public string IdEstado { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public int? DefinicionColor { get; set; }

    public string Accion { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbEntradasTallerSeguimiento> TbEntradasTallerSeguimientos { get; } = new List<TbEntradasTallerSeguimiento>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();
}
