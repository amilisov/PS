using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome.Others
{
    public class PasswordClass
    {
        private string _password;
        private int _key;
        public PasswordClass(string password, int key)
        {
            _password = password;
            _key = key;
            Encrypt();
        }

        void Encrypt()
        {
            char[] chars = new char[_password.Length];

            for(int i = 0; i < _password.Length; i++)
            {
                chars[i] = (char)(_password[i] + _key);
            }
            _password = new string(chars);
        }

        public string? Decrypt(int key)
        {
            if (key != _key)
            {
                return null;
            }
            char[] chars = new char[_password.Length];

            for (int i = 0; i < _password.Length; i++)
            {
                chars[i] = (char)(_password[i] - _key);
            }
            return new string(chars);
        }
    }
}
