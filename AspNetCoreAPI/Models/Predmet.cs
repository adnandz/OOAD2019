using System;
using System.Collections.Generic;

namespace AspNetCoreAPI.Models
{
    public partial class Predmet
    {
        public Predmet()
        {
            UpisNaPredmet = new HashSet<UpisNaPredmet>();
        }

        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public decimal Etcs { get; set; }

        public virtual ICollection<UpisNaPredmet> UpisNaPredmet { get; set; }
    }
}
