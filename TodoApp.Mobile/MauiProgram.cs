﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using TodoApp.Mobile.Interfaces;
using TodoApp.Mobile.Pages;
using TodoApp.Mobile.Services;
using TodoApp.Mobile.ViewModels;

namespace TodoApp.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Pages
        builder.Services.AddTransient<TodoItemsPage>();
        builder.Services.AddTransient<CreateNewTodoItemPage>();
        
        // ViewModels
        builder.Services.AddTransient<TodoItemsViewModel>();
        builder.Services.AddTransient<CreateNewTodoItemViewModel>();
        
        // Services
        builder.Services.AddSingleton<ITodoItemService, TodoItemService>();
        builder.Services.AddSingleton<IRandomUserService, RandomUserService>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}