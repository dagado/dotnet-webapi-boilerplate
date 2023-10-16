using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwListaObra
{
    public string Idobra { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Contacto { get; set; }

    public string? Tfno { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? Fechafinalizacion { get; set; }

    public DateTime? Fechainicio { get; set; }

    public string? Referencia { get; set; }

    public decimal? TotalCostes { get; set; }

    public string? Provincia { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string Dni { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public string? Idempresa { get; set; }

    public decimal? Presupuestado { get; set; }

    public decimal? Facturado { get; set; }

    public string? Maquinauso { get; set; }

    public string Idcliente { get; set; } = null!;

    public decimal? Albaranesventa { get; set; }

    public string? Idtipoobra { get; set; }

    public string? Tipoobra { get; set; }

    public string? Tecnico { get; set; }
}
