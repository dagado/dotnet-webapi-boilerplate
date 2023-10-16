using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbParametrosFirma
{
    public string IdEmpresa { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public byte[]? ImagenFirma { get; set; }

    public int Llx { get; set; }

    public int Lly { get; set; }

    public int Urx { get; set; }

    public int Ury { get; set; }

    public int Rotacion { get; set; }

    public int? XimagenFirma { get; set; }

    public int? YimagenFirma { get; set; }

    public int? Escala { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;
}
