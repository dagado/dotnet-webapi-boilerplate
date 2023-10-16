using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwArticulosFoto
{
    public string IdEmpresa { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Codigobarras1 { get; set; }

    public string? TipoArticulo { get; set; }

    public bool Descatalogado { get; set; }

    public string? DescripcionAdicional { get; set; }

    public decimal IvaVenta { get; set; }

    public decimal IvaCompra { get; set; }

    public decimal PrecioCompra { get; set; }

    public decimal PrecioVenta { get; set; }

    public string? Marca { get; set; }

    public string? Familia { get; set; }

    public string? Subfamilia { get; set; }

    public decimal? Margen { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Ancho { get; set; }

    public decimal? Largo { get; set; }

    public decimal? Alto { get; set; }

    public decimal? Stock { get; set; }

    public decimal Pvp { get; set; }

    public string? Unidad { get; set; }

    public bool CambioStock { get; set; }

    public decimal? UltimoDto { get; set; }

    public bool NumerosSerie { get; set; }

    public bool Loteado { get; set; }

    public string? Organizacion { get; set; }

    public DateTime? FechaModificacionPrecioVenta { get; set; }

    public string? MaquinaModificaPrecioVenta { get; set; }

    public string? Hipervinculo { get; set; }

    public byte[]? Imagen { get; set; }

    public DateTime? Fechacambiostock { get; set; }

    public DateTime? Fecharegistro { get; set; }

    public string? Maquinaregistro { get; set; }
}
