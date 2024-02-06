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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }

        private void New_Movie_BTN_Click(object sender, RoutedEventArgs e)
        {
            NewMovie Win2 = new NewMovie();
            Win2.Show();
            this.Close();
        }

        private void Delete_BTN_Click(object sender, RoutedEventArgs e)
        {
            DeleteMovie Win3 = new DeleteMovie();
            Win3.Show();
            this.Close();
        }

        private void Close_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
