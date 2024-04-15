using System;
using System.Collections.Generic;

namespace MegaCasting.DBLib.Class
{
    public partial class Artiste
    {
        public int Id { get; set; }

        public string? Nom { get; set; }

        public string? Prenom { get; set; }

        public int? Age { get; set; }

        public int MetierId { get; set; }

        public virtual Metier Metier { get; set; } = null!;
    }

}
