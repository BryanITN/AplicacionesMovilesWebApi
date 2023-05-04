using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Prueba
{
    public int NumPrueba { get; set; }

    public int NP { get; set; }

    public int? Part1 { get; set; }

    public int? Part2 { get; set; }

    public string? Lectura { get; set; }

    public string? Bandera { get; set; }

    public int? Vuelta { get; set; }

    public int IdInfo { get; set; }
}
