using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCaja
{
    public string Idcaja { get; set; } = null!;

    public int NumeroCaja { get; set; }

    public string SerieCaja { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public decimal? SaldoFinal { get; set; }

    public DateTime FechaCierre { get; set; }

    public string? Observaciones { get; set; }

    public string Iddiseño { get; set; } = null!;

    public decimal Descuadre { get; set; }

    public string Idbanco { get; set; } = null!;

    public decimal Cambio { get; set; }

    public virtual TbBanco IdbancoNavigation { get; set; } = null!;

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
