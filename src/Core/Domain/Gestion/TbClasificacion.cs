using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClasificacion
{
    public string Idclasificacion { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Clasificacion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbPotenciale> TbPotenciales { get; } = new List<TbPotenciale>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
