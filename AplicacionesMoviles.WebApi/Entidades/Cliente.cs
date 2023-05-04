using System;
using System.Collections.Generic;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class Cliente
{
    public int? IdCliente { get; set; }

    public int NumOrden { get; set; }

    public string? Cliente1 { get; set; }

    public virtual ICollection<Informacion> Informacions { get; set; } = new List<Informacion>();
}
