using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            int Raffle = 0;
            const int minLottoNumber = 1;
            const int maxLottoNumber = 45;
            do
            {
                int number = _random.Next(minLottoNumber, maxLottoNumber);
                lottoNumbersTextBox.Text += $"number {Raffle}: {number}\r\n";
                Raffle++;
            }
            while (Raffle <= 6);
            
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            // removing output
            lottoNumbersTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}