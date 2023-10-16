using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraFabDe
{
    public string Id { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Observaciones { get; set; }

    public string Idarticulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Idalmacen { get; set; } = null!;

    public decimal UdsFabDes { get; set; }

    public decimal CosteFabDes { get; set; }

    public string? Lote { get; set; }

    public string? NumeroSerie { get; set; }

    public string? Maquinauso { get; set; }

    public decimal? Unidades { get; set; }

    public decimal Merma { get; set; }

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public DateTime? Fechacaducidad { get; set; }

    public DateTime? FechaFinFabricacion { get; set; }

    public decimal? Unidadesmerma { get; set; }

    public string Idnumero { get; set; } = null!;

    public virtual TbAlmacene IdalmacenNavigation { get; set; } = null!;

    public virtual TbArticulo IdarticuloNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleFabDe> TbDetalleFabDes { get; } = new List<TbDetalleFabDe>();

    public virtual ICollection<TbFabricacionSalida> TbFabricacionSalida { get; } = new List<TbFabricacionSalida>();
}
