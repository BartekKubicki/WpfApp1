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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        private int currentPlayer = 1;
        private int[,] gameBoard = new int[3, 3];
        private int lewa;
        private int prawa;
        public Page1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            int row = Grid.GetRow(button);
            int col = Grid.GetColumn(button);

            if (gameBoard[row, col] == 0)
            {
                gameBoard[row, col] = currentPlayer;

                if (currentPlayer == 1)
                {
                    button.Content = "X";
                    button.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    button.Content = "O";
                    button.Foreground = new SolidColorBrush(Colors.Blue);
                }

                currentPlayer = (currentPlayer == 1) ? 2 : 1;

                if (CheckForWinner())
                {
                    MessageBox.Show("Player " + ((currentPlayer == 1) ? "2" : "1") + " wins!");
                    if (currentPlayer == 1)
                    {
                        lewa++;
                    }
                    else
                    {
                        prawa++;
                    }
                    ResetGame();
                }
                else if (CheckForTie())
                {
                    MessageBox.Show("Tie game!");
                    ResetGame();
                }
            }
        }

        private bool CheckForWinner()
        {
            wynikblock.Text = $"Wynik: {lewa} - {prawa}";
           
            for (int row = 0; row < 3; row++)
            {
                if (gameBoard[row, 0] != 0 && gameBoard[row, 0] == gameBoard[row, 1] && gameBoard[row, 1] == gameBoard[row, 2])
                {
                    return true;
                }
            }

         
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] != 0 && gameBoard[0, col] == gameBoard[1, col] && gameBoard[1, col] == gameBoard[2, col])
                {
                    return true;
                }
            }
            if (gameBoard[0, 0] != 0 && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                return true;
            }
            if (gameBoard[0, 2] != 0 && gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                return true;
            }

            return false;
        }

        private bool CheckForTie()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (gameBoard[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void ResetGame()
        {
            currentPlayer = 1;
            gameBoard = new int[3, 3];

            button00.Content = "";
            button01.Content = "";
            button02.Content = "";
            button10.Content = "";
            button11.Content = "";
            button12.Content = "";
            button20.Content = "";
            button21.Content = "";
            button22.Content = "";
        }


    }
}
