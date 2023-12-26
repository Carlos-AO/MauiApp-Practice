using CarListApp.Maui.Models;
using SQLite;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        //private SQLiteConnection conn;
        SQLiteConnection conn;
        string _dbPath;
        public string StatusMessage;
        int result = 0;

        public CarService(string dbPath)
        {
            _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Car>();
        }

        public List<Car> GetCars()
        {
            /*return new List<Car>()
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
            
            };*/
            
            //Init();
            try
            {
                Init();
                return conn.Table<Car>().ToList();
            }
            catch (Exception ex)
            {
                //throw;
                StatusMessage = "Failed to retrive data.";
            }
            return new List<Car>();

        }

        public Car GetCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().FirstOrDefault(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrive data.";
            }
            return null;
        }

        public int DeleteCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().Delete(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data.";
            }
            return 0;
        }

        public void AddCar(Car car)
        {
            try
            {
                Init();

                if (car == null)
                    throw new Exception("Invalid Card Record");

                result = conn.Insert(car);
                StatusMessage = result == 0 ? "Insert Failed" : "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Insert data.";
            }
        }
    }
}
