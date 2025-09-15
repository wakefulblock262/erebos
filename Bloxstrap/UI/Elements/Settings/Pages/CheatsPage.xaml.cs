using System.Windows;
using Bloxstrap.UI.ViewModels.Settings;

namespace Bloxstrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for CheatsPage.xaml
    /// </summary>
    public partial class CheatsPage
    {
        public CheatsPage()
        {
            DataContext = new CheatsViewModel();
            InitializeComponent();
        }

        private void ToggleSwitch_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
