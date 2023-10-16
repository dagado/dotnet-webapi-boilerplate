using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbUsuario
{
    public string IdUsuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public bool Descatalogado { get; set; }

    public byte[]? Foto { get; set; }

    public string IdPerfil { get; set; } = null!;

    public string? Email { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Puntoventa { get; set; }

    public virtual TbPerfile IdPerfilNavigation { get; set; } = null!;

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<MgpedidoMudanza> MgpedidoMudanzas { get; } = new List<MgpedidoMudanza>();

    public virtual ICollection<TbAlerta> TbAlerta { get; } = new List<TbAlerta>();

    public virtual ICollection<TbAlertasDestinatario> TbAlertasDestinatarios { get; } = new List<TbAlertasDestinatario>();

    public virtual ICollection<TbAviso> TbAvisos { get; } = new List<TbAviso>();

    public virtual ICollection<TbCabeceraFabDe> TbCabeceraFabDes { get; } = new List<TbCabeceraFabDe>();

    public virtual ICollection<TbCabeceraMensaje> TbCabeceraMensajes { get; } = new List<TbCabeceraMensaje>();

    public virtual ICollection<TbCabeceraMovimientoAlmacen> TbCabeceraMovimientoAlmacens { get; } = new List<TbCabeceraMovimientoAlmacen>();

    public virtual ICollection<TbCabeceraPedido> TbCabeceraPedidos { get; } = new List<TbCabeceraPedido>();

    public virtual ICollection<TbCabeceraPresupuesto> TbCabeceraPresupuestos { get; } = new List<TbCabeceraPresupuesto>();

    public virtual ICollection<TbCaja> TbCajas { get; } = new List<TbCaja>();

    public virtual ICollection<TbCliente> TbClientes { get; } = new List<TbCliente>();

    public virtual ICollection<TbContrato> TbContratos { get; } = new List<TbContrato>();

    public virtual ICollection<TbDestinatariosMensaje> TbDestinatariosMensajes { get; } = new List<TbDestinatariosMensaje>();

    public virtual ICollection<TbDetalleParteOperario> TbDetalleParteOperarios { get; } = new List<TbDetalleParteOperario>();

    public virtual ICollection<TbEntradasTallerSeguimiento> TbEntradasTallerSeguimientos { get; } = new List<TbEntradasTallerSeguimiento>();

    public virtual ICollection<TbLayout> TbLayouts { get; } = new List<TbLayout>();

    public virtual ICollection<TbPotenciale> TbPotenciales { get; } = new List<TbPotenciale>();

    public virtual ICollection<TbPotencialesSeguimiento> TbPotencialesSeguimientos { get; } = new List<TbPotencialesSeguimiento>();

    public virtual ICollection<TbProgramacionDiarium> TbProgramacionDiaria { get; } = new List<TbProgramacionDiarium>();

    public virtual ICollection<TbProgramacion> TbProgramacions { get; } = new List<TbProgramacion>();

    public virtual ICollection<TbPropuestum> TbPropuesta { get; } = new List<TbPropuestum>();

    public virtual TbPuntosVentum? TbPuntosVentum { get; set; }

    public virtual ICollection<TbTpvUsuario> TbTpvUsuarios { get; } = new List<TbTpvUsuario>();

    public virtual ICollection<TbalmacenesStock> TbalmacenesStocks { get; } = new List<TbalmacenesStock>();

    public virtual ICollection<TbcabeceraAlbaran> TbcabeceraAlbarans { get; } = new List<TbcabeceraAlbaran>();

    public virtual ICollection<TbcabeceraFactura> TbcabeceraFacturas { get; } = new List<TbcabeceraFactura>();

    public virtual ICollection<TbentradasTaller> TbentradasTallers { get; } = new List<TbentradasTaller>();

    public virtual ICollection<TbhistorialRegularizacion> TbhistorialRegularizacions { get; } = new List<TbhistorialRegularizacion>();

    public virtual ICollection<Tblog> Tblogs { get; } = new List<Tblog>();

    public virtual ICollection<Tbmovimientosbancario> Tbmovimientosbancarios { get; } = new List<Tbmovimientosbancario>();
}
