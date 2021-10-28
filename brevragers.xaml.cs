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
    /// Interaction logic for brevragers.xaml
    /// </summary>
    public partial class brevragers : Window
    {
        public brevragers()
        {
            InitializeComponent();
        }

        private void BaconCheeseWhopperbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            IcedTea page1 = new IcedTea();
            page1.Show();
        }

        private void BBQBaconCrispyChickenbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Drpeppr page1 = new Drpeppr();
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
            Frozencoc page1 = new Frozencoc();
            page1.Show();
        }

        private void CrispyChickenCaesarSandwichbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            CocaCola page1 = new CocaCola();
            page1.Show();
        }

        private void GrilledChickenbtn_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            MinuteMaidLemonade page1 = new MinuteMaidLemonade();
            page1.Show();
        }

        private void SpicyCrispyChickenCaesarbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FrozenFantaICEE page1 = new FrozenFantaICEE();
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
