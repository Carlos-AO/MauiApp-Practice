using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;

            /*
            // storage option 1 at MainPage.xaml.cs and option 2 at CarListViewModel.cs - option 1:
            Preferences.Set("saveDetails", true);
            var detailsSaved = Preferences.Get("saveDetails", false);
            */
        }


    }

}
