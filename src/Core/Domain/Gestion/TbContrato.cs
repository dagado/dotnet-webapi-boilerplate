using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbContrato
{
    public string Idcliente { get; set; } = null!;

    public string Idcontrato { get; set; } = null!;

    public DateTime Fechainicio { get; set; }

    public DateTime? Fechafin { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Refcontrato { get; set; }

    public string? Observaciones { get; set; }

    public string Periodicidad { get; set; } = null!;

    public string? Personafisica { get; set; }

    public string? Dnipersonafisica { get; set; }

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public DateTime? Fechafirma { get; set; }

    public byte[]? Documento { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public DateTime? Fechaenviooutlook { get; set; }

    public string? IdGm { get; set; }

    public string? MgdomicilioRecogida { get; set; }

    public string? MgdomicilioEntrega { get; set; }

    public string? MgespecificacionesEmbalaje { get; set; }

    public string? MginstalacionElectrodomesticos { get; set; }

    public string? MgmediosTecnicos { get; set; }

    public virtual MgguardaMueble? IdGmNavigation { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleContrato> TbDetalleContratos { get; } = new List<TbDetalleContrato>();
}
