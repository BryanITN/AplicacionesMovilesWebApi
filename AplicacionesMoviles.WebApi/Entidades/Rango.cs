using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Rango
{
    public decimal NumRango { get; set; }

    public decimal? RangoMenor { get; set; }

    public decimal? RangoMayor { get; set; }

    public string? Unidad { get; set; }

    public virtual ICollection<Informacion> Informacions { get; set; } = new List<Informacion>();
}
