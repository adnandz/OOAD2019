using System;
using System.Collections.Generic;

namespace AspNetCoreAPI.Models
{
    public partial class Student
    {
        public Student()
        {
            UpisNaPredmet = new HashSet<UpisNaPredmet>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public virtual ICollection<UpisNaPredmet> UpisNaPredmet { get; set; }
    }
}
