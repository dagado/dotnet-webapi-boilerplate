using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlerta
{
    public string Id { get; set; } = null!;

    public DateTime FehaAlarma { get; set; }

    public string IdusuarioOrigen { get; set; } = null!;

    public string IdStatus { get; set; } = null!;

    public string? Documento { get; set; }

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public bool Tramitada { get; set; }

    public DateTime Fecharegistro { get; set; }

    public virtual TbAlertasStatus IdStatusNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioOrigenNavigation { get; set; } = null!;

    public virtual ICollection<TbAlertasDestinatario> TbAlertasDestinatarios { get; } = new List<TbAlertasDestinatario>();
}
