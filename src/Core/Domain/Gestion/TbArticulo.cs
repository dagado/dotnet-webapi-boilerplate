using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbArticulo
{
    public string IdEmpresa { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Codigobarras1 { get; set; }

    public string? Codigobarras2 { get; set; }

    public string? Codigobarras3 { get; set; }

    public string? Idtipoarticulo { get; set; }

    public bool Descatalogado { get; set; }

    public string? DescripcionAdicional { get; set; }

    public string CodigoIvaVenta { get; set; } = null!;

    public string CoidgoIvaCompra { get; set; } = null!;

    public decimal PrecioCompra { get; set; }

    public decimal PrecioVenta { get; set; }

    public string? Idmarca { get; set; }

    public string? Idsubfamilia { get; set; }

    public string? Idunidad { get; set; }

    public string? Idfamilia { get; set; }

    public string? Observaciones { get; set; }

    public byte[]? Imagen { get; set; }

    public decimal? Margen { get; set; }

    public bool NumerosSerie { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public bool Loteado { get; set; }

    public decimal? Stock { get; set; }

    public decimal Pvp { get; set; }

    public bool CambioStock { get; set; }

    public bool ExcluirTarifa { get; set; }

    public decimal? UltimoDto { get; set; }

    public decimal UdsDefVentas { get; set; }

    public string? IdOrganizacion { get; set; }

    public DateTime? FechaModificacionPrecioVenta { get; set; }

    public string? MaquinaModificaPrecioVenta { get; set; }

    public string? Hipervinculo { get; set; }

    public DateTime? Fechacambiostock { get; set; }

    public DateTime? Fecharegistro { get; set; }

    public string? Maquinaregistro { get; set; }

    public virtual TbIva CodigoIvaVentaNavigation { get; set; } = null!;

    public virtual TbIva CoidgoIvaCompraNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbOrganizacionArticulo? IdOrganizacionNavigation { get; set; }

    public virtual TbFamilia? IdfamiliaNavigation { get; set; }

    public virtual TbMarca? IdmarcaNavigation { get; set; }

    public virtual TbSubfamilia? IdsubfamiliaNavigation { get; set; }

    public virtual TbTiposArticulo? IdtipoarticuloNavigation { get; set; }

    public virtual TbUnidade? IdunidadNavigation { get; set; }

    public virtual ICollection<TbArticulosPack> TbArticulosPacks { get; } = new List<TbArticulosPack>();

    public virtual ICollection<TbArticulosReferenciasCompra> TbArticulosReferenciasCompras { get; } = new List<TbArticulosReferenciasCompra>();

    public virtual ICollection<TbCabeceraFabDe> TbCabeceraFabDes { get; } = new List<TbCabeceraFabDe>();

    public virtual ICollection<TbClientesFacturacionPeriodica> TbClientesFacturacionPeriodicas { get; } = new List<TbClientesFacturacionPeriodica>();

    public virtual ICollection<TbDetalleFabDe> TbDetalleFabDes { get; } = new List<TbDetalleFabDe>();

    public virtual ICollection<TbDetalleMovimientoAlmacen> TbDetalleMovimientoAlmacens { get; } = new List<TbDetalleMovimientoAlmacen>();

    public virtual ICollection<TbDetallePedido> TbDetallePedidos { get; } = new List<TbDetallePedido>();

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbEntradasTallerPieza> TbEntradasTallerPiezas { get; } = new List<TbEntradasTallerPieza>();

    public virtual ICollection<TbFabricacionDespiezeDetalle> TbFabricacionDespiezeDetalles { get; } = new List<TbFabricacionDespiezeDetalle>();

    public virtual ICollection<TbFabricacionDespieze> TbFabricacionDespiezes { get; } = new List<TbFabricacionDespieze>();

    public virtual ICollection<TbOperario> TbOperarios { get; } = new List<TbOperario>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();

    public virtual ICollection<TbReferenciasGasto> TbReferenciasGastos { get; } = new List<TbReferenciasGasto>();

    public virtual ICollection<TbalmacenesStock> TbalmacenesStocks { get; } = new List<TbalmacenesStock>();

    public virtual ICollection<TbdetalleTarifa> TbdetalleTarifas { get; } = new List<TbdetalleTarifa>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<TbhistorialRegularizacion> TbhistorialRegularizacions { get; } = new List<TbhistorialRegularizacion>();

    public virtual ICollection<TmpDetalleTicket> TmpDetalleTickets { get; } = new List<TmpDetalleTicket>();

    public virtual ICollection<TmpRetorno> TmpRetornos { get; } = new List<TmpRetorno>();
}
