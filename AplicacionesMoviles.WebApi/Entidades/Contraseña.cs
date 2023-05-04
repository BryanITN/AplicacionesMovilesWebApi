using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Contraseña
{
    public int IdTecnico { get; set; }

    public string? Contraseña1 { get; set; }

    public virtual Tecnico IdTecnicoNavigation { get; set; } = null!;
}
