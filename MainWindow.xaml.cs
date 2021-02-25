using System;
using System.Collections.Generic;
using System.ComponentModel;
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
      
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "0";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "9";
        }

        private void BtnDiv_Click_1(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "/";
        }

        private void BtnMult_Click_1(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "*";
        }

        private void BtnSub_Click_1(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "-";
        }

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + "+";
        }

        private void BtnEqu_Click_1(object sender, RoutedEventArgs e)
        {
            if (Disp.Text!="")
            {
                Type type = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
                dynamic obj = Activator.CreateInstance(type, false);
                obj.Language = "javascript";
                string str = null;
                try
                {
                    var result = obj.Eval(Disp.Text);
                    str = Convert.ToString(result);
                    Disp.Text = Disp.Text + "=" + str;
                }
                catch (SystemException)
                {
                    Disp.Text = "Error";
                }
            }
            
            
        }

        

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = "";
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {
            double num;
            var isDouble = double.TryParse(this.Disp.Text, out num);
            if (isDouble)
            {
                this.Disp.Text =
                    string.Format(
                        "{0}{1} = {2}",
                        "\u221A",
                        this.Disp.Text,
                        Math.Round(Math.Sqrt(num), 2));
            }
        }

        private void BtnPlusNeg_Click_1(object sender, RoutedEventArgs e)
        {

            Disp.Text = "-" + Disp.Text;
        }

        private void BtnDec_Click(object sender, RoutedEventArgs e)
        {
            Disp.Text = Disp.Text + ".";
        }
    }
}
