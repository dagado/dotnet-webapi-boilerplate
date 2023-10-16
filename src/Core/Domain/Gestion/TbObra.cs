using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObra
{
    public string Id { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Codigoprovincia { get; set; }

    public string? Contacto { get; set; }

    public string? Tfno { get; set; }

    public string? Idempresa { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? Fechafinalizacion { get; set; }

    public DateTime? Fechainicio { get; set; }

    public string? IdTarifa { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? Referencia { get; set; }

    public decimal? TotalCostes { get; set; }

    public string? Maquinauso { get; set; }

    public string? Idoperario { get; set; }

    public string? Idtipoobra { get; set; }

    public virtual TbProvincia? CodigoprovinciaNavigation { get; set; }

    public virtual TbCabeceraTarifa? IdTarifaNavigation { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa? IdempresaNavigation { get; set; }

    public virtual TbOperario? IdoperarioNavigation { get; set; }

    public virtual TbTiposObra? IdtipoobraNavigation { get; set; }

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbDetalleParteOperario> TbDetalleParteOperarios { get; } = new List<TbDetalleParteOperario>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbObrasDetalleObservacione> TbObrasDetalleObservaciones { get; } = new List<TbObrasDetalleObservacione>();

    public virtual ICollection<TbObrasDetalle> TbObrasDetalles { get; } = new List<TbObrasDetalle>();

    public virtual ICollection<TbObrasDocumento> TbObrasDocumentos { get; } = new List<TbObrasDocumento>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalleIdObra1Navigations { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalleIdObra2Navigations { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalleIdObra3Navigations { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalleIdObra4Navigations { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalleIdObra5Navigations { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();
}
