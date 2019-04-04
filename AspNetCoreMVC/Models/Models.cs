using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Models
{
    public class Student
    {
        // dio klase u kojem definišemo atribute
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string ImePrezime { get { return string.Format("{0} {1}", Ime, Prezime); } }
        //dio u kojem se definišu veze sa ostalim klasama
        public virtual ICollection<UpisNaPredmet> UpisiNaPredmet { get; set; }
    }




    public class Predmet
    {
        // dio klase u kojem definišemo atribute
        [ScaffoldColumn(false)]
        public int PredmetId { get; set; }

        [StringLength(160)]
        [Required]
        [Display(Name ="Naziv predmeta")]
        public string Naziv { get; set; }

        [Range(4, 10,ErrorMessage = "ETCS može biti između 4 i 10")]
        public decimal ETCS { get; set; }

        //dio u kojem se definišu veze sa ostalim klasama
        public virtual ICollection<UpisNaPredmet> UpisiNaPredmet { get; set; }
    }

    public class UpisNaPredmet
    {
        // dio klase u kojem definišemo atribute
        public int UpisNaPredmetId { get; set; }
        [Display(Name = "Naziv predmeta")]
        public int PredmetId { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }
        [Range(5, 100, ErrorMessage = "Ocjena može biti od 5 do 10")]
        public int Ocjena { get; set; }
        //dio u kojem se definišu veze sa ostalim klasama

        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }

    }
}
