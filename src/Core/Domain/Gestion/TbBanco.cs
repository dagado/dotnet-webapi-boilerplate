using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbBanco
{
    public string IdBanco { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Predeterminado { get; set; }

    public bool Metalico { get; set; }

    public string? Cuentacontable { get; set; }

    public string? Iban { get; set; }

    public string? Idacreedorsepa { get; set; }

    public bool Descatalogado { get; set; }

    public string? Bic { get; set; }

    public string? Sufijo { get; set; }

    public string? Puntoventa { get; set; }

    public string Idempresa { get; set; } = null!;

    public DateTime? FechaExportado { get; set; }

    public DateTime Fecharegistro { get; set; }

    public DateTime? ConciliadoHasta { get; set; }

    public bool Instrumentolocal { get; set; }

    public string? TextoContabilidadCobro { get; set; }

    public string? TextoContabilidadPago { get; set; }

    public string? IdacreedorSepaB2b { get; set; }

    public string? IdacreedorSepaTransferencias { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbBancosTpv> TbBancosTpvs { get; } = new List<TbBancosTpv>();

    public virtual ICollection<TbCabeceraRemesa> TbCabeceraRemesas { get; } = new List<TbCabeceraRemesa>();

    public virtual ICollection<TbCaja> TbCajas { get; } = new List<TbCaja>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual TbPuntosVentum? TbPuntosVentum { get; set; }

    public virtual ICollection<Tbcartera> Tbcarteras { get; } = new List<Tbcartera>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
