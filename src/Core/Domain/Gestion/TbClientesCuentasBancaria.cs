using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesCuentasBancaria
{
    public string Idcuenta { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Idcliente { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Iban { get; set; } = null!;

    public string? Referenciamandato { get; set; }

    public bool Pagoperiodico { get; set; }

    public string? Bic { get; set; }

    public bool Predeterminada { get; set; }

    public bool Descatalogada { get; set; }

    public DateTime? Fechafirmamandato { get; set; }

    public string? CuentaExtraComunitaria { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbPaise PaisNavigation { get; set; } = null!;

    public virtual ICollection<TbClientesDelegacione> TbClientesDelegaciones { get; } = new List<TbClientesDelegacione>();

    public virtual ICollection<Tbcartera> Tbcarteras { get; } = new List<Tbcartera>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
