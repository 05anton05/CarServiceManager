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
            Console.WriteLine("Доброго дня. Я механiк Антон - бачу вашому автомобiлю погано, давайте допоможу!" + "\n Ваше им'я:");
               var clientInfo = new Client { Name = "Михайло", PhoneNumber = "380******"};
            Console.WriteLine($"Клiєнт: {clientInfo.Name}, Телефон: {clientInfo.PhoneNumber}");
            var clientsCar = new Car { Make = "Nissan", Model = "Rogue", Color = Color.Black, PlateNumber = "AX7777XA", Year = 2019 };
            Console.WriteLine("Розкажiть про автомобiль!");
            Console.WriteLine($"Автомобiль клiєнта: {clientsCar.Make} {clientsCar.Model} {clientsCar.Year} {clientsCar.Color.Name}");
            Console.WriteLine("Опишiть проблему:");
            var problemDescription = "Замок дверi не працює";
            Console.WriteLine($"Проблема: {problemDescription}, \n Авто: {clientsCar.Make}, {clientsCar.Model}, {clientsCar.Year}, {clientsCar.PlateNumber}, \n Прийнятий: {DateTime.Now},  ");
             break;
            

            

    }
}