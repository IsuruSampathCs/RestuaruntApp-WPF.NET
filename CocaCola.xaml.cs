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
    /// Interaction logic for CocaCola.xaml
    /// </summary>
    public partial class CocaCola : Window
    {
        public static int qty = 1;
        public static int burgerPrice = 0, extra = 0, totburgerPrice = 0;
        public static string bcwsize = "";
        public static string itmName = "";
        public CocaCola()
        {
            InitializeComponent();
        }
        private void pluse_Click(object sender, RoutedEventArgs e)
        {
            qty = qty + 1;
            totburgerPrice = (burgerPrice + extra) * qty;
            pricebox.Text = Convert.ToString(totburgerPrice);
            quantitybcw.Text = Convert.ToString(qty);
        }



        private void quantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void small_Checked(object sender, RoutedEventArgs e)
        {
            burgerPrice = 150;
            totburgerPrice = burgerPrice * qty;
            pricebox.Text = Convert.ToString(totburgerPrice);
            quantitybcw.Text = Convert.ToString(qty);
            bugersizeimge.Height = 212;
            sizeblock.Text = "Your Drink size is Small";
            bcwsize = "s";
        }



        private void large_Checked(object sender, RoutedEventArgs e)
        {
            burgerPrice =170;
            totburgerPrice = burgerPrice * qty;
            bcwsize = "l";
            pricebox.Text = Convert.ToString(totburgerPrice);
            bugersizeimge.Height = 231;
            sizeblock.Text = "Your Drink size is Large";
            quantitybcw.Text = Convert.ToString(qty);

        }

        private void addCartbtn_Click(object sender, RoutedEventArgs e)
        {
            if (bcwsize == "s")
            {


                itmName = "Small Coca Cola";
                MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);


            }

            else if (bcwsize == "l")
            {


                itmName = "large Coca Cola";
                MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);


            }
            else
            {
                MessageBox.Show("Please select a size", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

            }


        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            brevragers page1 = new brevragers();
            page1.Show();
        }


        private void minze_Click(object sender, RoutedEventArgs e)
        {
            if (qty == 0)
            {

            }
            else
            {
                qty = qty - 1;
                totburgerPrice = (burgerPrice + extra) * qty;
                pricebox.Text = Convert.ToString(totburgerPrice);
                quantitybcw.Text = Convert.ToString(qty);
            }
        }
    }


}

