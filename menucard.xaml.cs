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
    /// Interaction logic for menucard.xaml
    /// </summary>

    
    public partial class menucard : Window
    {
        
        public menucard()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            sweets obj = new sweets();
            obj.Show();
        }

        private void mouseon(object sender, MouseEventArgs e)
        {
            bugerlistbtn.Content = "BURGER";
            Button button1 = (Button)sender;
            button1.Height = button1.Height + 10;


        }

        private void mouseoff(object sender, MouseEventArgs e)
        {
            bugerlistbtn.Content = "";
            Button button1 = (Button)sender;
            button1.Height = button1.Height - 10;
        }

        private void sizeup2(object sender, MouseEventArgs e)
        {
            beveragersbtn.Content = "BEVERAGES";
            Button button1 = (Button)sender;
            button1.Height = button1.Height + 10;
        }

        private void sizedown2(object sender, MouseEventArgs e)
        {
            beveragersbtn.Content = "";
            Button button1 = (Button)sender;
            button1.Height = button1.Height - 10;
        }

     

        
       

        

        private void size5(object sender, MouseEventArgs e)
        {
            drinkbtn.Content = "SWEETS";
            Button button1 = (Button)sender;
            button1.Height = button1.Height + 10;
        }

        private void sizedown5(object sender, MouseEventArgs e)
        {
            drinkbtn.Content = "";
            Button button1 = (Button)sender;
            button1.Height = button1.Height - 10;
        }


        private void closebtnclick(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Are sure to cancel your oder","Menu card", MessageBoxButton.YesNo,MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                   
                    MessageBox.Show("Your Ode Is Droped", "Menu Card", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();

                    Dutch_Apple_Pie.itmName = "";
                    Dutch_Apple_Pie.qty =0;
                    Dutch_Apple_Pie.totburgerPrice = 0;

                    HERSHEY_S_Sundae.itmName = "";
                    HERSHEY_S_Sundae.qty = 0;
                    HERSHEY_S_Sundae.totburgerPrice = 0;

                    PiemadewithTWIX.itmName = "";
                    PiemadewithTWIX.qty = 0;
                    PiemadewithTWIX.totburgerPrice = 0;

                    Chocolate_Cookie.itmName = "";
                    Chocolate_Cookie.qty = 0;
                    Chocolate_Cookie.totburgerPrice = 0;

                    HERSHEY_SSundaePie.itmName = "";
                    HERSHEY_SSundaePie.qty = 0;
                    HERSHEY_SSundaePie.totburgerPrice = 0;

                    CiniMinis.itmName = "";
                    CiniMinis.qty = 0;
                    CiniMinis.totburgerPrice = 0;

                    FrozenFantaICEE.itmName = "";
                    FrozenFantaICEE.qty = 0;
                    FrozenFantaICEE.totburgerPrice = 0;

                    MinuteMaidLemonade.itmName = "";
                    MinuteMaidLemonade.qty = 0;
                    MinuteMaidLemonade.totburgerPrice = 0;

                    CocaCola.itmName = "";
                    CocaCola.qty = 0;
                    CocaCola.totburgerPrice = 0;

                    Frozencoc.itmName = "";
                    Frozencoc.qty = 0;
                    Frozencoc.totburgerPrice = 0;

                    Drpeppr.itmName = "";
                    Drpeppr.qty = 0;
                    Drpeppr.totburgerPrice = 0;

                    IcedTea.itmName = "";
                    IcedTea.qty = 0;
                    IcedTea.totburgerPrice = 0;

                    SpicyCrispyChickenCaesar.itmName = "";
                    SpicyCrispyChickenCaesar.qty = 0;
                    SpicyCrispyChickenCaesar.totburgerPrice = 0;

                    Grilled_Chicken.itmName = "";
                    Grilled_Chicken.qty = 0;
                    Grilled_Chicken.totburgerPrice = 0;

                    CrispyChickenCaesarxaml.itmName = "";
                    CrispyChickenCaesarxaml.qty = 0;
                    CrispyChickenCaesarxaml.totburgerPrice = 0;

                    BBQBaconWhopper.itmName = "";
                    BBQBaconWhopper.qty = 0;
                    BBQBaconWhopper.totburgerPrice = 0;

                    BBQBaconCrispyChicken.itmName = "";
                    BBQBaconCrispyChicken.qty = 0;
                    BBQBaconCrispyChicken.totburgerPrice = 0;

                    BaconCheesewhoppe.itmName = "";
                    BaconCheesewhoppe.qty = 0;
                    BaconCheesewhoppe.totburgerPrice = 0;                

                    MainWindow obj = new MainWindow();
                    obj.Show();

                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            DetailPage page1 = new DetailPage();
            page1.Show();
        }

        private void seeTable_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            bill page1 = new bill();
            page1.Show();
        }

        private void bugerlistbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            bugerlistxaml page1 = new bugerlistxaml();
            page1.Show();
        }

        private void beveragersbtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            brevragers page1 = new brevragers();
            page1.Show();
        }
    }
}
