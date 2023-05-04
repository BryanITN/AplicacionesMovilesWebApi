using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Tecnico
{
    public int IdTecnico { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public byte[]? Foto { get; set; }

    public string? Contrasenia { get; set; }
}
