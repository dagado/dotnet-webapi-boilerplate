using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class MgpedidoMudanza
{
    public string Id { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string IdUsuario { get; set; } = null!;

    public int NumeroPedido { get; set; }

    public string? Idcliente { get; set; }

    public string Cliente { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public DateTime? FechaMudanza { get; set; }

    public string DireccionRecogida { get; set; } = null!;

    public string DireccionEntrega { get; set; } = null!;

    public string? MontajeDesmontaje { get; set; }

    public string? Embalaje { get; set; }

    public string? Empaquetado { get; set; }

    public string? Roperos { get; set; }

    public string? FundasColchon { get; set; }

    public string? TrasladoconDestino { get; set; }

    public int Operarios { get; set; }

    public bool Ascensor { get; set; }

    public string? Permisos { get; set; }

    public string? Descripcion { get; set; }

    public string? IdGm { get; set; }

    public string Estado { get; set; } = null!;

    public int? MesesPermanencia { get; set; }

    public string? Idfactura { get; set; }

    public string Idempresa { get; set; } = null!;

    public virtual MgguardaMueble? IdGmNavigation { get; set; }

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual TbCliente? IdclienteNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbcabeceraFactura? IdfacturaNavigation { get; set; }
}
