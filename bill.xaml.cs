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
using System.Net;
using System.Net.Mail;

namespace RestuaruntApp
{
    /// <summary>
    /// Interaction logic for bill.xaml
    /// </summary>
    public partial class bill : Window
    {
        double amount=0;
        string[] itemNames = new string[20];
        string message="";
        int count;
        public List<BillData> myBills { get; set; }
        public bill()
        {
            InitializeComponent();
            myBills = new List<BillData>();

            if (!string.IsNullOrEmpty(BaconCheesewhoppe.itmName))
            {

                BillData itm1 = new BillData();
                itm1.Name = BaconCheesewhoppe.itmName;
                itm1.quantity = BaconCheesewhoppe.qty;
                itm1.priceOfItem = BaconCheesewhoppe.totburgerPrice;
                amount = amount + BaconCheesewhoppe.totburgerPrice;
                count++;
                itemNames[count]= BaconCheesewhoppe.itmName;
                myBills.Add(itm1);

                
            }

            if (!string.IsNullOrEmpty(BBQBaconCrispyChicken.itmName))
            {
                BillData itm2 = new BillData();
                itm2.Name = BBQBaconCrispyChicken.itmName;
                itm2.quantity = BBQBaconCrispyChicken.qty;
                itm2.priceOfItem = BBQBaconCrispyChicken.totburgerPrice;
                amount = amount + BBQBaconCrispyChicken.totburgerPrice;
                count++;
                itemNames[count] = BBQBaconCrispyChicken.itmName;
                myBills.Add(itm2);
            }

            if (!string.IsNullOrEmpty(BBQBaconWhopper.itmName))
            {
                BillData itm3 = new BillData();
                itm3.Name = BBQBaconWhopper.itmName;
                itm3.quantity = BBQBaconWhopper.qty;
                itm3.priceOfItem = BBQBaconWhopper.totburgerPrice;
                amount = amount + BBQBaconWhopper.totburgerPrice;
                count++;
                itemNames[count] = BBQBaconWhopper.itmName;
                myBills.Add(itm3);
            }

            if (!string.IsNullOrEmpty(CrispyChickenCaesarxaml.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = CrispyChickenCaesarxaml.itmName;
                itm4.quantity = CrispyChickenCaesarxaml.qty;
                itm4.priceOfItem = CrispyChickenCaesarxaml.totburgerPrice;
                amount = amount + CrispyChickenCaesarxaml.totburgerPrice;
                count++;
                itemNames[count] = CrispyChickenCaesarxaml.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(Grilled_Chicken.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = Grilled_Chicken.itmName;
                itm4.quantity = Grilled_Chicken.qty;
                itm4.priceOfItem = Grilled_Chicken.totburgerPrice;
                amount = amount + Grilled_Chicken.totburgerPrice;
                count++;
                itemNames[count] = Grilled_Chicken.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(SpicyCrispyChickenCaesar.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = SpicyCrispyChickenCaesar.itmName;
                itm4.quantity = SpicyCrispyChickenCaesar.qty;
                itm4.priceOfItem = SpicyCrispyChickenCaesar.totburgerPrice;
                amount = amount + SpicyCrispyChickenCaesar.totburgerPrice;
                count++;
                itemNames[count] = SpicyCrispyChickenCaesar.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(IcedTea.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = IcedTea.itmName;
                itm4.quantity = IcedTea.qty;
                itm4.priceOfItem = IcedTea.totburgerPrice;
                amount = amount + IcedTea.totburgerPrice;
                count++;
                itemNames[count] = IcedTea.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(Drpeppr.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = Drpeppr.itmName;
                itm4.quantity = Drpeppr.qty;
                itm4.priceOfItem = Drpeppr.totburgerPrice;
                amount = amount + Drpeppr.totburgerPrice;
                count++;
                itemNames[count] = Drpeppr.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(Frozencoc.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = Frozencoc.itmName;
                itm4.quantity = Frozencoc.qty;
                itm4.priceOfItem = Frozencoc.totburgerPrice;
                amount = amount + Frozencoc.totburgerPrice;
                count++;
                itemNames[count] = Frozencoc.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(CocaCola.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = CocaCola.itmName;
                itm4.quantity = CocaCola.qty;
                itm4.priceOfItem = CocaCola.totburgerPrice;
                amount = amount + CocaCola.totburgerPrice;
                count++;
                itemNames[count] = CocaCola.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(MinuteMaidLemonade.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = MinuteMaidLemonade.itmName;
                itm4.quantity = MinuteMaidLemonade.qty;
                itm4.priceOfItem = MinuteMaidLemonade.totburgerPrice;
                amount = amount + MinuteMaidLemonade.totburgerPrice;
                count++;
                itemNames[count] = MinuteMaidLemonade.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(FrozenFantaICEE.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = FrozenFantaICEE.itmName;
                itm4.quantity = FrozenFantaICEE.qty;
                itm4.priceOfItem = FrozenFantaICEE.totburgerPrice;
                amount = amount + FrozenFantaICEE.totburgerPrice;
                count++;
                itemNames[count] = FrozenFantaICEE.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(CiniMinis.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = CiniMinis.itmName;
                itm4.quantity = CiniMinis.qty;
                itm4.priceOfItem = CiniMinis.totburgerPrice;
                amount = amount + CiniMinis.totburgerPrice;
                count++;
                itemNames[count] = CiniMinis.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(HERSHEY_SSundaePie.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = HERSHEY_SSundaePie.itmName;
                itm4.quantity = HERSHEY_SSundaePie.qty;
                itm4.priceOfItem = HERSHEY_SSundaePie.totburgerPrice;
                amount = amount + HERSHEY_SSundaePie.totburgerPrice;
                count++;
                itemNames[count] = HERSHEY_SSundaePie.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(PiemadewithTWIX.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = PiemadewithTWIX.itmName;
                itm4.quantity = PiemadewithTWIX.qty;
                itm4.priceOfItem = PiemadewithTWIX.totburgerPrice;
                amount = amount + PiemadewithTWIX.totburgerPrice;
                count++;
                itemNames[count] = PiemadewithTWIX.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(Chocolate_Cookie.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = Chocolate_Cookie.itmName;
                itm4.quantity = Chocolate_Cookie.qty;
                itm4.priceOfItem = Chocolate_Cookie.totburgerPrice;
                amount = amount + Chocolate_Cookie.totburgerPrice;
                count++;
                itemNames[count] = Chocolate_Cookie.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(HERSHEY_S_Sundae.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = HERSHEY_S_Sundae.itmName;
                itm4.quantity = HERSHEY_S_Sundae.qty;
                itm4.priceOfItem = HERSHEY_S_Sundae.totburgerPrice;
                amount = amount + HERSHEY_S_Sundae.totburgerPrice;
                count++;
                itemNames[count] = HERSHEY_S_Sundae.itmName;
                myBills.Add(itm4);
            }

            if (!string.IsNullOrEmpty(Dutch_Apple_Pie.itmName))
            {
                BillData itm4 = new BillData();
                itm4.Name = Dutch_Apple_Pie.itmName;
                itm4.quantity = Dutch_Apple_Pie.qty;
                itm4.priceOfItem = Dutch_Apple_Pie.totburgerPrice;
                amount = amount + Dutch_Apple_Pie.totburgerPrice;
                count++;
                itemNames[count] = Dutch_Apple_Pie.itmName;
                myBills.Add(itm4);
            }



            DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void confirmbtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void delete()
        {

            
        }

        private void confirmbtn_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are sure to clear your oder", "Oder list", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    
                    Close();

                    Dutch_Apple_Pie.itmName = "";
                    Dutch_Apple_Pie.qty = 0;
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

                    bill obj = new bill();
                    obj.Show();

                    break;
                case MessageBoxResult.No:
                    break;


            }
        }

        private void menubtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            menucard obj = new menucard();
            obj.Show();

        }

        private void click(object sender, ContextMenuEventArgs e)
        {

        }

        private void bill_load(object sender, RoutedEventArgs e)
        {
            amountbx.Text = Convert.ToString(amount);
        }

        private void confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            if (amount>0)
            {
                for (int x = 0; x <= count; x++)
                {

                    message = message + $"{itemNames[x]}\n";
                }

                if (String.IsNullOrEmpty(DetailPage.cus_email))
                {
                    MessageBox.Show("Your Oder is confiremed Thank you");
                }
                else
                {
                    MessageBox.Show("Your Oder confirm is successful");

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("laknathwijerathne@gmail.com");
                    mail.To.Add($"{DetailPage.cus_email}");
                    mail.Subject = "BURGERX";
                    mail.Body = $"your Oder is confiremd \n {message}\n" +
                    $"Total Amount is RS.{amount}\n  Pay Option:{DetailPage.payoption}  Thank you {DetailPage.cus_name}";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("laknathwijerathne@gmail.com", "Spiderman3#");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Check your mail box for more infore thank you");

                    MailMessage mail2 = new MailMessage();
                    SmtpClient SmtpServer2 = new SmtpClient("smtp.gmail.com");

                    mail2.From = new MailAddress("laknathwijerathne@gmail.com");
                    mail2.To.Add("laknathwijerathne@gmail.com");
                    mail2.Subject = "Odres";
                    mail2.Body = $"Table No:{DetailPage.tableno} \n {message}\n" +
                    $"Total Amount is RS.{amount}\n Pay option:{DetailPage.payoption}  Customer Name:{DetailPage.cus_name}";

                    SmtpServer2.Port = 587;
                    SmtpServer2.Credentials = new System.Net.NetworkCredential("laknathwijerathne@gmail.com", "Spiderman3#");
                    SmtpServer2.EnableSsl = true;

                    SmtpServer.Send(mail2);
                }

            }
            else
            {
                MessageBox.Show("Please Select some Items Before confirm a oder");
            }


        }
    }
}
