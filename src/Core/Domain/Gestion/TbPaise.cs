using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPaise
{
    public string CodigoPais { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbClientesCuentasBancaria> TbClientesCuentasBancaria { get; } = new List<TbClientesCuentasBancaria>();
}
