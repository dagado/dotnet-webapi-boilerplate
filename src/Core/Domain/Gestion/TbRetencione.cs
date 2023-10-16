using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbRetencione
{
    public string CodigoRetencion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Retencion { get; set; }

    public string? TipoDatisa { get; set; }

    public string? Clase { get; set; }

    public string? TextoContabilidad { get; set; }

    public bool GarantiaObra { get; set; }

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbFacturaImpuesto> TbFacturaImpuestos { get; } = new List<TbFacturaImpuesto>();

    public virtual ICollection<TbRetencionesCuentasContable> TbRetencionesCuentasContables { get; } = new List<TbRetencionesCuentasContable>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
