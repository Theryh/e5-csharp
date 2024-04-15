using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Adresse
{
    public int Id { get; set; }

    public string? Ville { get; set; }

    public string Rue { get; set; } = null!;

    public string? CodePostal { get; set; }

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();
}
