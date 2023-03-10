using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public bool czyZalogowany { get; set; }

        public Page2(bool czZalogowany)
        {
            this.czyZalogowany = czyZalogowany;
        }

        public Page2()
        {
            InitializeComponent();
        }
        private void clickVerify(object sender, RoutedEventArgs e)
        {
            string nazwaPliku = "C:\\Users\\User\\Desktop\\uzytkownicy.txt";
            string szukanyUzytkownikImie = imielogbox.Text;
            string szukanyUzytkownikHaslo = haslologbox.Text;
            bool UzytkownikZnaleziony = false;

            using (StreamReader sr = new StreamReader(nazwaPliku))
            {
                string linia;
                while((linia = sr.ReadLine())!=null) {
                    if (linia.Contains(szukanyUzytkownikImie) && linia.Contains(szukanyUzytkownikHaslo))
                    {
                        UzytkownikZnaleziony=true;
                        break;
                    }
                }
            }
            if(UzytkownikZnaleziony) {
                MessageBox.Show("zalogowales sie");
                czyZalogowany = true;
            }
            else
            {
                MessageBox.Show("nie zalogowales sie");
                czyZalogowany = false;
            }
        }
    }
}
