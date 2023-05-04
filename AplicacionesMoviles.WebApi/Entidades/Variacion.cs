using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Variacion
{
    public int NumVariacion { get; set; }

    public int? NumModelo { get; set; }

    public string? Desviaciones { get; set; }

    public string? Ecn { get; set; }

    public virtual Informacion NumVariacionNavigation { get; set; } = null!;
}
