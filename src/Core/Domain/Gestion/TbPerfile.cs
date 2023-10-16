using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPerfile
{
    public string IdPerfil { get; set; } = null!;

    public string Perfil { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbDetallePerfil> TbDetallePerfils { get; } = new List<TbDetallePerfil>();

    public virtual ICollection<TbUsuario> TbUsuarios { get; } = new List<TbUsuario>();
}
