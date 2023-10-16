using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwFactura
{
    public string Iddiseño { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime FechaFactura { get; set; }

    public int Numerofactura { get; set; }

    public string Seriefactura { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string Usuario { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public string Nombrefiscal { get; set; } = null!;

    public string? Cuentacontable { get; set; }

    public string? NombreComercial { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public string Dni { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Tipofactura { get; set; } = null!;

    public string? Sufactura { get; set; }

    public DateTime? Sufecha { get; set; }

    public string? Obra { get; set; }

    public string? Nombredocumento { get; set; }

    public string? Delegacion { get; set; }

    public decimal Bruto { get; set; }

    public decimal Baseimponible { get; set; }

    public decimal Totaliva { get; set; }

    public decimal Totalretencion { get; set; }

    public decimal Totalfactura { get; set; }

    public decimal Baseimponiblecompra { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public string Idfactura { get; set; } = null!;

    public string? Ruta { get; set; }

    public string? CentroTrabajo { get; set; }

    public string Idcliente { get; set; } = null!;

    public decimal? Beneficio { get; set; }

    public int Codigo { get; set; }

    public decimal? Entregas { get; set; }

    public string? Presupuesto { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public string? Codigopostal { get; set; }

    public decimal? Retencion { get; set; }

    public string? Contracuenta { get; set; }

    public DateTime? FechaContabilizado { get; set; }

    public decimal? Abonado { get; set; }

    public bool Bienesinversion { get; set; }

    public decimal TotalRecargo { get; set; }

    public DateTime? UltimaFechaPago { get; set; }

    public string Formapago { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public decimal? Pendiente { get; set; }

    public string? Rectificada { get; set; }

    public string Tipocliente { get; set; } = null!;

    public string Soporte { get; set; } = null!;

    public int? Ejercicio { get; set; }

    public int? Mes { get; set; }

    public int? Trimestre { get; set; }

    public string? Administrador { get; set; }

    public string? Idadministrador { get; set; }

    public string? Clasificacion { get; set; }

    public string? ObservacionesInternas { get; set; }

    public string? Textolibre { get; set; }

    public string Documento { get; set; } = null!;
}
