using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbEstadosCartera
{
    public string IdEstadoCartera { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbFormasPago> TbFormasPagos { get; } = new List<TbFormasPago>();

    public virtual ICollection<TbPrevisione> TbPrevisiones { get; } = new List<TbPrevisione>();

    public virtual ICollection<TbPrevisionesTemporal> TbPrevisionesTemporals { get; } = new List<TbPrevisionesTemporal>();

    public virtual ICollection<Tbcartera> Tbcarteras { get; } = new List<Tbcartera>();
}
