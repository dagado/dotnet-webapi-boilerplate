using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Tblog
{
    public string Id { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public DateTime FechaHora { get; set; }

    public string Accion { get; set; } = null!;

    public string Maquina { get; set; } = null!;

    public string? IdExterno { get; set; }

    public string? Tabla { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;
}
