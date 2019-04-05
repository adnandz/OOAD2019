using System;
using System.Collections.Generic;

namespace AspNetCoreAPI.Models
{
    public partial class UpisNaPredmet
    {
        public int UpisNaPredmetId { get; set; }
        public int PredmetId { get; set; }
        public int StudentId { get; set; }
        public int Ocjena { get; set; }

        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
    }
}
