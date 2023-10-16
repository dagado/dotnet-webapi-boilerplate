using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraMovimientoAlmacen
{
    public string IdMovimiento { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string IdAlmacenOrigen { get; set; } = null!;

    public string IdAlmacenDestino { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public int Numero { get; set; }

    public virtual TbAlmacene IdAlmacenDestinoNavigation { get; set; } = null!;

    public virtual TbAlmacene IdAlmacenOrigenNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleMovimientoAlmacen> TbDetalleMovimientoAlmacens { get; } = new List<TbDetalleMovimientoAlmacen>();
}
