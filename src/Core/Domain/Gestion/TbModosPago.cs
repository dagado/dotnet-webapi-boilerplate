using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbModosPago
{
    public string IdModoPago { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public bool Predetermida { get; set; }

    public bool Defectorecibobancario { get; set; }

    public bool Descatalogado { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbBancosTpv> TbBancosTpvs { get; } = new List<TbBancosTpv>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
