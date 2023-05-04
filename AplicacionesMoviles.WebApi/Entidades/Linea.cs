using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Linea
{
    public int? IdTecnico { get; set; }

    public int? NumEstacion { get; set; }

    public int NumPrueba { get; set; }

    public string? Equipo { get; set; }

    public virtual Tecnico? IdTecnicoNavigation { get; set; }
}
