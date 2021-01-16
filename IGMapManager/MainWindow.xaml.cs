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

namespace IGMapManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Create database
            DB.DatabaseSetup.createDatabase();
        }

        private void BtnZeus_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frames.ZeusMainFrame());
        }

        private void BtnEmperor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPharaoh_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Frames.PharaohMainFrame());
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
