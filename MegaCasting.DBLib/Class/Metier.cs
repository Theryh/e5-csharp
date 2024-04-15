using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Metier
{
    public int Id { get; set; }

    public string? LibelleMetier { get; set; }

    public virtual ICollection<Artiste> Artistes { get; set; } = new List<Artiste>();

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();
}
