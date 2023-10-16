using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbMaquinasCliente
{
    public string Idmaquina { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public string? NumeroSerie { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public string IdModelo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public DateTime? FechaCompra { get; set; }

    public byte[]? Foto { get; set; }

    public string? Maquinauso { get; set; }

    public virtual TbCliente IdClienteNavigation { get; set; } = null!;

    public virtual TbModelo IdModeloNavigation { get; set; } = null!;

    public virtual ICollection<TbMaquinasClienteCaracterística> TbMaquinasClienteCaracterísticas { get; } = new List<TbMaquinasClienteCaracterística>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();
}
