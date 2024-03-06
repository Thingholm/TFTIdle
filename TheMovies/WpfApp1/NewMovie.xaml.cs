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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NewMovie.xaml
    /// </summary>
    public partial class NewMovie : Window
    {
        public NewMovie()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }

        private void Back_BTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private MainWindow mainwindow;


        private void Tilføj_BTN_Click(object sender, RoutedEventArgs e)
        {
            string Biotext = Bio_txtb.Text;
            string citytext = City_Txtb.Text;
            string Showtext = Showtime_txtb.Text;
            string titletext = Title_txtb.Text;
            string genretext = genre_txtb.Text;
            string timetext = Time_txtb.Text;
            string instructortext = Instructor_txtb.Text;
            string premdatetext = Premdate_txtb.Text;
            string bookingtext = Booking_txtb.Text;
            string mailtext = Mail_Txtb.Text;
            string tlfnrtext = tlfnr_txtb.Text;
        
           // MainWindow.UpdateTextBoxes(Biotext, citytext, Showtext, titletext, genretext, timetext, instructortext, premdatetext, bookingtext, mailtext, tlfnrtext) 
        }
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    mainwindow = new MainWindow();
        //}
    }
}
