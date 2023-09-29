using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class User
    {
        public string Login { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            RegistrationDate = DateTime.Now;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine("Логін: " + Login);
            Console.WriteLine("Ім'я: " + FirstName);
            Console.WriteLine("Прізвище: " + LastName);
            Console.WriteLine("Вік: " + Age);
            Console.WriteLine("Дата реєстрації: " + RegistrationDate.ToString("dd.MM.yyyy HH:mm:ss"));
        }
    }
}
