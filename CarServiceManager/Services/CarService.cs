using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Services
{
    class CarService
    {
        public Car Create(string make, string model, Color color, string plateNumber, int year)
        {
            return new Car { Make = make, Model = model, Color = color, PlateNumber = plateNumber, Year = year };
        }
        
        public Car CreateMazdaCX5(Color color, string plateNumber, int year)
        {
            return new Car { Make = "Mazda", Model = "CX-5", Color = color, PlateNumber = plateNumber, Year = year };
        }
    }
}
