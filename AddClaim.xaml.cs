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
    /// Interaction logic for AddClaim.xaml
    /// </summary>
    public partial class AddClaim : UserControl
    {
        public AddClaim()
        {
            InitializeComponent();
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
