using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbRepositorio
{
    public string Id { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Repositorio { get; set; } = null!;

    public string Formato { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;
}
