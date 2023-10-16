using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbalmacenesStock
{
    public string Id { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Idarticulo { get; set; } = null!;

    public string Idalmacen { get; set; } = null!;

    public decimal? Stock { get; set; }

    public decimal? Minimo { get; set; }

    public DateTime Fechainventario { get; set; }

    public string Idusuario { get; set; } = null!;

    public string? Ubicacion { get; set; }

    public virtual TbAlmacene IdalmacenNavigation { get; set; } = null!;

    public virtual TbArticulo IdarticuloNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;
}
