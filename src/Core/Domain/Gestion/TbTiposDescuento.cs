using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposDescuento
{
    public string Iddescuento { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbClientesTarifaDto> TbClientesTarifaDtos { get; } = new List<TbClientesTarifaDto>();

    public virtual ICollection<TbDetalleDtoFactura> TbDetalleDtoFacturas { get; } = new List<TbDetalleDtoFactura>();
}
