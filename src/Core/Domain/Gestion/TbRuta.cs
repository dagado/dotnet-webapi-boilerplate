using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbRuta
{
    public string Idruta { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();
}
