using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Services
{
    public class MenuService
    {
        private void Print(string menuItem)
        {
            Console.WriteLine(menuItem);
        }

        public void PrintMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Print(Environment.NewLine + "");
            Print(" 1 - Додати клієнта");
            Print(" 2 - Додати авто клієнту");
            Print(" 3 - Список клієнтів");
            Print(" 4 - Cтоврити замовлення ");
            Print(" 5 - Вийти");
        }

        public void ResetMenu()
        {
            Console.Clear();
            PrintMenu();
        }
    }
}
