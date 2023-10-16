using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesDireccione
{
    public string Iddireccion { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Codigoprovincia { get; set; }

    public bool Descatalogado { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? Telefono { get; set; }

    public bool Predeterminado { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono2 { get; set; }

    public string? Email { get; set; }

    public virtual TbProvincia? CodigoprovinciaNavigation { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();
}
