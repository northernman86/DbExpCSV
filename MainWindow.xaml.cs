using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DbExpCSV
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbLoad.Text = "Ready";
        }

        private void ClearDbConnect_Click(object sender, RoutedEventArgs e)
        {
            textBoxDb.Text = null;
        }

        private void ClearQuery_Click(object sender, RoutedEventArgs e)
        {
            textBoxQuery.Text = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://github.com/northernman86/DbExpCSV";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Owner = this;
            about.ShowDialog();
        }
    }
}
