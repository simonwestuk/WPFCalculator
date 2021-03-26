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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Result { get; set; }
        public char Sign { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "9";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "6";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "3";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + "0";
        }

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = lblResult.Content + ".";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Result = Convert.ToDouble(lblResult.Content);
            Sign = '+';
            lblResult.Content = String.Empty;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            Double temp = Convert.ToDouble(lblResult.Content);

            switch (Sign)
            {
                case '+':
                    Result = temp + Result;
                    break;

            }

            lblResult.Content = Result.ToString();
        }
    }
}
