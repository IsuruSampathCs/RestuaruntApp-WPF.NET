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
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace RestuaruntApp
{
    /// <summary>
    /// Interaction logic for DetailPage.xaml
    /// </summary>
    public partial class DetailPage : Window
    {
         public static string cus_email,cus_name,payoption="", tableno;
        
        public DetailPage()
        {
            InitializeComponent();
        }

        private void Sizeup(object sender, MouseEventArgs e)
        {
            
        }

        private void sizedown(object sender, MouseEventArgs e)
        {
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(namebox.Text))
            {
                MessageBox.Show("Please Enter name to continue");
                namebox.Focus();
                
            }
            else if (namebox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot have numbers");
                namebox.Focus();

            }
            else if (namebox.Text.Any(char.IsSymbol))
            {
               
                MessageBox.Show("Name cannot have symbols");
                namebox.Focus();
            }

            else if (payoption.Length == 0)
            {
                MessageBox.Show("Please Select a Pay Option");
               
            }

            else if (tableNoBox.Text.Length==0)
            {
                MessageBox.Show("Please give the table number on your table");

            }

            else if(Emailbox.Text.Length==0)
            {

                Hide();
                menucard page1 = new menucard();
                page1.Show();

                cus_email = Emailbox.Text;
                cus_name = namebox.Text;
            }
           
            else if (!Regex.IsMatch(Emailbox.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email. Ex:name@gmail.com");
                Emailbox.Focus();


                
            }
         

            else
            {
                cus_email = Emailbox.Text;
                cus_name = namebox.Text;
                tableno = tableNoBox.Text;

                Hide();
                menucard page1 = new menucard();
                page1.Show();
               

            }

        }




    

    private void sizeups(object sender, MouseEventArgs e)
        {
            Button button1 = (Button)sender;
            button1.Height = button1.Height + 5;
        }

        private void paycombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(paycombobox.SelectedIndex==0)
            {
                payoption = "Cash Pay";
            }
            else if(paycombobox.SelectedIndex==1)
            {
                payoption = "Card Pay";
            }
            else
            {
               
            }

        }

        private void sizedowns(object sender, MouseEventArgs e)
        {
            Button button1 = (Button)sender;
            button1.Height = button1.Height - 5;
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow page1 = new MainWindow();
            page1.Show();
        }
    }
}
