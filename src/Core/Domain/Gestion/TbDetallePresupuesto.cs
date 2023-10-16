using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetallePresupuesto
{
    public string Id { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string? IdArticulo { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public decimal Importe { get; set; }

    public string? Observaciones { get; set; }

    public short Orden { get; set; }

    public decimal PrecioIi { get; set; }

    public decimal ImporteIi { get; set; }

    public string CodigoIva { get; set; } = null!;

    public decimal Iva { get; set; }

    public string? IdTarifa { get; set; }

    public decimal Dto2 { get; set; }

    public decimal Dto1 { get; set; }

    public string? UnidadMedida { get; set; }

    public decimal Recargo { get; set; }

    public bool LineaOculta { get; set; }

    public string? CodigoCapitulo { get; set; }

    public string? CodigoSubcapitulo { get; set; }

    public string Version { get; set; } = null!;

    public DateTime FechaVersion { get; set; }

    public byte[]? Imagen { get; set; }

    public decimal Preciocompraneto { get; set; }

    public decimal? Cantidadcertificar { get; set; }

    public decimal? Unidades { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public string? CodigoSubCapituloTabla { get; set; }

    public decimal Margen { get; set; }

    public decimal? Incrementogeneral { get; set; }

    public bool Imprimirimportes { get; set; }

    public string? DescripcionAdicional { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbArticulo? IdArticuloNavigation { get; set; }

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;

    public virtual TbCabeceraTarifa? IdTarifaNavigation { get; set; }

    public virtual TbCapitulo? TbCapitulo { get; set; }

    public virtual ICollection<TbDetalleCertificacion> TbDetalleCertificacions { get; } = new List<TbDetalleCertificacion>();

    public virtual TbSubCapitulo? TbSubCapitulo { get; set; }
}
