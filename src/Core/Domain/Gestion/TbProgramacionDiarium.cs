using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbProgramacionDiarium
{
    public string IdDiario { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Observaciones { get; set; }

    public string Idusuario { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public DateTime? Publicacion { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalles { get; } = new List<TbProgramacionDiariaDetalle>();
}
