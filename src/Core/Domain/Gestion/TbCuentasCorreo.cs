using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCuentasCorreo
{
    public string IdCuenta { get; set; } = null!;

    public string ServidorSmtp { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int Timeout { get; set; }

    public bool Ssl { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Puerto { get; set; }

    public bool Predeterminado { get; set; }

    public byte[]? Firma { get; set; }

    public short? Ancho { get; set; }

    public short? Alto { get; set; }

    public byte[]? Html { get; set; }

    public virtual ICollection<TbCuentasCorreoCarpeta> TbCuentasCorreoCarpeta { get; } = new List<TbCuentasCorreoCarpeta>();

    public virtual ICollection<TbDatosEmpresa> TbDatosEmpresas { get; } = new List<TbDatosEmpresa>();
}
