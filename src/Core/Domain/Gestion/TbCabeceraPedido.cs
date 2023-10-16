using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraPedido
{
    public string Idpedido { get; set; } = null!;

    public int Numeropedido { get; set; }

    public string Seriepedido { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public DateTime Fecharegistro { get; set; }

    public string Idusuario { get; set; } = null!;

    public string? Maquinauso { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Supedido { get; set; }

    public string? Idobra { get; set; }

    public string? Iddireccion { get; set; }

    public string Iddiseño { get; set; } = null!;

    public string Codigoestado { get; set; } = null!;

    public string? Iddelegacion { get; set; }

    public DateTime? Fechaimpresion { get; set; }

    public DateTime? Fechaenvioemail { get; set; }

    public DateTime? FechaPrevistaEntrega { get; set; }

    public decimal Totalbruto { get; set; }

    public decimal Totalbase { get; set; }

    public decimal Totalimpuestos { get; set; }

    public decimal Totalpedido { get; set; }

    public bool Modocalculoiva { get; set; }

    public decimal Totalcompra { get; set; }

    public bool Mantenerdetalleiva { get; set; }

    public string? Puntoventa { get; set; }

    public string? Iddocumento { get; set; }

    public string? DatosDescarga { get; set; }

    public byte[]? Documentorecibido { get; set; }

    public string? Nombredocumento { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbClientesDelegacione? IddelegacionNavigation { get; set; }

    public virtual TbClientesDireccione? IddireccionNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbCabeceraPresupuesto? IddocumentoNavigation { get; set; }

    public virtual TbObra? IdobraNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbDetallePedido> TbDetallePedidos { get; } = new List<TbDetallePedido>();

    public virtual ICollection<TbPedidoImpuesto> TbPedidoImpuestos { get; } = new List<TbPedidoImpuesto>();

    public virtual TbPedidosEstado TbPedidosEstado { get; set; } = null!;

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
