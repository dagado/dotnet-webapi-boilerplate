using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class VwMaquinasCliente
{
    public string Idmaquina { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public string? NumeroSerie { get; set; }

    public string? Referencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public string IdModelo { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Descatalogada { get; set; }

    public DateTime? FechaCompra { get; set; }

    public byte[]? Foto { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public string Modelo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string TipoMaquina { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public DateTime? Ultimaentrada { get; set; }

    public string? Maquinauso { get; set; }
}
