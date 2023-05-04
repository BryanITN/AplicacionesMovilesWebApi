using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Informacion
{
    public int? IdInfo { get; set; }

    public int NumOrden { get; set; }

    public int? NP { get; set; }

    public string? ListaDePartes { get; set; }

    public string? Procedimiento { get; set; }

    public string? Especificaciones { get; set; }

    public decimal NumRango { get; set; }

    public int NumVariacion { get; set; }

    public virtual Cliente NumOrdenNavigation { get; set; } = null!;

    public virtual Rango NumRangoNavigation { get; set; } = null!;
}
