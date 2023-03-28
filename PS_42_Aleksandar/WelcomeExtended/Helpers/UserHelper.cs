using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        static UserData data;

        static UserHelper()
        {
            data = new UserData();
        }


        public static string ToString(User user)
        {
            return user.ToString();
        }

        public static User? GetUser(string name, string password) 
        {
            return data.GetUser(name, password);
        }

        public static bool ValidateCredentials(string name, string password)
        {
            if(name == null)
            {
                throw new ArgumentException("The name cannot be empty");
            }
            if (password == null)
            {
                throw new ArgumentException("The password cannot be empty");
            }
            return data.ValidateUser(name, password);
        }
    }
}
