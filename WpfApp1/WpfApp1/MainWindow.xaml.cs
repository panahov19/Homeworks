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
using System.Text.Json;

namespace WpfApp1
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

        class Product
        {
            public string Name { get; set; }
            public int Stock { get; set; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var obj = new Product
            {
                Name = "Red Apples",
                Stock = 100,
              
            };
            var jsonString = JsonSerializer.Serialize(obj);
        }
    }
}
