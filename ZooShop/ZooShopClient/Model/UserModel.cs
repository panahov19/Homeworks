using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShopClient.Model
{

    public enum Gender
    {
        Male = 0,
        Female = 1
    };

    public class UserModel
    {
        Random random = new Random();
        public string? Name { get; set; }
        public string? Surname { get; set; }

        private int age;
        public int Age 
        {
            get => age;
            set
            {
                if (value > 0 && value <= 99)
                {
                    age = value;
                }


                else
                {
                    throw new Exception("Something went wrong :( ");
                }
            }
        }

        public Gender Gender { get; set; }
        public string Username 
        {
            get => Username;

            private set { Name = Name + random.Next(1, 99); }
        }
            
        public string? eMail { get; set; }    

       

    }
}
