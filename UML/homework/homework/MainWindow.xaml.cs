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
using System.Text.Json.Serialization;


namespace homework
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using FileStream fs = new("person.json", FileMode.Truncate);
        }

        public class Person
        {
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public Int32 Age { get; set; }

            public Person()
            {

            }
        }

        List<Person>? person_list = new();

        private  void save_btn_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();

            int error = 0;

            try
            {
                person.Name = name_txt.Text;
                person.Surname = surname_txt.Text;
                person.Age = Int32.Parse(age_txt.Text);

            }
            catch (Exception)
            {
;               MessageBox.Show("Error! be serious !!");
                error = 1;
              
            }
            

           if(error == 0)
            {
                var length = File.ReadAllText("person.json");

                using FileStream fs = new("person.json", FileMode.Truncate);
                using StreamReader sr = new(fs);
                using StreamWriter sw = new(fs);

                var json = sr.ReadToEnd();

                if (length.Length > 1)
                {
                    person_list = JsonSerializer.Deserialize<List<Person>>(length);
                }

                person_list.Add(person);
                json = JsonSerializer.Serialize<List<Person>>(person_list);
                sw.Write(json);

                PersonListbox.Items.Add(person.Name);

                name_txt.Clear();
                surname_txt.Clear();
                age_txt.Clear();

            }

            else
            {
               
            }

        }

        private  void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            var search = person_list.Find(x => x.Name == PersonListbox.SelectedItem.ToString());

            name_txt.Text = search.Name;
            surname_txt.Text = search.Surname;
            age_txt.Text = search.Age.ToString();

            var length = File.ReadAllText("person.json");

            using FileStream fs = new("person.json", FileMode.Truncate);
            using StreamReader sr = new(fs);
            using StreamWriter sw = new(fs);

            var json = sr.ReadToEnd();

            if (length.Length > 1)
            {
                person_list = JsonSerializer.Deserialize<List<Person>>(length);
            }

            person_list.Remove(person_list.Find(x => x.Name == PersonListbox.SelectedItem.ToString()));

            PersonListbox.Items.Remove(PersonListbox.SelectedItem);
            json = JsonSerializer.Serialize<List<Person>>(person_list);
            sw.Write(json);

        }


        private void del_btn_Click(object sender, RoutedEventArgs e)
        {
            var length = File.ReadAllText("person.json");

            using FileStream fs = new("person.json", FileMode.Truncate);
            using StreamReader sr = new(fs);
            using StreamWriter sw = new(fs);

            var json = sr.ReadToEnd();

            if (length.Length > 1)
            {
                person_list = JsonSerializer.Deserialize<List<Person>>(length);
            }

            person_list.Remove(person_list.Find(x => x.Name == PersonListbox.SelectedItem.ToString()));

            PersonListbox.Items.Remove(PersonListbox.SelectedItem);
            json = JsonSerializer.Serialize<List<Person>>(person_list);
            sw.Write(json);
        }


        private void name_txt_TextChanged(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Foreground == Brushes.Gray)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).Foreground = Brushes.Black;
                }
            }
        }


        private void name_txt_Changed(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Text.Trim().Equals(""))
                {
                    ((TextBox)sender).Foreground = Brushes.Gray;
                    ((TextBox)sender).Text = "Name";
                }
            }
        }

        private void surname_txt_TextChanged(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Foreground == Brushes.Gray)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).Foreground = Brushes.Black;
                }
            }
        }


        private void surname_txt_Changed(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Text.Trim().Equals(""))
                {
                    ((TextBox)sender).Foreground = Brushes.Gray;
                    ((TextBox)sender).Text = "Surname";
                }
            }


        }


        private void age_txt_TextChanged(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Foreground == Brushes.Gray)
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).Foreground = Brushes.Black;
                }
            }
        }

        private void age_txt_Changed(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Text.Trim().Equals(""))
                {
                    ((TextBox)sender).Foreground = Brushes.Gray;
                    ((TextBox)sender).Text = "Age";
                }
            }
        }

     
    }

}
