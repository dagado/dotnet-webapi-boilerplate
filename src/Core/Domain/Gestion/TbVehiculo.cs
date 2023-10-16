using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbVehiculo
{
    public string IdVehiculo { get; set; } = null!;

    public string Matricula { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public bool Descatalogado { get; set; }

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Color { get; set; }

    public byte[]? Foto { get; set; }

    public decimal? Preciocompra { get; set; }

    public DateTime? FechaCompra { get; set; }

    public DateTime? Fechaitv { get; set; }

    public string? Compañia { get; set; }

    public string? Numeropoliza { get; set; }

    public DateTime? Fechavencimientoseguro { get; set; }

    public decimal? Precioseguro { get; set; }

    public string? Bastidor { get; set; }

    public DateTime? FechaPrimeraMatriculacion { get; set; }

    public string? Lugartrabajo { get; set; }

    public decimal? PorAmortizacion { get; set; }

    public decimal? ImporteFijoAmortizacion { get; set; }

    public decimal? ImporteMinimoAmortizacion { get; set; }

    public decimal? ImporteAmortizado { get; set; }

    public DateTime? FechaAmortizacion { get; set; }

    public string Tipo { get; set; } = null!;

    public int Kilometrosiniciales { get; set; }

    public decimal? Preciohora { get; set; }

    public string? EnlaceIdcuentaObras { get; set; }

    public virtual TbObrasCuenta? EnlaceIdcuentaObrasNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleParteOperario> TbDetalleParteOperarios { get; } = new List<TbDetalleParteOperario>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbLineasCoste> TbLineasCostes { get; } = new List<TbLineasCoste>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalles { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbVehiculosAmortizacione> TbVehiculosAmortizaciones { get; } = new List<TbVehiculosAmortizacione>();

    public virtual ICollection<TbVehiculosDocumento> TbVehiculosDocumentos { get; } = new List<TbVehiculosDocumento>();

    public virtual ICollection<TbVehiculosParte> TbVehiculosPartes { get; } = new List<TbVehiculosParte>();
}
