using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    abstract class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        public User(string login, string password, string firstName, string secondName, string thirdName, string mail, string phoneNumber)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Mail = mail;
            PhoneNumber = phoneNumber;
        }
    }
}
