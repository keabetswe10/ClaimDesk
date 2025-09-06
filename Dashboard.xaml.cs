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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new Login();
            }
        }
        private void AddClaim_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            if (main != null)
            {
                main.MainContent.Content = new AddClaim();
            }
        }
        private void TrackClaims_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            if (main != null)
            {
                main.MainContent.Content = new TrackClaims();
            }
        }
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new Profile(); // Navigate to Profile page
            }
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.MainContent.Content = new Settings(); // Navigate to Profile page
            }
        }
            private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to ApproveClaims page
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainContent.Content = new ApproveClaims();
            }
        }
    }
    }

