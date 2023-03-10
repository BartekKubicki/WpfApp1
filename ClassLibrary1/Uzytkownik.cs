using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Uzytkownik
    {
        private string imie { set; get; }
        private string haslo { set; get; }
        

        public Uzytkownik(string imie, string haslo)
        {
            this.imie = imie;
            this.haslo = haslo;
        }

        public String imieJakoNapis()
        {
            String imiona = $"Uzytkonik: {imie} + hasło: {haslo}";
            return imiona + " \n";
        }


    }
}
