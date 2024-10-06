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

namespace gitTaakWPL
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

        private void imageRood_MouseEnter(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.Red;
        }

        private void imageGeel_MouseEnter(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.Yellow;
        }

        private void imageGroen_MouseEnter(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.Green;
        }

        private void imageBlauw_MouseEnter(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.Blue;
        }

        private void imageRood_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
        }

        private void imageGeel_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
        }

        private void imageGroen_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
        }

        private void imageBlauw_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
        }
    }
}