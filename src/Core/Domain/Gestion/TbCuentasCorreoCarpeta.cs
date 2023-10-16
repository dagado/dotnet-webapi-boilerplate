using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCuentasCorreoCarpeta
{
    public string Id { get; set; } = null!;

    public string Idcuenta { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Maquina { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public virtual TbCuentasCorreo IdcuentaNavigation { get; set; } = null!;
}
