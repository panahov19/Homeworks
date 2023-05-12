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
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Windows.Forms;




namespace Kassa
{
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public List<string> oilType = new List<string> { "АИ-92" , "АИ-95" , "АИ-98" };
        public List<string> product_quantity = new List<string> { };


        private float _oil_showbox;
        public float oil_showbox 
        {
            get
            {
                return _oil_showbox;
            }
            
            set
            {
                _oil_showbox = value;
                NotifyPropertyChanged("oil_showbox");
            }
        }



        private float _amount_box = 0;
        public float amount_box
        {
            get
            {
                return _amount_box;
            }

            set
            {
                _amount_box = value;
                NotifyPropertyChanged("amount_box");
            }
        }

        private float _quantity_box = 0;
        public float quantity_box
        {
            get
            {
                return _quantity_box;
            }

            set
            {
                _quantity_box = value;
                NotifyPropertyChanged("quantity_box");
            }
        }



        private float _total_oil_amnt = 0;
        public float total_oil_amnt
        {
            get
            {
                return _total_oil_amnt;
            }

            set
            {
                _total_oil_amnt = value;
                NotifyPropertyChanged("total_oil_amnt");
            }
        }


        private float _total_amount = 0;
        public float total_amount
        {
            get
            {
                return _total_amount;
            }

            set
            {
               _total_amount = value;
                NotifyPropertyChanged("total_amount");
            }
        }


        private float _total_cafe_amount = 0;
        public float total_cafe_amount
        {
            get
            {
                return _total_cafe_amount;
            }

            set
            {
                _total_cafe_amount = value;
                NotifyPropertyChanged("total_cafe_amount");
            }
        }

        public float hotdog_temp;
        public float hamburger_temp;
        public float fries_temp;
        public float cola_temp;
        public string total = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string propertyname = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }




        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            oil_box.ItemsSource = oilType;
           
            
            

            for (int i = 1; i < 100; i++)
            {
                product_quantity.Add(i.ToString());
            }

            hotdog_box.ItemsSource = product_quantity;
            hamburger_box.ItemsSource = product_quantity;
            fries_box.ItemsSource = product_quantity;
            cola_box.ItemsSource = product_quantity;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(oil_box.SelectedIndex == 0)
            {
                oil_showbox = 1;
            }

            else if (oil_box.SelectedIndex == 1)
            {
                oil_showbox = 2;
            }

            else if (oil_box.SelectedIndex == 2)
            {
                oil_showbox = 3;
            }

            quantity_textbox.Text = "" ;
            quantity_textbox.IsEnabled = false;
            quantity_btn.IsChecked = false;

            amount_textbox.Text = "";
            amount_textbox.IsEnabled = false;
            amount_btn.IsChecked = false;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*[.][0-9]*$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void quantity_box_TextChanged(object sender, TextChangedEventArgs e)
        {
       

            if (quantity_btn.IsEnabled)
            {
                quantity_textbox.IsReadOnly = false;

               try
                {
                    total_oil_amnt = quantity_box * oil_showbox;
                    amount_box =     quantity_box * oil_showbox;
                    total_amount =  total_cafe_amount + total_oil_amnt;
                }

                catch
                {
                    total_amount = 0;
                    quantity_box = 0;
                    amount_box   = 0;
                } 
            }
        }

        private void amount_box_TextChanged(object sender, TextChangedEventArgs e)
        {
        

            if (amount_btn.IsEnabled)
            {
                amount_textbox.IsReadOnly = false;

                if (amount_box != 0)
                {
                    try
                    {
                        quantity_box = amount_box / oil_showbox;
                        total_oil_amnt = amount_box;
                        total_amount = total_oil_amnt + total_cafe_amount ;
                    }

                    catch 
                    {
                        total_amount = 0;
                        quantity_box = 0;
                        amount_box = 0;
                    }
                }    
            }
        }

        private void quantity_btn_Checked(object sender, RoutedEventArgs e)
        {
           
            
            quantity_textbox.IsEnabled = true;

            amount_textbox.IsEnabled = false;


        }

        private void amount_btn_Checked(object sender, RoutedEventArgs e)
        {
            
           
            amount_textbox.IsEnabled = true;

            quantity_textbox.IsEnabled = false;
           
            
        }


        private void quantity_textbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            quantity_textbox.Text = "";
        }

        private void amount_textbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            amount_textbox.Text = "";
        }




        private void hotdog_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                hotdog_temp = float.Parse(hotdog_box.Text) * float.Parse(hotdog_price_box.Text);
                hotdog_box.IsEnabled = false;

                total_cafe_amount = total_cafe_amount +  (float.Parse(hotdog_box.Text) * float.Parse(hotdog_price_box.Text));
                total_amount = total_oil_amnt + total_cafe_amount;
                hotdog_box.Text = "";
            }

            catch
            {
                hotdog_box.ItemsSource = product_quantity;
            }
        }



        private void hotdog_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            total_cafe_amount = total_cafe_amount - hotdog_temp;
            total_amount = total_oil_amnt + total_cafe_amount;
            hotdog_box.IsEnabled = true;
            hotdog_temp = 0;
        }





        private void hamburger_btn_Checked(object sender, RoutedEventArgs e)
        {

            try
            {
                hamburger_temp = float.Parse(hamburger_box.Text) * float.Parse(hamburger_price_box.Text);
                hamburger_box.IsEnabled = false;

                total_cafe_amount = total_cafe_amount + (float.Parse(hamburger_box.Text) * float.Parse(hamburger_price_box.Text));
                total_amount = total_oil_amnt + total_cafe_amount;
                hamburger_box.Text = "";
            }

            catch
            {
                hamburger_box.ItemsSource = product_quantity;
            }
        }


        private void hamburger_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            total_cafe_amount = total_cafe_amount - hamburger_temp;
            total_amount = total_oil_amnt + total_cafe_amount;
            hamburger_box.IsEnabled = true;
            hamburger_temp = 0;
        }




        private void fries_btn_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                fries_temp = float.Parse(fries_box.Text) * float.Parse(fries_price_box.Text);
                fries_box.IsEnabled = false;

                total_cafe_amount = total_cafe_amount + (float.Parse(fries_box.Text) * float.Parse(fries_price_box.Text));
                total_amount = total_oil_amnt + total_cafe_amount;
                fries_box.Text = "";
            }

            catch
            {
               
                fries_box.ItemsSource = product_quantity;
            }
        }


        private void fries_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            total_cafe_amount =total_cafe_amount - fries_temp;
            total_amount = total_oil_amnt + total_cafe_amount;
            fries_box.IsEnabled= true;
            fries_temp = 0;
        }




        private void cola_btn_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                cola_temp = float.Parse(cola_box.Text) * float.Parse(cola_price_box.Text);
                cola_box.IsEnabled = false;

                total_cafe_amount = total_cafe_amount + (float.Parse(cola_box.Text) * float.Parse(cola_price_box.Text));
                total_amount = total_oil_amnt + total_cafe_amount;
                cola_box.Text = "";
            }

            catch
            {
                cola_box.ItemsSource = product_quantity;
            }
        }

        private void cola_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            total_cafe_amount = total_cafe_amount - cola_temp;
            total_amount = total_oil_amnt + total_cafe_amount;
            cola_box.IsEnabled= true;
            cola_temp = 0;
        }

        private void pay_btn (object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Оплачено :)");
            App.Current.Shutdown();
            System.Windows.Forms.Application.Restart();
            
        }
    }
}
