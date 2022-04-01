using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29.Models
{
    class User:IAccount
    {
        private int _id { get; set; }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password, int id, string fullname):this()
        {
            Id = id;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public User()
        {
            Id = 0;
        }
        public User(int Id)
        {
            _id++;
            Id = _id;
        }

        public User(string v1, string v2)
        {
        }

        public bool PasswordChecker()
        {
            if (Password.Length>=8 && string.IsNullOrEmpty(Password) && string.IsNullOrWhiteSpace(Password))
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;
                foreach (var item in Password)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        isLower = true;
                    }
                    if (isDigit && isUpper && isLower )
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Fullname:{Fullname} Email:{Email}");
        }
    }
}
