using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbBancosTpv
{
    public string IdBanco { get; set; } = null!;

    public string IdTpv { get; set; } = null!;

    public string Idmodopago { get; set; } = null!;

    public string? Idgrupo { get; set; }

    public string Seriecaja { get; set; } = null!;

    public string? Cuentadescuadres { get; set; }

    public string? Maquinauso { get; set; }

    public string? IdformaPago { get; set; }

    public virtual TbBanco IdBancoNavigation { get; set; } = null!;

    public virtual TbTpv IdTpvNavigation { get; set; } = null!;

    public virtual TbFormasPago? IdformaPagoNavigation { get; set; }

    public virtual TbModosPago IdmodopagoNavigation { get; set; } = null!;
}
