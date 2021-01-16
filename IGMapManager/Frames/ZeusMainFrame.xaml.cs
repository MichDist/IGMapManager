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

namespace IGMapManager.Frames
{
    /// <summary>
    /// Interaktionslogik für ZeusMainFrame.xaml
    /// </summary>
    public partial class ZeusMainFrame : Page
    {
        public ZeusMainFrame()
        {
            InitializeComponent();
        }

        private void BtnZeusSave_Click(object sender, RoutedEventArgs e)
        {
            ZeusFrame.Navigate(new Zeus.ZeusSaveGameFrame());
        }

        private void BtnZeusAdventure_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
