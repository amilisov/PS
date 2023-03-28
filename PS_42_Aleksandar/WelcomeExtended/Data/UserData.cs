using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    internal class UserData
    {
        List<User> _users;
        int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            _nextId++;
            user.Id = _nextId;
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password.ToString() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLamda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password.ToString() == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from User in _users
                      where User.Names == name && User.Password.ToString() == password
                      select User;

            return ret != null ? true : false;
        }

        public User? GetUser(string name, string password)
        {
            return _users.FirstOrDefault(x => x.Names == name && x.Password.ToString() == password);
        }

        public void SetActive()
        {

        }
        public void AsssignUserRole(string name, UserRolesEnum role)
        {
            var u = _users.FirstOrDefault(x => x.Names == name);
            if(null == u)
            {
                return;
            }    
            u.Role = role;
        }
    }
}
