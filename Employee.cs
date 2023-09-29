using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private int experience;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetPositionAndExperience(string position, int experience)
        {
            this.position = position;
            this.experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary = 50000;
            double positionBonus = 0;

            if (position == "Менеджер")
                positionBonus = 10000;
            else if (position == "Розробник")
                positionBonus = 15000;
            else if (position == "Тестувальник")
                positionBonus = 12000;

            double experienceBonus = experience * 1000;

            double salary = baseSalary + positionBonus + experienceBonus;
            return salary;
        }

        public double CalculateTax()
        {
            double salary = CalculateSalary();
            return 0.18 * salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine("Ім'я: " + firstName);
            Console.WriteLine("Прізвище: " + lastName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + CalculateSalary());
            Console.WriteLine("Податковий збір: " + CalculateTax());
        }
    }
}
