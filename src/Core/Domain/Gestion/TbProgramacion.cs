using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbProgramacion
{
    public string IdProgramacion { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime FechaHora { get; set; }

    public string CodigoClasificacion { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public DateTime Fechafin { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual TbProgramacionClasificacion TbProgramacionClasificacion { get; set; } = null!;
}
