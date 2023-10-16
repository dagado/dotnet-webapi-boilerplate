using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbModelo
{
    public string IdModelo { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string IdMarca { get; set; } = null!;

    public string? Observaciones { get; set; }

    public byte[]? Catalogo { get; set; }

    public string? Nombredocumento { get; set; }

    public bool Descatalogado { get; set; }

    public string Idtipomaquina { get; set; } = null!;

    public string? Referencia { get; set; }

    public virtual TbMarca IdMarcaNavigation { get; set; } = null!;

    public virtual TbTiposMaquina IdtipomaquinaNavigation { get; set; } = null!;

    public virtual ICollection<TbMaquinasCliente> TbMaquinasClientes { get; } = new List<TbMaquinasCliente>();

    public virtual ICollection<TbModelosCaracteristica> TbModelosCaracteristicas { get; } = new List<TbModelosCaracteristica>();
}
