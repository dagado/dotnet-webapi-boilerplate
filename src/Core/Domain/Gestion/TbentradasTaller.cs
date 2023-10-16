using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbentradasTaller
{
    public string IdEntrada { get; set; } = null!;

    public int NumeroEntrada { get; set; }

    public string SerieEntrada { get; set; } = null!;

    public DateTime FechaEntrada { get; set; }

    public string Idmaquina { get; set; } = null!;

    public string Averia { get; set; } = null!;

    public string IdEstadoEntrada { get; set; } = null!;

    public decimal Importe { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string? Idpresupuesto { get; set; }

    public string? IdAlbaran { get; set; }

    public string? IdFactura { get; set; }

    public string Idusuario { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? ConceptoDocumento { get; set; }

    public string? IdArticulo { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public string? Maquinauso { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public string Iddiseño { get; set; } = null!;

    public DateTime? Fechafin { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbcabeceraAlbaran? IdAlbaranNavigation { get; set; }

    public virtual TbArticulo? IdArticuloNavigation { get; set; }

    public virtual TbDatosEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbEntradasTallerEstado IdEstadoEntradaNavigation { get; set; } = null!;

    public virtual TbcabeceraFactura? IdFacturaNavigation { get; set; }

    public virtual TbSeriesDiseñoDocumento IddiseñoNavigation { get; set; } = null!;

    public virtual TbMaquinasCliente IdmaquinaNavigation { get; set; } = null!;

    public virtual TbCabeceraPresupuesto? IdpresupuestoNavigation { get; set; }

    public virtual TbUsuario IdusuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbEntradasTallerPieza> TbEntradasTallerPiezas { get; } = new List<TbEntradasTallerPieza>();

    public virtual ICollection<TbEntradasTallerSeguimiento> TbEntradasTallerSeguimientos { get; } = new List<TbEntradasTallerSeguimiento>();
}
