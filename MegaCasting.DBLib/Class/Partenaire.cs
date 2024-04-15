using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Partenaire
{
    public int Id { get; set; }

    public string? LibellePartenaire { get; set; }

    public virtual ICollection<Contrat> Contrats { get; set; } = new List<Contrat>();
}
