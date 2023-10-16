using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Tblayoutspivot
{
    public string Idlayout { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Strlayout { get; set; }

    public string? Tipoplantilla { get; set; }

    public bool? Predeterminada { get; set; }

    public string? Textototalgeneral { get; set; }

    public string IdDocumento { get; set; } = null!;

    public virtual TbtiposDocumento IdDocumentoNavigation { get; set; } = null!;
}
