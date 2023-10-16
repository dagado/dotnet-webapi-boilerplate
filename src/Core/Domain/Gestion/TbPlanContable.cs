using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPlanContable
{
    public string Cuenta { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime? Fechaexportado { get; set; }

    public DateTime Fecharegistro { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbTiposArticulo> TbTiposArticulos { get; } = new List<TbTiposArticulo>();
}
