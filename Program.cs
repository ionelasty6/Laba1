using Laba1;

class Program
{
    static void Main()
    {
        // Створення екземпляру класу Address
        Address address = new Address();
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вулиця Хрещатик";
        address.House = "1";
        address.Apartment = "10";

        // Виведення інформації про адресу
        address.PrintAddress();

        // Створення екземпляру класу Converter з курсами валют
        Converter converter = new Converter(36.5, 39.5, 8.5);

        // Конвертація гривні в USD та назад
        double uahAmount = 1000.0;
        double usdAmount = converter.ConvertToUSD(uahAmount);
        double uahConverted = converter.ConvertFromUSD(usdAmount);
        Console.WriteLine($"{uahAmount} UAH = {usdAmount} USD");
        Console.WriteLine($"{usdAmount} USD = {uahConverted} UAH");

        // Створення екземпляру класу Employee
        Employee employee = new Employee("Петров", "Іван");
        employee.SetPositionAndExperience("Розробник", 5);

        // Виведення інформації про співробітника
        employee.PrintEmployeeInfo();

        // Створення екземпляру класу User
        User user = new User("user123", "Юрій", "Ковальов");
        user.Age = 30;

        // Виведення інформації про користувача
        user.PrintUserInfo();

        Console.ReadLine();
    }
}