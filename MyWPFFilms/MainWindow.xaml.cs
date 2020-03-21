using System.Windows;
using System.Windows.Media;

namespace MyWPFFilms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string SUCCESS_MESSAGE = "Success!";
        const string ERROR_MESSAGE = "Something went wrong...";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            lbl_LoginInfo.Visibility = Visibility.Visible;
            if (string.IsNullOrEmpty(txB_Password.Password) || string.IsNullOrEmpty(txB_Username.Text))
            {
                LoginError();
            }
            else
            {
                LoginSuccess();
            }
        }

        private void LoginError()
        {
            lbl_LoginInfo.Content = ERROR_MESSAGE;
            lbl_LoginInfo.Background = new SolidColorBrush(Colors.Red);
        }

        private void LoginSuccess()
        {
            lbl_LoginInfo.Content = SUCCESS_MESSAGE;
            lbl_LoginInfo.Background = new SolidColorBrush(Colors.Green);
        }
    }
}
