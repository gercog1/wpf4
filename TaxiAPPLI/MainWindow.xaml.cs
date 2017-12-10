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
using System.IO;

namespace TaxiAPPLI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        double priceS = Math.Round(GetRandomNumber(0, 100),2);


        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (phoneNumber.Text== "Enter phone number" || from.Text== "Enter from point" || to.Text== "Enter destination point")
            {
                warning1.Content = "Fill all fields.";
            }
            else if(!BuisnessLogic.checkPhoneNumber(phoneNumber.Text))
            {
                
                warning1.Content = "Number should look like: " + Environment.NewLine + "0XXXXXXXXX";
            }
            else
            {
                afterOrder.Content = "";
                warning1.Content = "";
                orderBtn.Visibility = Visibility.Visible;
                phone.Content = "Your phone number: " + phoneNumber.Text;
                fromp.Content = "From: " + from.Text;
                top.Content = "To: " + to.Text;
                typep.Content = "Type of car: " + type.Text;
                
                price.Content = "Price: " + priceS + " $";
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.GetFullPath("Orders.txt");
            Order order = new Order(phoneNumber.Text.ToString(), from.Text.ToString(), to.Text.ToString(), priceS, type.Text.ToString());
            Order.WriteToFile(path, order);
            orderBtn.Visibility = Visibility.Hidden;
            phone.Content = "";
            fromp.Content = "";
            top.Content = "";
            typep.Content = "";

            
            
            afterOrder.Content = "SMS with more detailed"+  Environment.NewLine + "information will be sent"+ Environment.NewLine+ "on your phone number:"+ Environment.NewLine+ "+38" + phoneNumber.Text;
            
            price.Content = "";
            phoneNumber.Text = "Enter phone number";
            from.Text = "Enter from point";
            to.Text = "Enter destination point";

            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void phoneNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter phone number")
            {
                tb.Text = "";
                tb.Foreground = Brushes.Gray;
            }
        }

      

        private void to_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter destination point")
            {
                tb.Text = "";
                tb.Foreground = Brushes.Gray;
            }
        }

        private void from_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter from point")
            {
                tb.Text = "";
                tb.Foreground = Brushes.Gray;
            }
        }

        private void phoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Enter phone number";
                tb.Foreground = Brushes.Gray;
            }
        }

        private void from_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Enter from point";
                tb.Foreground = Brushes.Gray;
            }
        }

        private void to_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Enter destination point";
                tb.Foreground = Brushes.Gray;
            }
        }

        
    }
}
