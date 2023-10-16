using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Tbcartera
{
    public string Idcartera { get; set; } = null!;

    public string Idfactura { get; set; } = null!;

    public DateTime Fechavencimiento { get; set; }

    public decimal Importevencimiento { get; set; }

    public decimal? Abonado { get; set; }

    public string? IdbancoCargo { get; set; }

    public string? Observaciones { get; set; }

    public bool Remesar { get; set; }

    public string? Idcuentabancaria { get; set; }

    public decimal Importearemesar { get; set; }

    public string? Idestado { get; set; }

    public DateTime? FechaReclamacion { get; set; }

    public virtual TbBanco? IdbancoCargoNavigation { get; set; }

    public virtual TbClientesCuentasBancaria? IdcuentabancariaNavigation { get; set; }

    public virtual TbEstadosCartera? IdestadoNavigation { get; set; }

    public virtual TbcabeceraFactura IdfacturaNavigation { get; set; } = null!;

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
