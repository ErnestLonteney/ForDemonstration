using System.Windows;

namespace LogginingForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _firstLoading;
        private bool isRegistration = false;
        public MainWindow()
        {
            _firstLoading = true;
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ClearForm();
            isRegistration = true;
            btMain.Content = "Register";
            pbConfirm.Visibility = Visibility.Visible;
            lbConfirm.Visibility = Visibility.Visible;
            lbMessage.Content = "Please input your registration data";
        }

        private void rbLogin_Checked(object sender, RoutedEventArgs e)
        {
            isRegistration = false;

            if (!_firstLoading)
            {
                ClearForm();
                btMain.Content = "Log in";
                pbConfirm.Visibility = Visibility.Collapsed;
                lbConfirm.Visibility = Visibility.Collapsed;
                lbMessage.Content = "Please input your loggin and password";
            }
            else
            {
                _firstLoading = false;
            }
        }

        private void btMain_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLogin.Text) &&
                !string.IsNullOrWhiteSpace(pbPassword.Password) &&
                (!isRegistration || 
                (isRegistration && 
                !string.IsNullOrWhiteSpace(pbConfirm.Password) && 
                pbPassword.Password == pbConfirm.Password)))
            {
                var message = isRegistration ? "Registration" : "Loggining";
                MessageBox.Show($"{message} sucessfull");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Check inputed data");
            }
        }

        private void ClearForm()
        {
            tbLogin.Clear();
            pbPassword.Clear();
            pbConfirm.Clear();        
        }
    }
}