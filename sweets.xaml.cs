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

namespace RestuaruntApp
{
    /// <summary>
    /// Interaction logic for sweets.xaml
    /// </summary>
    public partial class sweets : Window
    {
        public sweets()
        {
            InitializeComponent();
        }

        private void BaconCheeseWhopperbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CiniMinis page1 = new CiniMinis();
            page1.Show();
        }

        private void BBQBaconCrispyChickenbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            HERSHEY_SSundaePie page1 = new HERSHEY_SSundaePie();
            page1.Show();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            menucard page1 = new menucard();
            page1.Show();

        }

        private void BBQBaconWhopperbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            Chocolate_Cookie page1 = new Chocolate_Cookie();
            page1.Show();
        }

        private void CrispyChickenCaesarSandwichbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            PiemadewithTWIX page1 = new PiemadewithTWIX();
            page1.Show();
        }

        private void GrilledChickenbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            HERSHEY_S_Sundae page1 = new HERSHEY_S_Sundae();
            page1.Show();
        }

        private void SpicyCrispyChickenCaesarbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Dutch_Apple_Pie page1 = new Dutch_Apple_Pie();
            page1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            bill obj = new bill();
            obj.Show();
        }

        
    }
}

