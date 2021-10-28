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
    /// Interaction logic for bugerlistxaml.xaml
    /// </summary>
    public partial class bugerlistxaml : Window
    {
        public bugerlistxaml()
        {
            InitializeComponent();
        }

      

        private void BaconCheeseWhopperbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            BaconCheesewhoppe page1 = new BaconCheesewhoppe();
            page1.Show();       
        }

        private void BBQBaconCrispyChickenbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            BBQBaconCrispyChicken page1 = new BBQBaconCrispyChicken();
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
            BBQBaconWhopper page1 = new BBQBaconWhopper();
            page1.Show();
        }

        private void CrispyChickenCaesarSandwichbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            CrispyChickenCaesarxaml page1 = new CrispyChickenCaesarxaml();
            page1.Show();
        }

        private void GrilledChickenbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            Grilled_Chicken page1 = new Grilled_Chicken();
            page1.Show();
        }

        private void SpicyCrispyChickenCaesarbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            SpicyCrispyChickenCaesar page1 = new SpicyCrispyChickenCaesar();
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
