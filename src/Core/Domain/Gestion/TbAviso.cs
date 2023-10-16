using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAviso
{
    public string IdAviso { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public int NumeroAviso { get; set; }

    public string SerieAviso { get; set; } = null!;

    public DateTime FechaAviso { get; set; }

    public string IdCliente { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string CodigoEstado { get; set; } = null!;

    public string? Incidencia { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Iddiseño { get; set; } = null!;

    public string? Iddireccion { get; set; }

    public string? IdDelegacion { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public string Idusuario { get; set; } = null!;

    public string? IdObra { get; set; }

    public string? MaquinaUso { get; set; }

    public string? CentroTrabajo { get; set; }

    public string? Direccion { get; set; }

    public string? Localidad { get; set; }

    public string? CodigoProvincia { get; set; }

    public decimal ImporteAviso { get; set; }

    public bool Modocalculoiva { get; set; }

    public decimal ImporteCompraAviso { get; set; }

    public string? Rutadocumentos { get; set; }

    public bool Facturar { get; set; }

    public string? Referencia { get; set; }

    public string? Factura { get; set; }

    public short? Certificacion { get; set; }

    public bool Garantia { get; set; }

    public string? ObservacionesInternas { get; set; }

    public decimal PorcentajeMosobreMat { get; set; }

    public virtual TbProvincia? CodigoProvinciaNavigation { get; set; }

    public virtual TbCliente IdClienteNavigation { get; set; } = null!;

    public virtual TbClientesDelegacione? IdDelegacionNavigation { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbObra? IdObraNavigation { get; set; }

    public virtual TbClientesDireccione? IddireccionNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbAvisosOperario> TbAvisosOperarios { get; } = new List<TbAvisosOperario>();

    public virtual TbCabeceraPresupuesto? TbCabeceraPresupuesto { get; set; }

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TmpRetorno> TmpRetornos { get; } = new List<TmpRetorno>();

    public virtual ICollection<TmpTbAvisosOperario> TmpTbAvisosOperarios { get; } = new List<TmpTbAvisosOperario>();
}
