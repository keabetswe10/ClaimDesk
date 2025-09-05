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

namespace ClaimDesk
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private void SignUp_Click(object sender, MouseButtonEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new SignUp();
            }
        }
        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new ForgotPassword();
            }
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new Dashboard(); // Show dashboard after login
            }

        }
    }
}
