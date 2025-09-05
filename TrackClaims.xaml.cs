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
    /// Interaction logic for TrackClaims.xaml
    /// </summary>
    public partial class TrackClaims : UserControl
    {
        public TrackClaims()
        {
            InitializeComponent();
            LoadMockClaims();
        }
        private void LoadMockClaims()
        {
            var claims = new List<dynamic>
            {
                new { ClaimID = "C001", Title = "Medical Claim", Amount = "$200", Status = "Approved", DateSubmitted = DateTime.Now.AddDays(-10).ToShortDateString() },
                new { ClaimID = "C002", Title = "Travel Reimbursement", Amount = "$450", Status = "Pending", DateSubmitted = DateTime.Now.AddDays(-5).ToShortDateString() },
                new { ClaimID = "C003", Title = "Equipment Purchase", Amount = "$1200", Status = "Rejected", DateSubmitted = DateTime.Now.AddDays(-2).ToShortDateString() }
            };

            dgClaims.ItemsSource = claims;
        }

        private void BackToDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            if (main != null)
            {
                main.MainContent.Content = new Dashboard();
            }
        }
    }
}
