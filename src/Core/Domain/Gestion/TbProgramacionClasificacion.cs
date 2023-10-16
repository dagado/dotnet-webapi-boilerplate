using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbProgramacionClasificacion
{
    public string CodigoClasificacion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public short Color { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public bool Predeterminada { get; set; }

    public int? Colorrejilla { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<TbProgramacion> TbProgramacions { get; } = new List<TbProgramacion>();
}
