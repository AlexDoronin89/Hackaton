using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETP.Model
{
    class Purchaser : User
    {
        public Order order { get; set; }
        public Purchaser(string login, string password, string firstName, string secondName, string thirdName, string mail, string phoneNumber)
            : base(login, password, firstName, secondName, thirdName, mail, phoneNumber)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Mail = mail;
        }
    }
}
