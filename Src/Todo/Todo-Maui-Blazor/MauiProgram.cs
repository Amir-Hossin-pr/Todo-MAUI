﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using MudBlazor.Services;
using Todo_Maui_Blazor.Data;
using Todo_Maui_Blazor.Services;

namespace Todo_Maui_Blazor
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            //builder.Services.AddSingleton<ITodoService, TodoService>();

            return builder.Build();
        }
    }
}