using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAdministadoresFinca
{
    public string IdAdministrador { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Codigoprovincia { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public string? Observaciones { get; set; }

    public bool Descatalogado { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();
}
