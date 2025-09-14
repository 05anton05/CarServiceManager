// See https://aka.ms/new-console-template for more information
using CarServiceManager;
using System.Drawing;


List<Client> clients = new List<Client>();
List<Car> cars = new List<Car>();

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


}