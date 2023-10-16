using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesDelegacione
{
    public string Iddelegacion { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Contacto { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Movil { get; set; }

    public string? Observaciones { get; set; }

    public bool Descatalogado { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? CodigoProvincia { get; set; }

    public string? IdTarifa { get; set; }

    public string? CodigoAdministracion { get; set; }

    public string? OrganoGestor { get; set; }

    public string? UnidadTramitadora { get; set; }

    public string? Idcuenta { get; set; }

    public bool Recargoequivalencia { get; set; }

    public string? OrganoProponente { get; set; }

    public virtual TbProvincia? CodigoProvinciaNavigation { get; set; }

    public virtual TbCabeceraTarifa? IdTarifaNavigation { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbClientesCuentasBancaria? IdcuentaNavigation { get; set; }

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbClientesFacturacionPeriodica> TbClientesFacturacionPeriodicas { get; } = new List<TbClientesFacturacionPeriodica>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
