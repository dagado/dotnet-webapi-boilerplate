using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbBic
{
    public string CodigoBanco { get; set; } = null!;

    public string Bic { get; set; } = null!;
}
