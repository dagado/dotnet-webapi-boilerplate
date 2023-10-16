using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbIva
{
    public string Descripcion { get; set; } = null!;

    public decimal Iva { get; set; }

    public bool Predeterminado { get; set; }

    public string Codigoiva { get; set; } = null!;

    public string? Tipodatisa { get; set; }

    public string? Clase { get; set; }

    public decimal RecargoEquivalencia { get; set; }

    public string? Tipodatisarecargo { get; set; }

    public string? Claserecargo { get; set; }

    public string? Subclase { get; set; }

    public string? Claserecibidas { get; set; }

    public string? Tipoimpuestodatisa { get; set; }

    public string Tipoiva { get; set; } = null!;

    public string? TextoContabilidad { get; set; }

    public string? TextoContabilidadRecargo { get; set; }

    public string? CodigoA3 { get; set; }

    public string? IntraS { get; set; }

    public string? IntraR { get; set; }

    public virtual TbIva? IntraRNavigation { get; set; }

    public virtual TbIva? IntraSNavigation { get; set; }

    public virtual ICollection<TbIva> InverseIntraRNavigation { get; } = new List<TbIva>();

    public virtual ICollection<TbIva> InverseIntraSNavigation { get; } = new List<TbIva>();

    public virtual ICollection<TbAlbaranImpuesto> TbAlbaranImpuestos { get; } = new List<TbAlbaranImpuesto>();

    public virtual ICollection<TbArticulo> TbArticuloCodigoIvaVentaNavigations { get; } = new List<TbArticulo>();

    public virtual ICollection<TbArticulo> TbArticuloCoidgoIvaCompraNavigations { get; } = new List<TbArticulo>();

    public virtual ICollection<TbArticulosPack> TbArticulosPackCodigoIvaCompraNavigations { get; } = new List<TbArticulosPack>();

    public virtual ICollection<TbArticulosPack> TbArticulosPackCodigoIvaVentaNavigations { get; } = new List<TbArticulosPack>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbDetalleContrato> TbDetalleContratos { get; } = new List<TbDetalleContrato>();

    public virtual ICollection<TbDetallePedido> TbDetallePedidos { get; } = new List<TbDetallePedido>();

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbFacturaImpuesto> TbFacturaImpuestos { get; } = new List<TbFacturaImpuesto>();

    public virtual ICollection<TbIvasCuentasContable> TbIvasCuentasContables { get; } = new List<TbIvasCuentasContable>();

    public virtual ICollection<TbPedidoImpuesto> TbPedidoImpuestos { get; } = new List<TbPedidoImpuesto>();

    public virtual ICollection<TbPresupuestoImpuesto> TbPresupuestoImpuestos { get; } = new List<TbPresupuestoImpuesto>();

    public virtual ICollection<TbSeriesFactura> TbSeriesFacturas { get; } = new List<TbSeriesFactura>();

    public virtual ICollection<TbTiposArticulo> TbTiposArticulos { get; } = new List<TbTiposArticulo>();

    public virtual ICollection<TmpDetalleTicket> TmpDetalleTickets { get; } = new List<TmpDetalleTicket>();
}
