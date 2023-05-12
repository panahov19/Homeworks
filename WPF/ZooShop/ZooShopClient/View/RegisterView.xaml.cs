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
using System.Net;
using System.Net.Mail;
using ZooShopClient.Model;
using System.IO;
using System.Text.Json;

namespace ZooShopClient.View
{
    /// <summary>
    /// Логика взаимодействия для RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        public UserModel User { get; set; } = new();
        private RegisterService register_service = new();

        public List<UserModel> Users { get; set; }
        public RegisterView()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {

            bool check = register_service.CheckRegistration(User);

            if(check)
            {
                using FileStream fs = new("data.json", FileMode.OpenOrCreate);
                using StreamReader sr = new(fs);
                using StreamWriter sw = new(fs);
                var json = sr.ReadToEnd();

                if(!String.IsNullOrEmpty(json))
                {
                    Users = JsonSerializer.Deserialize<List<UserModel>>(json);
                    Users.Add(User);
                }

                var newJson = JsonSerializer.Serialize(Users);
                sw.Write(newJson);

            }




            //Random rnd = new Random();

            //string name = $"Welcome too ZooShop your login is {surname_txt.Text + rnd.Next(1,99)}";
            
            

            //string fromMail = "zooshop2023@gmail.com";
            //string fromPassword = "iewohjiuaxbzhepd";

            //MailMessage message = new MailMessage();
            //message.From = new MailAddress(fromMail);
            //message.Subject = "Registration";
            //message.To.Add(new MailAddress($"{email_txt.Text}"));
            //message.Body = $"<html><body> {name}   </body> </html>";
            //message.IsBodyHtml = true;

            //var smtpClient = new SmtpClient("smtp.gmail.com")
            //{
            //    Port = 587,
            //    Credentials = new NetworkCredential(fromMail, fromPassword),
            //    EnableSsl = true,
            //};

            //smtpClient.Send(message);
        }
    }
}
