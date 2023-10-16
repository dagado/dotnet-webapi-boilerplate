using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbSeriesFactura
{
    public string Seriefactura { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Contador { get; set; }

    public bool Predeterminada { get; set; }

    public bool Inactiva { get; set; }

    public string? Layoutfactura { get; set; }

    public string Tipo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public bool IncluirLibroIva { get; set; }

    public string? Puntoventa { get; set; }

    public string Idempresa { get; set; } = null!;

    public string? Codigoiva { get; set; }

    public string? Seriedatisa { get; set; }

    public string? Contracuenta { get; set; }

    public bool Serierectificativa { get; set; }

    public string? Idalmacen { get; set; }

    public bool ModoIvaIncluido { get; set; }

    public bool Esobra { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Layoutfactura2 { get; set; }

    public bool? AutoGuardarPdf { get; set; }

    public string? CuerpoOutlook { get; set; }

    public string? TextoContabilidad { get; set; }

    public string? Idtarifa { get; set; }

    public bool Tabletafirma { get; set; }

    public virtual TbIva? CodigoivaNavigation { get; set; }

    public virtual TbAlmacene? IdalmacenNavigation { get; set; }

    public virtual TbDatosEmpresa IdempresaNavigation { get; set; } = null!;

    public virtual TbCabeceraTarifa? IdtarifaNavigation { get; set; }

    public virtual TbPuntosVentum? TbPuntosVentum { get; set; }

    public virtual ICollection<TbSeriesDiseñoDocumento> TbSeriesDiseñoDocumentos { get; } = new List<TbSeriesDiseñoDocumento>();

    public virtual ICollection<TmpCabeceraTicket> TmpCabeceraTickets { get; } = new List<TmpCabeceraTicket>();
}
