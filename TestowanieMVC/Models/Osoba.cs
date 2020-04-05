using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestowanieMVC.Models
{
    public class Osoba
    {
        [Required(ErrorMessage = "Proszę podać swoje imie")]
        public string Imie { get; set; }
        [Required(ErrorMessage ="Proszę wprowadzić nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Proszę podać poprawny numer telefonu")]
        [RegularExpression("\\d{9}")]
        public string Telefon { get; set; }
        [Required(ErrorMessage ="Uzupełnić potwierdzenie")]
        public bool? Potwierdzony { get; set; }
        public int Wiek { get; set; }
    }
}