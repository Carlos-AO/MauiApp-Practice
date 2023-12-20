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
                    Id = 4, Make = "BMW", Model = "M4", Vin = "623"
                },
                new Car
                {
                    Id = 4, Make = "1BMW", Model = "M5", Vin = "1623"
                },
                new Car
                {
                    Id = 4, Make = "2BMW", Model = "M6", Vin = "2623"
                },
                new Car
                {
                    Id = 4, Make = "3BMW", Model = "M7", Vin = "3623"
                },
                new Car
                {
                    Id = 4, Make = "4BMW", Model = "M83", Vin = "4423"
                },
                new Car
                {
                    Id = 1, Make = "1Honda", Model = "Fit", Vin = "3123"
                },
                new Car
                {
                    Id  = 2, Make = "2Toyota", Model = "Prado", Vin = "3234"
                },
                new Car
                {
                    Id  = 3, Make = "3Audi", Model = "Civic", Vin = "3523"
                }
            };
        }
    }
}
