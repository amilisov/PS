using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        User _user;


        public string Names
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }
        public PasswordClass Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }
        public string Id
        {
            get { return _user.Id; }
            set { _user.Id = value; }
        }
        public MailAddress Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }

        public UserViewModel(User user)
        {
            _user = user;
        }   
    }
}
