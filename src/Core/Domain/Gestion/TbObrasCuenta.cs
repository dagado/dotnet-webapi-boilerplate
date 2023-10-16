using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObrasCuenta
{
    public string Idgrupo { get; set; } = null!;

    public string Idcuenta { get; set; } = null!;

    public string DescripcionCuenta { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public string? Formula { get; set; }

    public bool ActualizarPrecio { get; set; }

    public string? Referencia { get; set; }

    public string? FormulaInterna { get; set; }

    public virtual TbObrasGrupo IdgrupoNavigation { get; set; } = null!;

    public virtual ICollection<TbObrasDetalleObservacione> TbObrasDetalleObservaciones { get; } = new List<TbObrasDetalleObservacione>();

    public virtual ICollection<TbObrasDetalle> TbObrasDetalles { get; } = new List<TbObrasDetalle>();

    public virtual ICollection<TbObrasPreciosCoste> TbObrasPreciosCostes { get; } = new List<TbObrasPreciosCoste>();

    public virtual ICollection<TbOperario> TbOperarios { get; } = new List<TbOperario>();

    public virtual ICollection<TbVehiculo> TbVehiculos { get; } = new List<TbVehiculo>();
}
