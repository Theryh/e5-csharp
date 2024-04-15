using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Contrat
{
    public int Id { get; set; }

    public string? LibelleContrat { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public int? PartenaireId { get; set; }

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();

    public virtual Partenaire? Partenaire { get; set; }
}
