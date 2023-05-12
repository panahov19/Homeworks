using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZooShopClient.Model;

namespace ZooShopClient
{
    internal class RegisterService
    {
        Regex nsRegex = new("[A-Za-z]");

        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public bool CheckRegistration(UserModel user)
        {
            if (nsRegex.IsMatch(user.Name) && nsRegex.IsMatch(user.Surname))
            {
                return true;
            }

            return false;
        }

        public bool CheckEmail(UserModel user)
        {
            if (emailRegex.IsMatch(user.eMail))
            {
                return true;
            }

            return false;
        }





    }
}
