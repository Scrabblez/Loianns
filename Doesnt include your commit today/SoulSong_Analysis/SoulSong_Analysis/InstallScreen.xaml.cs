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
using System.Windows.Shapes;

namespace SoulSong_Analysis
{
    /// <summary>
    /// Interaction logic for InstallScreen.xaml
    /// </summary>
    public partial class InstallScreen : Window
    {

        public InstallScreen()
        {
            InitializeComponent();
        }

        /// Starts Install Process
        private void btnInstall_Click(object sender, RoutedEventArgs e)
        {
        }

        /// Closes Application
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnNextScreen_Click1(object sender, RoutedEventArgs e)
        {
            var SplashScreen = new SplashScreen();
            SplashScreen.Show();
            this.Close();

        }

    }
}
