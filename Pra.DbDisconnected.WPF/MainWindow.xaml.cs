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

namespace Pra.DbDisconnected.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        private void Sort_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Filter_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddAuthor_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveAuthor_Click(object sender, RoutedEventArgs e)
        {
            if (dgAuthors.SelectedIndex > -1)
            {
            }

        }
    }
}
