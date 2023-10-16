using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraTarifa
{
    public string IdTarifa { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool Ivaincluido { get; set; }

    public bool AutoIncluirArticulo { get; set; }

    public bool Tarifageneral { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbClientesDelegacione> TbClientesDelegaciones { get; } = new List<TbClientesDelegacione>();

    public virtual ICollection<TbClientesTarifa> TbClientesTarifas { get; } = new List<TbClientesTarifa>();

    public virtual ICollection<TbDetallePedido> TbDetallePedidos { get; } = new List<TbDetallePedido>();

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();

    public virtual ICollection<TbSeriesFactura> TbSeriesFacturas { get; } = new List<TbSeriesFactura>();

    public virtual ICollection<TbdetalleTarifa> TbdetalleTarifas { get; } = new List<TbdetalleTarifa>();
}
