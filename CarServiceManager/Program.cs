// See https://aka.ms/new-console-template for more information
using CarServiceManager;
using System.Drawing;
using System.Linq;
using System.Reflection;

static void PrintMenu()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine(Environment.NewLine + "");
    Console.WriteLine(" 1 - Додати клієнта");
    Console.WriteLine(" 2 - Додати авто клієнту");
    Console.WriteLine(" 3 - Список клієнтів");
    Console.WriteLine(" 4 - Cтоврити замовлення ");
    Console.WriteLine(" 5 - Переглянути  всi замовлення ");
    Console.WriteLine(" 6 - Фільтр по статусу");
    Console.WriteLine(" 7 - Пошук клієнта за номером телефону");

}

var orders = new List<ServiceOrder>();
var cars = new List<Car>();
var clients = new List<Client>();

bool isContinueWork = true;
void RepeatMenu()
{


    PrintMenu();
    int userChoice = int.Parse(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Доброго дня, введiть ваше iм'я:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Введiть номер телефону:");
            string firstNumber = Console.ReadLine();
            var client = new Client { Name = firstName, PhoneNumber = firstNumber };
            clients.Add(client);

            Console.WriteLine($"Вiтаю!\n Ваше iм'я: {firstName}\n Ваш номер телефону: {firstNumber}");

            break;
        case 2:
            Console.WriteLine("Продвожимо... Пропишiть марку авто:");
            string firstModel = Console.ReadLine();

            Console.WriteLine("Тепер потрiбен держ-номер:");
            var firstPlateNumber = Console.ReadLine();

            Console.WriteLine("Модель:");
            string firstMake = Console.ReadLine();

            Console.WriteLine("Рiк випуску:");
            int yearOfCar = int.Parse(Console.ReadLine());

            Console.WriteLine("Колiр:");
            string colorOfCar = Console.ReadLine();

            var firsCar = new Car
            {
                Model = firstModel,
                PlateNumber = firstPlateNumber,
                Make = firstMake,
                Year = yearOfCar,
                Color = colorOfCar
            };


            Console.WriteLine($"Автомобiль зафiксовано. Даннi для перевiрки: \nМарка: {firstModel} \nДерж-номер{firstPlateNumber} \nМодель: {firstMake} \nРiк: {yearOfCar} \nКолiр: {colorOfCar}");
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Доброго дня. Я механiк Антон - бачу вашому автомобiлю погано, давайте допоможу!" + "\n Ваше им'я:");
            var clientInfo = new Client { Name = "Михайло", PhoneNumber = "380******" };

            Console.WriteLine($"Клiєнт: {clientInfo.Name}, Телефон: {clientInfo.PhoneNumber}");
            var clientsCar = new Car { Make = "Nissan", Model = "Rogue", Color = "Black", PlateNumber = "AX7777XA", Year = 2019 };

            Console.WriteLine("Розкажiть про автомобiль!");
            Console.WriteLine($"Автомобiль клiєнта: {clientsCar.Make} {clientsCar.Model} {clientsCar.Year} {clientsCar.Color}");
            Console.WriteLine("Опишiть проблему:");
            var problemDescription = "Замок дверi не працює";

            Console.WriteLine($"Проблема: {problemDescription}, \n Авто: {clientsCar.Make}, {clientsCar.Model}, {clientsCar.Year}, {clientsCar.PlateNumber}, \n Прийнятий: {DateTime.Now}");
            string status = "Виконано";

            Console.WriteLine(status);
            var order = new ServiceOrder
            {
                Car = clientsCar,
                Description = problemDescription,
                Date = DateTime.Now,
                Status = status,
            };
            orders.Add(order);
            break;
        case 5:
            Console.WriteLine("Список актуальних замовлень:");
            foreach (var clientOrder in orders)
            {
                Console.WriteLine($"Авто: {clientOrder.Car.Make} {clientOrder.Car.Model}, Проблема: {clientOrder.Description}, Статус: {clientOrder.Status} ");
            }
            break;
        case 6:
            Console.WriteLine("Пропишить статус замовлення");
            Console.WriteLine("1 - Заплановано");
            Console.WriteLine("2 - Виконано");
            int filterChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("Список замовлень:");

            foreach (var clientOrder in orders)
            {
                if (userChoice == 1 && clientOrder.Status == "Заплановано")
                {
                    Console.WriteLine($"Авто: {clientOrder.Car.Make} {clientOrder.Car.Model}, Проблема: {clientOrder.Description}, Статус: {clientOrder.Status}");
                }

                if (userChoice == 2 && clientOrder.Status == "Виконано")
                {
                    Console.WriteLine($"Авто: {clientOrder.Car.Make} {clientOrder.Car.Model}, Проблема: {clientOrder.Description}, Статус: {clientOrder.Status}");
                }
            }
            break;
        case 7:
            foreach (var c in clients)
            {
                Console.WriteLine("Введiть номер телефону для пошуку:");
                string searchNumber = Console.ReadLine();
                if (c.PhoneNumber == searchNumber)
                {
                    Console.WriteLine($"Клiєнт знайдений: {c.Name}, Телефон: {c.PhoneNumber}");
                }
            }
            break;
        case 0:
            Console.WriteLine("Дякую за роботу! Програму завершено.");

            return;
           
    }
    RepeatMenu();
}
RepeatMenu();
