﻿using System;
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
using IGMapManager.DB;

namespace IGMapManager.Frames.Zeus
{
    /// <summary>
    /// Interaktionslogik für ZeusSaveGameFrame.xaml
    /// </summary>
    public partial class ZeusSaveGameFrame : Page
    {
        // Refactor: See ConfigSettings class

        public ZeusSaveGameFrame()
        {
            InitializeComponent();

            if(DB.ConfigSettings.getPath("Zeus", "No") == "")
            {
                txtZeusGameDirPath.Text = "Set the game dir path!";
            }
            else
            {
                txtZeusGameDirPath.Text = DB.ConfigSettings.getPath("Zeus", "No");
            }
            if(DB.ConfigSettings.getPath("Zeus", "Yes") == "")
            {
                txtZeusRepoDirPath.Text = "Set Zeus repo path";
            }
            else
            {
                txtZeusRepoDirPath.Text = DB.ConfigSettings.getPath("Zeus", "Yes");
            }
        }

        private void BtnZeusSaveSetPath_Click(object sender, RoutedEventArgs e)
        {
            DB.ConfigSettings.setPath(txtZeusGameDirPath.Text, "Zeus", "No");
            txtZeusGameDirPath.Text = DB.ConfigSettings.getPath("Zeus", "No");
        }

        private void BtnZeusSaveSetRepoPath_Click(object sender, RoutedEventArgs e)
        {
            DB.ConfigSettings.setPath(txtZeusRepoDirPath.Text, "Zeus", "Yes");
            txtZeusRepoDirPath.Text = DB.ConfigSettings.getPath("Zeus", "Yes");
        }

        private void BtnZeusSaveProfile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
