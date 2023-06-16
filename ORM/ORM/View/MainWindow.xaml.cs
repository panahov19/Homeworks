using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using ORM.Data.Model;
using ORM.Data.Contexts;
using System.Data.SqlClient;


namespace ORM
{    public partial class MainWindow : Window
    {
        public List<Country> MyCountries { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            using (CountryDbContext _context = new CountryDbContext())
            {
                MyCountries =  _context.Countries.ToList();
            }

            CountriesList.ItemsSource = MyCountries;
        }
    }
}
