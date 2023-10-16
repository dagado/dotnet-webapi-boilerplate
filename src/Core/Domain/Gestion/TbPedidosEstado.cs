using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbPedidosEstado
{
    public string CodigoEstado { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public int? Definicioncolor { get; set; }

    public string Tipo { get; set; } = null!;

    public bool Cerrado { get; set; }

    public bool EstadoInicial { get; set; }

    public bool StockInsuficiente { get; set; }

    public bool Stocksuficiente { get; set; }

    public bool Servido { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();
}
