using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbtiposDocumento
{
    public string IdTipoDocumento { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Plantilla { get; set; }

    public string? Sql { get; set; }

    public string? Grupoinforme { get; set; }

    public bool Vistaprevia { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Tratamiento { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<Tblayoutspivot> Tblayoutspivots { get; } = new List<Tblayoutspivot>();
}
