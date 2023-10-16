using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpDetalleTicket
{
    public string IdRegistro { get; set; } = null!;

    public string? Codigobarras { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Dto { get; set; }

    public decimal Importeii { get; set; }

    public short Orden { get; set; }

    public decimal Precioii { get; set; }

    public string? Lote { get; set; }

    public string CodigoIva { get; set; } = null!;

    public string? Idarticulo { get; set; }

    public string Idcabeceraticket { get; set; } = null!;

    public string? Idalmacen { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbAlmacene? IdalmacenNavigation { get; set; }

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TmpCabeceraTicket IdcabeceraticketNavigation { get; set; } = null!;
}
