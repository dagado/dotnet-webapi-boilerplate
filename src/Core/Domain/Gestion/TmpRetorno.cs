using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TmpRetorno
{
    public string Id { get; set; } = null!;

    public string? IdArticulo { get; set; }

    public decimal Cantidad { get; set; }

    public string IdAviso { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual TbArticulo? IdArticuloNavigation { get; set; }

    public virtual TbAviso IdAvisoNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;
}
