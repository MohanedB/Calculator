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

namespace Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string message = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double result = 0.0;
         enum SelectedOperator
        {
            Divide,Multi,Substract,Add
        }
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void Numbers_Click(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            switch (b.Name)
            {
                case "Zero":
                  Screen.Content = "";
                    message += "0";
                  Screen.Content += message;
                  
                    break;
                case "One":
                  Screen.Content = "";
                    message += "1";
                  Screen.Content += message;
           
                    break;
                case "Two":
                  Screen.Content = "";
                    message += "2";
                  Screen.Content += message;
             
                    break;
                case "Three":
                  Screen.Content = "";
                    message += "3";
                  Screen.Content += message;
                 
                    break;
                case "Four":
                  Screen.Content = "";
                    message += "4";
                  Screen.Content += message;
               
                    break;
                case "Five":
                  Screen.Content = "";
                    message += "5";
                  Screen.Content += message;
                 
                    break;
                case "Six":
                  Screen.Content = "";
                    message += "6";
                  Screen.Content += message;
                  
                    break;
                case "Seven":
                  Screen.Content = "";
                  message += "7";
                  Screen.Content += message;
                 
                    break;
                case "Eight":
                    Screen.Content = "";
                    message += "8";
                  Screen.Content += message;
                   
                    break;
                case "Nine":
                   Screen.Content= "";
                    message += "9";
                    Screen.Content += message;
                    
                    break;
                default:
                 
                    break;               
            }
            
        }
        
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            Screen.Content = " ";
            text1.Text = " ";
            message = string.Empty;
            num1 = string.Empty;
            num2 = string.Empty;
        
        }

        private void Plusminus_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse((string)Screen.Content, out double number);

            message = (-number).ToString();

            Screen.Content = message;
          
        }

     

        private void Pourcentage_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse((string)Screen.Content, out double number);

          message = (number / 100).ToString();

            Screen.Content = message;

           
           
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
          
            if (!message.Contains(".")){ 
             message+= ".";
        }
            Screen.Content = message;

    }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            switch (b.Name){

                case "Divide":
                    num1 = message;
                    operation = '/';
                    message = string.Empty;              
                    break;
                case "Multiply":
                    num1 = message;
                    operation = '*';
                    message = string.Empty;
                    break;
                case "Add":
                    num1 = message;
                    operation = '+';
                    message = string.Empty;
                    break;
                case "Minus":
                    num1 = message;
                    operation = '-';
                    message = string.Empty;
                    break;
            }
        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = message;
            double number1;
            double number2;
            Double.TryParse(num1, out number1);
            Double.TryParse(num2, out number2);

            if (operation == '+')
            {
                result = number1 + number2;
                Screen.Content = result.ToString();
            }
            else if (operation == '-')
            {
                result =number1-number2;
               Screen.Content = result.ToString();
            }
            else if (operation == '*')
            {
                result = number1 * number2;
               Screen.Content = result.ToString();
            }
            else if (operation == '/')
            {
                if (number2!=0)
                {
                    result = number1 / number2;
                   Screen.Content = result.ToString();
                }
                else
                {
                    MessageBox.Show("DIV/Zero!");
                }

            }

        }

  
    }
}
