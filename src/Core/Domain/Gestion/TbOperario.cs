using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOperario
{
    public string IdOperario { get; set; } = null!;

    public string IdEmpresa { get; set; } = null!;

    public short ColorCalendario { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Password { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Movil { get; set; }

    public string? TarjetaSanitaria { get; set; }

    public string? HorarioMañana { get; set; }

    public string? HorarioTarde { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Contrato { get; set; }

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public string? Dni { get; set; }

    public string? HorarioSabados { get; set; }

    public decimal Preciohora { get; set; }

    public string? Idarticulo { get; set; }

    public string? IdDispositivo { get; set; }

    public string? Usuario { get; set; }

    public decimal Preciocoste { get; set; }

    public string? EnlaceIdcuentaObras { get; set; }

    public DateTime? FechaUltimoReconocimiento { get; set; }

    public virtual TbObrasCuenta? EnlaceIdcuentaObrasNavigation { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbProvincia? ProvinciaNavigation { get; set; }

    public virtual ICollection<TbAvisosOperario> TbAvisosOperarios { get; } = new List<TbAvisosOperario>();

    public virtual ICollection<TbDetalle> TbDetalles { get; } = new List<TbDetalle>();

    public virtual ICollection<TbObra> TbObras { get; } = new List<TbObra>();

    public virtual ICollection<TbOperariosCliente> TbOperariosClientes { get; } = new List<TbOperariosCliente>();

    public virtual ICollection<TbOperariosDocumento> TbOperariosDocumentos { get; } = new List<TbOperariosDocumento>();

    public virtual ICollection<TbOperariosRutasDocumento> TbOperariosRutasDocumentos { get; } = new List<TbOperariosRutasDocumento>();

    public virtual ICollection<TbOperariosVacacione> TbOperariosVacaciones { get; } = new List<TbOperariosVacacione>();

    public virtual ICollection<TbParteOperario> TbParteOperarios { get; } = new List<TbParteOperario>();

    public virtual ICollection<TbPosicionamientoOperario> TbPosicionamientoOperarios { get; } = new List<TbPosicionamientoOperario>();

    public virtual ICollection<TbProgramacionDiariaDetalle> TbProgramacionDiariaDetalles { get; } = new List<TbProgramacionDiariaDetalle>();

    public virtual ICollection<TbResponsable> TbResponsables { get; } = new List<TbResponsable>();

    public virtual ICollection<TmpTbAvisosOperario> TmpTbAvisosOperarios { get; } = new List<TmpTbAvisosOperario>();
}
