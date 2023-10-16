using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbMarca
{
    public string Idmarca { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public byte[]? Logo { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbArticulo> TbArticulos { get; } = new List<TbArticulo>();

    public virtual ICollection<TbModelo> TbModelos { get; } = new List<TbModelo>();
}
