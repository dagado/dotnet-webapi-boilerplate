using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TrCabeceraFactura
{
    public string Idregistro { get; set; } = null!;

    public DateTime Fechahoraregistro { get; set; }

    public string Maquina { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string Idfactura { get; set; } = null!;

    public int Numerofactura { get; set; }

    public string Seriefactura { get; set; } = null!;

    public DateTime FechaFactura { get; set; }

    public string Idcliente { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Nombrefiscal { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Localidad { get; set; }

    public string? Codigoprovincia { get; set; }

    public string? Observaciones { get; set; }

    public string? Codigopostal { get; set; }

    public string? CodigoRetencion { get; set; }

    public decimal? Retencion { get; set; }

    public string Tipofactura { get; set; } = null!;

    public string? Sufactura { get; set; }

    public DateTime? Sufecha { get; set; }

    public byte[]? Documentorecibido { get; set; }

    public string? Nombredocumento { get; set; }

    public string Iddiseño { get; set; } = null!;

    public decimal Baseimponible { get; set; }

    public decimal Baseimponiblecompra { get; set; }

    public decimal Totaliva { get; set; }

    public decimal Totalretencion { get; set; }

    public decimal Totalfactura { get; set; }

    public decimal Bruto { get; set; }

    public string? Cuentacontable { get; set; }

    public DateTime? FechaContabilizado { get; set; }

    public decimal? Abonado { get; set; }

    public bool Mantenerdetalleiva { get; set; }

    public string? CentroTrabajo { get; set; }

    public bool Bienesinversion { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public decimal TotalRecargo { get; set; }

    public DateTime? UltimaFechaPago { get; set; }

    public string Idformapago { get; set; } = null!;

    public string? IdObra { get; set; }

    public string? IdDelegacion { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public string? Maquinauso { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public bool Modulocalculoiva { get; set; }

    public string? Iddocumento { get; set; }

    public string? IdFacturaRectificada { get; set; }

    public string? Idclasificacion { get; set; }

    public string? ObservacionesInternas { get; set; }

    public string? Textolibre { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;
}
