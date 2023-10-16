using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPropuestum
{
    public string IdPropuesta { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Idarticulo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? Idproveedor { get; set; }

    public string? IdDetallePedido { get; set; }

    public string? Proveedor { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public decimal Preciocompra { get; set; }

    public decimal Cantidad { get; set; }

    public string? Idalmacen { get; set; }

    public string? Idpiezataller { get; set; }

    public virtual TbDetallePedido? IdDetallePedidoNavigation { get; set; }

    public virtual TbAlmacene? IdalmacenNavigation { get; set; }

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbEntradasTallerPieza? IdpiezatallerNavigation { get; set; }

    public virtual TbCliente? IdproveedorNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;
}
