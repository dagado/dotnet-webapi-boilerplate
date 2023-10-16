using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbParteOperario
{
    public string IdParte { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public DateTime FechaParte { get; set; }

    public string? Observaciones { get; set; }

    public byte[]? DocumentoRecibido { get; set; }

    public string? NombreDocumento { get; set; }

    public decimal Importe { get; set; }

    public string? Descripcion { get; set; }

    public string? Maquinauso { get; set; }

    public string Idnumero { get; set; } = null!;

    public decimal Importecoste { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleParteOperario> TbDetalleParteOperarios { get; } = new List<TbDetalleParteOperario>();
}
