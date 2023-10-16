using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlmacene
{
    public string IdEmpresa { get; set; } = null!;

    public string IdAlmacen { get; set; } = null!;

    public string Almacen { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Almacenpordefecto { get; set; }

    public bool Descatalogado { get; set; }

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public short Prioridad { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCabeceraFabDe> TbCabeceraFabDes { get; } = new List<TbCabeceraFabDe>();

    public virtual ICollection<TbCabeceraMovimientoAlmacen> TbCabeceraMovimientoAlmacenIdAlmacenDestinoNavigations { get; } = new List<TbCabeceraMovimientoAlmacen>();

    public virtual ICollection<TbCabeceraMovimientoAlmacen> TbCabeceraMovimientoAlmacenIdAlmacenOrigenNavigations { get; } = new List<TbCabeceraMovimientoAlmacen>();

    public virtual ICollection<TbDetalleFabDe> TbDetalleFabDes { get; } = new List<TbDetalleFabDe>();

    public virtual ICollection<TbDetallePedido> TbDetallePedidos { get; } = new List<TbDetallePedido>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbFabricacionSalida> TbFabricacionSalida { get; } = new List<TbFabricacionSalida>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();

    public virtual ICollection<TbSeriesFactura> TbSeriesFacturas { get; } = new List<TbSeriesFactura>();

    public virtual ICollection<TbalmacenesStock> TbalmacenesStocks { get; } = new List<TbalmacenesStock>();

    public virtual ICollection<TbhistorialRegularizacion> TbhistorialRegularizacions { get; } = new List<TbhistorialRegularizacion>();

    public virtual ICollection<TmpDetalleTicket> TmpDetalleTickets { get; } = new List<TmpDetalleTicket>();
}
