using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTpv
{
    public string IdPuntoVenta { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogado { get; set; }

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Skin { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbBancosTpv> TbBancosTpvs { get; } = new List<TbBancosTpv>();

    public virtual ICollection<TbTpvUsuario> TbTpvUsuarios { get; } = new List<TbTpvUsuario>();
}
