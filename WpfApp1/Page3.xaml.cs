using ClassLibrary1;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void clickSave(object sender, RoutedEventArgs e)
        {
            String imiebox = loginbox.Text;
            String haslobox = passbox.Text;

            Uzytkownik uzytkownik = new Uzytkownik(imiebox, haslobox);
            Zapisz.zapiszUzytkownikaDoPliku("C:\\Users\\User\\Desktop\\uzytkownicy.txt", uzytkownik);
        }
    }
}
