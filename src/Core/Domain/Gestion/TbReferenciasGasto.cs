using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbReferenciasGasto
{
    public string IdReferencia { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal PrecioCompra { get; set; }

    public bool Descatalogado { get; set; }

    public bool Predeterminado { get; set; }

    public string Idunidad { get; set; } = null!;

    public string? Idtipomantenimiento { get; set; }

    public int? Salto { get; set; }

    public string? Medidasalto { get; set; }

    public string? Idarticulo { get; set; }

    public short? ProrrateoMeses { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbTiposMantenimiento? IdtipomantenimientoNavigation { get; set; }

    public virtual TbUnidade IdunidadNavigation { get; set; } = null!;

    public virtual ICollection<TbLineasCoste> TbLineasCostes { get; } = new List<TbLineasCoste>();
}
