using System.Windows;

namespace ClaimDesk
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetStarted_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Login page
            MainContent.Content = new Login();
        }
    }
}
