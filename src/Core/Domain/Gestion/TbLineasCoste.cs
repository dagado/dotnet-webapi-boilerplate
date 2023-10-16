using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbLineasCoste
{
    public string IdRegistro { get; set; } = null!;

    public string IdTipoMantenimiento { get; set; } = null!;

    public string IdVehiculo { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string IdReferencia { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public decimal PrecioBase { get; set; }

    public decimal Descuento { get; set; }

    public decimal Importe { get; set; }

    public string? Documento { get; set; }

    public string? IdTaller { get; set; }

    public string? IdResponsable { get; set; }

    public DateTime? FechaProximoMto { get; set; }

    public int? KmsProximoMto { get; set; }

    public string? Observaciones { get; set; }

    public int Kilometros { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Iddetalle { get; set; }

    public virtual TbReferenciasGasto IdReferenciaNavigation { get; set; } = null!;

    public virtual TbResponsable? IdResponsableNavigation { get; set; }

    public virtual TbTallere? IdTallerNavigation { get; set; }

    public virtual TbTiposMantenimiento IdTipoMantenimientoNavigation { get; set; } = null!;

    public virtual TbVehiculo IdVehiculoNavigation { get; set; } = null!;

    public virtual TbDetalle? IddetalleNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbDocumentosCoste> TbDocumentosCostes { get; } = new List<TbDocumentosCoste>();
}
