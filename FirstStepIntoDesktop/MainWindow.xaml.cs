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

namespace FiorstStepIntoDesktop
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool? isTermsAccepted = cbTerms.IsChecked;
            string input = tbAgeInput.Text;

            if (byte.TryParse(input, out byte age) && age >= 18 && isTermsAccepted.Value)
            {
                string message = $"Access accepted! You are {age}.";

                if (rbStandard.IsChecked == true)
                {
                    message += " You have standard access.";
                }
                else if (rbPremium.IsChecked == true)
                {
                    message += " You have premium access.";
                }

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please enter a valid age (over 18) and accept terms.");
            }
        }
    }
}