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
    /// Interaction logic for Grilled_Chicken.xaml
    /// </summary>
    public partial class Grilled_Chicken : Window
    {
        public static int qty = 1;
        public static int burgerPrice = 0, extra = 0, totburgerPrice = 0;
        public static string bcwsize = "";
        public static string itmName = "";
        public Grilled_Chicken()
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bcwsize == "s" | bcwsize == "m" | bcwsize == "l" | cheesecombobox.SelectedIndex == 0)
            {

                if (cheesecombobox.SelectedIndex == 0)
                {
                    extra = 0;
                    totburgerPrice = (burgerPrice + extra) * qty;
                    pricebox.Text = Convert.ToString(totburgerPrice);

                }
                else if (cheesecombobox.SelectedIndex == 1)
                {
                    extra = 50;
                    totburgerPrice = (burgerPrice + extra) * qty;
                    pricebox.Text = Convert.ToString(totburgerPrice);
                }
                else if (cheesecombobox.SelectedIndex == 2)
                {
                    extra = 100;
                    totburgerPrice = (burgerPrice + extra) * qty;
                    pricebox.Text = Convert.ToString(totburgerPrice);
                }
                else if (cheesecombobox.SelectedIndex == 3)
                {
                    extra = 150;
                    totburgerPrice = (burgerPrice + extra) * qty;
                    pricebox.Text = Convert.ToString(totburgerPrice);
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Please select size before add extra somthing", "sorry",
                MessageBoxButton.OK, MessageBoxImage.Information);
                cheesecombobox.SelectedIndex = 0;

            }
        }

        private void quantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void small_Checked(object sender, RoutedEventArgs e)
        {
            burgerPrice = 580;
            totburgerPrice = (burgerPrice + extra) * qty;
            pricebox.Text = Convert.ToString(totburgerPrice);
            quantitybcw.Text = Convert.ToString(qty);
            bugersizeimge.Width = 318;
            bcwsize = "s";
        }

        private void medium_Checked(object sender, RoutedEventArgs e)
        {
            burgerPrice = 600;
            totburgerPrice = (burgerPrice + extra) * qty;
            bcwsize = "m";
            pricebox.Text = Convert.ToString(totburgerPrice);
            bugersizeimge.Width = 338;
            quantitybcw.Text = Convert.ToString(qty);

        }

        private void large_Checked(object sender, RoutedEventArgs e)
        {
            burgerPrice = 620;
            totburgerPrice = (burgerPrice + extra) * qty;
            bcwsize = "l";
            pricebox.Text = Convert.ToString(totburgerPrice);
            bugersizeimge.Width = 358;
            quantitybcw.Text = Convert.ToString(qty);

        }

        private void addCartbtn_Click(object sender, RoutedEventArgs e)
        {
            if (bcwsize == "s")
            {
                if (extra == 0)
                {
                    itmName = "Small Flame Grilled Chicken"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 50)
                {
                    itmName = "small Flame Grilled Chicken extra cheese 1"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 100)
                {
                    itmName = "small Flame Grilled Chicken extra cheese 2"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 150)
                {
                    itmName = "small Flame Grilled Chicken extra cheese 3"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {

                }
            }
            else if (bcwsize == "m")
            {
                if (extra == 0)
                {
                    itmName = "medium Flame Grilled Chicken"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 50)
                {
                    itmName = "medium Flame Grilled Chicken extra cheese 1"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 100)
                {
                    itmName = "medium Flame Grilled Chicken extra cheese 2"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 150)
                {
                    itmName = "medium Flame Grilled Chicken extra cheese 3"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {

                }
            }
            else if (bcwsize == "l")
            {
                if (extra == 0)
                {
                    itmName = "large Flame Grilled Chicken"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 50)
                {
                    itmName = "large Flame Grilled Chicken extra cheese 1"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 100)
                {
                    itmName = "large Flame Grilled Chicken extra cheese 2"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else if (extra == 150)
                {
                    itmName = "large Flame Grilled Chicken extra cheese 3"; MessageBox.Show("Your foods add to cart successfully", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please select a size", "Order list", MessageBoxButton.OK, MessageBoxImage.Information);

            }
           

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            bugerlistxaml page1 = new bugerlistxaml();
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
