using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Diffuseur
{
    public int Id { get; set; }

    public string? LibelleDiffuseur { get; set; }

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();
}
