using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPotenciale
{
    public string IdPotencial { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Nombrecomercial { get; set; }

    public string? Direccion { get; set; }

    public string? Codigopostal { get; set; }

    public string? Localidad { get; set; }

    public string? Codigoprovincia { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Fax { get; set; }

    public string? Observaciones { get; set; }

    public string? Email { get; set; }

    public string? Dni { get; set; }

    public string? Web { get; set; }

    public DateTime Fecharregistro { get; set; }

    public string Idusuario { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? Contacto { get; set; }

    public string Pais { get; set; } = null!;

    public string? Origen { get; set; }

    public string? IdGrupoPotencial { get; set; }

    public string? IdAccion { get; set; }

    public string? Idclasificacion { get; set; }

    public virtual TbPotencialesEstado? IdAccionNavigation { get; set; }

    public virtual TbPotencialesGrupo? IdGrupoPotencialNavigation { get; set; }

    public virtual TbClasificacion? IdclasificacionNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbPotencialesSeguimiento> TbPotencialesSeguimientos { get; } = new List<TbPotencialesSeguimiento>();
}
