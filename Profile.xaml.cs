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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string nickname = NicknameBox.Text;
            string status = StatusBox.Text;

            MessageBox.Show($"Profile saved!\nNickname: {nickname}\nStatus: {status}", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BackToDashboard_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new Dashboard(); // go back to Dashboard
            }
        }
    }
}
