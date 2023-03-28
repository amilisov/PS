using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string Names { get; set; }
        public PasswordClass Password { get; set; }
        public UserRolesEnum Role { get; set; }
        public int Id { get; set; }
        public MailAddress Email { get; set; }

        public User(string names, PasswordClass password, UserRolesEnum role, int id, MailAddress email)
        {
            Names = names;
            Password = password;
            Role = role;
            Id = id;
            Email = email;
        }
        public override string ToString()
        {
            return Names;
        }
    }
}
