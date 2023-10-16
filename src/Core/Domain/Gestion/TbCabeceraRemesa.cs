using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraRemesa
{
    public int NumRemesa { get; set; }

    public string Idbanco { get; set; } = null!;

    public string? Cuaderno { get; set; }

    public DateTime? Fechaconfeccion { get; set; }

    public DateTime? Fechacargo { get; set; }

    public string? Tipo { get; set; }

    public string? Tipo34 { get; set; }

    public bool AnticipoAcuenta { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbBanco IdbancoNavigation { get; set; } = null!;

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
