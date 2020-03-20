using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestowanieMVC.Models
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public bool? Potwierdzony { get; set; }
        public int Wiek { get; set; }
    }
}