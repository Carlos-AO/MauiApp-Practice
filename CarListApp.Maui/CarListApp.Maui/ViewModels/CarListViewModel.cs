using CarListApp.Maui.Models;
using CarListApp.Maui.Services;
using CarListApp.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using CoreBluetooth;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarListApp.Maui.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        //private readonly CarService carService;

        public ObservableCollection<Car> Cars { get; private set; } = new ();

        public CarListViewModel(CarService carService)
        {
            Title = "Car List";
            //this.carService = carService;
        }

        [ObservableProperty]
        bool isRefreshing;
        

        [RelayCommand]

        async Task GetCarList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();

                //var cars = carService.GetCars();
                var cars = App.CarService.GetCars();

                foreach (var car in cars) Cars.Add(car);

                /*
                // storage option 1 at MainPage.xaml.cs and option 2 at CarListViewModel.cs - option 2:
                string fileName = "carlist.json";
                var serializedList = JsonSerializer.Serialize(cars);
                File.WriteAllText(fileName, serializedList);

                var rawText = File.ReadAllText(fileName);
                //var carsFromText = JsonSerializer.Deserialize<Car[]>(rawText);
                var carsFromText = JsonSerializer.Deserialize<List<Car>>(rawText);

                string path = FileSystem.AppDataDirectory;
                //string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                */
            }
            catch (Exception ex) 
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrive list of cars.", "Ok");
            } 
            finally 
            {
                IsLoading = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]

        async Task GetCarDetails(Car car)
        {
            if (car == null) return;

            await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            {
                {nameof(Car), car}
            });
        }

    }
}
