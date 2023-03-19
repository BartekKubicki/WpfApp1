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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickPlay(object sender, RoutedEventArgs e)
        {
            Page2 wojtek = new Page2();
            if (Authentication.isAuthenticated)
            {
                MainWindow window = new MainWindow();
                window.Close();
                Page1 page1 = new Page1();
                page1.Show();
            }
            else
            {
                MessageBox.Show("Użytkownik nie zalogowany");
            }
        }

        private void clickRegistration(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Close();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void clickLog(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Close();
            Page3 page3 = new Page3();
            page3.Show();
        }
    }
}
