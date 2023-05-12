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
using ZooShopAdmin.Model;
using static ZooShopAdmin.Model.CategoriesModel;
using ZooShopClient.Model;



namespace ZooShopClient.View
{

    public partial class MainView : UserControl
    {

        ImageSourceConverter? imgConv = new ImageSourceConverter();

        public MainView()
        {
            Products.Add_Default_Products();
            Categories.Add_Default_Categories();
            
            InitializeComponent();
        }


        private void Sign_in_btn_Click(object sender, RoutedEventArgs e)
        {
          
            
        }

           

        private void Categories_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Products_box.SelectedIndex = -1;

            if (Categories_box.SelectedItem != null)
            {

                Category? select = ZooShopAdmin.Model.CategoriesModel.Categories.Categories_list.Find(i => i.Name == Categories_box.SelectedItem);

                Products_box.ItemsSource = select.Products_list_names;

            }
           
        }
        
        private void Categories_box_Loaded(object sender , RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = ZooShopAdmin.Model.CategoriesModel.Categories.Categories_list_names;

        }


        private void Products_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Categories_box.SelectedItem != null)
            {
                Category? select = ZooShopAdmin.Model.CategoriesModel.Categories.Categories_list.Find(i => i.Name == Categories_box.SelectedItem);
                var combo = sender as ComboBox;
                combo.ItemsSource = select.Products_list_names;

                Logo.Source = (ImageSource)imgConv.ConvertFromString($"C:\\Users\\Mamed\\source\\repos\\ZooShop\\ZooShopAdmin\\Images\\{Products_box.SelectedItem}.png");

            }
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Cart_box.Items.Add(Categories_box.SelectedItem + " - " + Products_box.SelectedItem + "  ");

        }

        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {
            Cart_box.Items.Remove (Cart_box.SelectedItem);
        }

        private void Products_box_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

}








