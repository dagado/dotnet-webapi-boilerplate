using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDiseñosSubInforme
{
    public string Id { get; set; } = null!;

    public string IdDiseño { get; set; } = null!;

    public string PlantillaSubInforme { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public virtual TbSeriesDiseñoDocumento IdDiseñoNavigation { get; set; } = null!;

    public virtual TbTiposDocumentoInterno IdNavigation { get; set; } = null!;
}
