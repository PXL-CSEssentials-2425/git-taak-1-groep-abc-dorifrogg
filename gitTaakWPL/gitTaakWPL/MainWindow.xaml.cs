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
            kleurcodeTextBox.Text = "";
            informatieTextBox.Text = "";
        }

        private void imageGeel_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
            kleurcodeTextBox.Text = "";
            informatieTextBox.Text = "";
        }

        private void imageGroen_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
            kleurcodeTextBox.Text = "";
            informatieTextBox.Text = "";
        }

        private void imageBlauw_MouseLeave(object sender, MouseEventArgs e)
        {
            gridMainWindow.Background = Brushes.LightGray;
            kleurcodeTextBox.Text = "";
            informatieTextBox.Text = "";
        }

        private void imageRood_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#FF0000";
            informatieTextBox.Text = "Rood is de kleur van warmte";
        }

        private void imageGeel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#FFFF00";
            informatieTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void imageGroen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#008000";
            informatieTextBox.Text = "Groen is de kleur van genezing";
        }

        private void imageBlauw_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextBox.Text = "#0000FF";
            informatieTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}