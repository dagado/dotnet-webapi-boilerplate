using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbcabeceraAlbaran
{
    public string Idalbaran { get; set; } = null!;

    public int Numeroalbaran { get; set; }

    public string Seriealbaran { get; set; } = null!;

    public DateTime FechaAlbaran { get; set; }

    public DateTime Fecharegistro { get; set; }

    public string Idusuario { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Sualbaran { get; set; }

    public DateTime? Sufecha { get; set; }

    public string? Idobra { get; set; }

    public bool Facturado { get; set; }

    public string? Iddireccion { get; set; }

    public string Iddiseño { get; set; } = null!;

    public byte[]? Documentorecibido { get; set; }

    public string? Nombredocumento { get; set; }

    public string? Iddelegacion { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalbase { get; set; }

    public decimal Totalimpuestos { get; set; }

    public decimal Totalalbaran { get; set; }

    public bool Modocalculoiva { get; set; }

    public decimal Totalcompra { get; set; }

    public bool Mantenerdetalleiva { get; set; }

    public string? Puntoventa { get; set; }

    public string? Iddocumento { get; set; }

    public string? DocumentoFactura { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public string? ObservacionesInternas { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbClientesDelegacione? IddelegacionNavigation { get; set; }

    public virtual TbClientesDireccione? IddireccionNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbCabeceraPresupuesto? IddocumentoNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbObra? IdobraNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbAlbaranCertificacion> TbAlbaranCertificacions { get; } = new List<TbAlbaranCertificacion>();

    public virtual ICollection<TbAlbaranImpuesto> TbAlbaranImpuestos { get; } = new List<TbAlbaranImpuesto>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
