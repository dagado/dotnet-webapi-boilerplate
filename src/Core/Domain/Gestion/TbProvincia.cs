using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbProvincia
{
    public string CodigoProvincia { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbClientesDelegacione> TbClientesDelegaciones { get; } = new List<TbClientesDelegacione>();

    public virtual ICollection<TbClientesDireccione> TbClientesDirecciones { get; } = new List<TbClientesDireccione>();

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();

    public virtual ICollection<TbOperario> TbOperarios { get; } = new List<TbOperario>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
