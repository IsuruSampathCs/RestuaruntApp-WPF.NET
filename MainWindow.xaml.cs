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

namespace RestuaruntApp
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

        private void helpbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sizeup(object sender, MouseEventArgs e)
        {
            Button button1 = (Button)sender;
            button1.Height = button1.Height + 15;
            
            
        }

        private void sizedown(object sender, MouseEventArgs e)
        {
            Button button1 = (Button)sender;
            button1.Height = button1.Height - 15;
        }

        private void size(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            DetailPage page1 = new DetailPage();
            page1.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
