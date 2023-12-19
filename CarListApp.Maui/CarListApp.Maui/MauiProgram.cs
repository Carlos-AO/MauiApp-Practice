﻿using CarListApp.Maui.Services;
using CarListApp.Maui.ViewModels;
using Microsoft.Extensions.Logging;

namespace CarListApp.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Services.AddSingleton<CarService>();
            builder.Services.AddSingleton<CarListViewModel>();#endif
            builder.Services.AddSingleton<MainPage>();#endif

            return builder.Build();
        }
    }
}
