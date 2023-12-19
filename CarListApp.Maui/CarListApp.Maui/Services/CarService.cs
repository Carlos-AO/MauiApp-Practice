using CarListApp.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>() 
            {
                new Car 
                { 
                    Id = 1, Make = "Honda", Model = "Fit", Vin = "123"
                },
                new Car 
                {
                    Id  = 2, Make = "Toyota", Model = "Prado", Vin = "234"
                },
                new Car
                {
                    Id  = 3, Make = "Audi", Model = "Civic", Vin = "523"
                },
                new Car
                {
                    Id = 4, Make = "BMW", Model = "M3", Vin = "623"
                },
            };
        }
    }
}
