using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class;

public partial class Casting
{
    public int Id { get; set; }

    public string? TypeCasting { get; set; }

    public string LibelleCasting { get; set; } = null!;

    public DateTime DatePublication { get; set; }

    public int AdresseId { get; set; }

    public int DiffuseurId { get; set; }

    public string? IntituleCasting { get; set; }

    public int DomaineMetier { get; set; }

    public int TypeContrat { get; set; }

    public virtual Adresse Adresse { get; set; } = null!;

    public virtual Diffuseur Diffuseur { get; set; } = null!;

    public virtual Metier DomaineMetierNavigation { get; set; } = null!;

    public virtual Contrat TypeContratNavigation { get; set; } = null!;
}
