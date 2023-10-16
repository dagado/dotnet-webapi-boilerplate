using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbTiposDocumentoInterno
{
    public string Id { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Plantilla { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Clasificacion { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbDiseñosSubInforme> TbDiseñosSubInformes { get; } = new List<TbDiseñosSubInforme>();
}
