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

namespace hmw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double temp = 0;

        public string outPut = "";
        
        public string operation = "";

        public double outputTemp;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {

                case "num0":

                    if (outPut != "0")
                    {
                        outPut += "0";
                    }

                    else
                    {
                        outPut = "0";
                    }

                    Block.Text = outPut;

                    break;

                case "num1":

                    if (outPut == "0")
                    {
                        outPut = "1";
                    }

                    else
                    {
                        outPut += "1";
                    }

                    Block.Text = outPut;

                    break;

                case "num2":

                    if (outPut == "0")
                    {
                        outPut = "2";
                    }

                    else
                    {
                        outPut += "2";
                    }

                    Block.Text = outPut;

                    break;

                case "num3":

                    if (outPut == "0")
                    {
                        outPut = "3";
                    }

                    else
                    {
                        outPut += "3";
                    }

                    Block.Text = outPut;

                    break;

                case "num4":

                    if (outPut == "0")
                    {
                        outPut = "4";
                    }

                    else
                    {
                        outPut += "4";
                    }

                    Block.Text = outPut;

                    break;

                case "num5":

                    if (outPut == "0")
                    {
                        outPut = "5";
                    }

                    else
                    {
                        outPut += "5";
                    }

                    Block.Text = outPut;

                    break;

                case "num6":

                    if (outPut == "0")
                    {
                        outPut = "6";
                    }

                    else
                    {
                        outPut += "6";
                    }

                    Block.Text = outPut;

                    break;

                case "num7":

                    if (outPut == "0")
                    {
                        outPut = "7";
                    }

                    else
                    {
                        outPut += "7";
                    }

                    Block.Text = outPut;

                    break;


                case "num8":

                    if (outPut == "0")
                    {
                        outPut = "8";
                    }

                    else
                    {
                        outPut += "8";
                    }

                    Block.Text = outPut;

                    break;


                case "num9":

                    if (outPut == "0")
                    {
                        outPut = "9";
                    }

                    else
                    {
                        outPut += "9";
                    }

                    Block.Text = outPut;

                    break;



                default:

                    break;
            }

        }



        private void dvd_btn_Click(object sender, RoutedEventArgs e)
        {
            if (outPut != "")
            {
                temp = double.Parse(outPut);
                outPut = "";
                operation = "Division";

            }
        }


        private void mult_btn_Click(object sender, RoutedEventArgs e)
        {
            if (outPut != "")
            {
                temp = double.Parse(outPut);
                outPut = "";
                operation = "Multiplication";

            }
        }




        private void subt_btn_Click(object sender, RoutedEventArgs e)
        {
            if (outPut != "")
            {
                temp = double.Parse(outPut);
                outPut = "";
                operation = "Subtraction";

            }
        }


        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (outPut != "")
            {
                temp = double.Parse(outPut);
                outPut = "";
                operation = "Addition";

            }
        }


        private void AC_btn_Click(object sender, RoutedEventArgs e)
        {
            outputTemp = 0;
            outPut = outputTemp.ToString();
            Block.Text = outPut;
        }

        private void equ_btn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {

                case "Division":

                    outputTemp = temp / double.Parse(outPut);

                    outPut = outputTemp.ToString();

                    Block.Text = outPut;

                    break;


                case "Multiplication":

                     outputTemp = temp * double.Parse(outPut);

                    outPut = outputTemp.ToString();

                    Block.Text = outPut;

                    break;


                case "Subtraction":

                    outputTemp = temp - double.Parse(outPut);

                    outPut = outputTemp.ToString();

                    Block.Text = outPut;

                    break;


                case "Addition":

                    outputTemp = temp + double.Parse(outPut);

                    outPut = outputTemp.ToString();

                    Block.Text = outPut;

                    break;





                default:
                    break;
            }
        }

    }
}
