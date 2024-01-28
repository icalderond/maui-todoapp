using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using TodoApp.Mobile.Interfaces;
using TodoApp.Mobile.Model;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.ViewModels;

public partial class TodoItemsViewModel : ObservableObject
{
    #region Private Properties
    private readonly ITodoItemService _todoItemService;
    private readonly IRandomUserService _randomUserService;
    private bool _isRefreshing;
    private ObservableCollection<TodoItem> _todoItems;
    private RandomUser _randomUser;
    #endregion Private Properties

    #region Lifecycle Methods
    /// <summary>
    /// Constructor
    /// </summary>
    public TodoItemsViewModel(ITodoItemService todoItemService, IRandomUserService randomUserService)
    {
        _todoItemService = todoItemService;
        _randomUserService = randomUserService;
        _ = LoadData();
    }
    #endregion Lifecycle Methods

    #region Public Properties

    public ObservableCollection<TodoItem> TodoItems
    {
        get => _todoItems;
        set => SetProperty(ref _todoItems, value);
    }

    public RandomUser RandomUser
    {
        get => _randomUser;
        set => SetProperty(ref _randomUser, value);
    }

    private bool IsRefreshing
    {
        get => _isRefreshing;
        set => SetProperty(ref _isRefreshing, value);
    }
    #endregion Public Properties

    #region Public Methods
    [RelayCommand]
    private async Task OpenNote(object arg)
    {
        //await Shell.Current.GoToAsync("");
    }

    /// <summary>
    /// Load initial data
    /// </summary>
    [RelayCommand]
    private async Task LoadData()
    {
        try
        {
            IsRefreshing = true;
            //Load data
            var todoItems = await _todoItemService.GetAllTodo();
            if (todoItems != null) TodoItems = new ObservableCollection<TodoItem>(todoItems);

            RandomUser = await _randomUserService.GetRandomUser();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            IsRefreshing = false;
        }
    }

    /// <summary>
    /// Open CreateNewNotePage
    /// </summary>
    /// <param name="arg"></param>
    [RelayCommand]
    private void OpenCreateNewNote(object arg)
    {
        Shell.Current.GoToAsync(nameof(CreateNewTodoItemViewModel));
    }
    #endregion Public Methods
}