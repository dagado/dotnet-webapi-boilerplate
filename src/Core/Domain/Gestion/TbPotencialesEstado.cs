using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPotencialesEstado
{
    public string IdAccion { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public int? Definicioncolor { get; set; }

    public string Idempresa { get; set; } = null!;

    public short? Colorcalendario { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbPotenciale> TbPotenciales { get; } = new List<TbPotenciale>();

    public virtual ICollection<TbPotencialesSeguimiento> TbPotencialesSeguimientos { get; } = new List<TbPotencialesSeguimiento>();
}
