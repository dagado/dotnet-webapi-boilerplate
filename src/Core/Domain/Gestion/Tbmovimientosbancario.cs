using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class Tbmovimientosbancario
{
    public DateTime Fechapago { get; set; }

    public string Idbanco { get; set; } = null!;

    public string Idmodopago { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal Importe { get; set; }

    public bool Punteado { get; set; }

    public string? Idmovimientoasociado { get; set; }

    public string? Cuentacontable { get; set; }

    public DateTime? FechaContabilizado { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public string Idusuario { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string? Idcartera { get; set; }

    public string? Idpedido { get; set; }

    public string? Idalbaran { get; set; }

    public string? Iddocumento { get; set; }

    public string? Idcliente { get; set; }

    public int? NumeroRemesa { get; set; }

    public bool Devuelto { get; set; }

    public bool Oculta { get; set; }

    public string? ReferenciaMantado { get; set; }

    public bool PagoPeriodico { get; set; }

    public string? Idcuentabancaria { get; set; }

    public string? Idgrupo { get; set; }

    public short Orden { get; set; }

    public string Id { get; set; } = null!;

    public string? IdCaja { get; set; }

    public string Tipo { get; set; } = null!;

    public string? IdAsociacionEntregaAcuenta { get; set; }

    public int Idautonumerico { get; set; }

    public virtual TbCaja? IdCajaNavigation { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbcabeceraAlbaran? IdalbaranNavigation { get; set; }

    public virtual TbBanco IdbancoNavigation { get; set; } = null!;

    public virtual Tbcartera? IdcarteraNavigation { get; set; }

    public virtual TbCliente? IdclienteNavigation { get; set; }

    public virtual TbClientesCuentasBancaria? IdcuentabancariaNavigation { get; set; }

    public virtual TbCabeceraPresupuesto? IddocumentoNavigation { get; set; }

    public virtual TbClasificacionesApunte? IdgrupoNavigation { get; set; }

    public virtual TbModosPago IdmodopagoNavigation { get; set; } = null!;

    public virtual TbCabeceraPedido? IdpedidoNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual TbCabeceraRemesa? TbCabeceraRemesa { get; set; }

    public virtual TbMovimientosBancariosDocumento? TbMovimientosBancariosDocumento { get; set; }
}
