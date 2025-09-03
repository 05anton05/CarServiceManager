// See https://aka.ms/new-console-template for more information
using CarServiceManager;
using System.Drawing;

Console.WriteLine("Hello, World!");
static void PrintMenu()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine(Environment.NewLine + "");
    Console.WriteLine(" 1 - Додати клієнта");
    Console.WriteLine(" 2 - Додати авто клієнту");
    Console.WriteLine(" 3 - Список клієнтів");
    Console.WriteLine(" 4 - Cтоврити замовлення ");
    Console.WriteLine(" 5 - Вийти");
    

}
bool isContinueWork = true;
while (isContinueWork)
{

    PrintMenu();
    int userChoice = int.Parse(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            var car = new Car { Make = "Nissan", Model = "Rogue", Color = Color.Black, PlateNumber = "AX7777XA", Year = 2019 };
            var client = new Client();
            client.Name = "Misha";
            client.PhoneNumber = "068********";
            client.Cars.Add(car);

            var mishasCar = client.Cars.First();
            Console.WriteLine($"Автомобiль клiєнта: {client.Name} Привiз на ремонт: {mishasCar.Make} { mishasCar.Model} {mishasCar.Year} {mishasCar.Color.Name}"  );

            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Введiть iм'я");
            var nameOfClient = Console.ReadLine();
            Console.WriteLine("Введiть номер телефону");
            var phone = Console.ReadLine();
            var newClient = new Client { Name = nameOfClient, PhoneNumber = phone };
            Console.WriteLine($"Новий клiєнт: {newClient.Name} Телефон: {newClient.PhoneNumber}");
            Console.WriteLine("Введiть марку авто");
            var make = Console.ReadLine();
            Console.WriteLine("Введiть модель авто");
            var model = Console.ReadLine();
            Console.WriteLine("Введiть рiк випуску авто");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть колiр авто");
            var color = Console.ReadLine();
            var carOfClient = new Car { Make = make, Model = model, Year = year, Color = Color.FromName(color)};
            Console.WriteLine("Введiть бажану процедуру");
            var description = Console.ReadLine();
            Console.WriteLine($"Отриманно замовлення вiд {newClient.Name}, Телефон:{newClient.PhoneNumber}");
            

            break;

    }
}