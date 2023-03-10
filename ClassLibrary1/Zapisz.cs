using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Zapisz
    {
        public static void zapiszUzytkownikaDoPliku(string path, Uzytkownik uzytkownik)
        {
            File.AppendAllText(path, uzytkownik.imieJakoNapis());
        }

    }
}
