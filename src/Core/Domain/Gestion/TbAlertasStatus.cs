using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlertasStatus
{
    public string IdStatus { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Color { get; set; }

    public bool Predeterminado { get; set; }

    public virtual ICollection<TbAlerta> TbAlerta { get; } = new List<TbAlerta>();
}
