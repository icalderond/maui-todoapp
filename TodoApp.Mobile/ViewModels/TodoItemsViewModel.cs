using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.ViewModels;

public partial class TodoItemsViewModel : ObservableObject
{
    #region Private Properties
    private readonly ITodoItemService _todoItemService;
    private bool _isRefreshing;
    #endregion Private Properties

    #region Lifecycle Methods
    /// <summary>
    /// Constructor
    /// </summary>
    public TodoItemsViewModel(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
        _ = LoadData();
    }
    #endregion Lifecycle Methods

    #region Public Properties
    private ObservableCollection<TodoItem> _todoItems;

    public ObservableCollection<TodoItem> TodoItems
    {
        get => _todoItems;
        set => SetProperty(ref _todoItems, value);
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

    [RelayCommand]
    /// <summary>
    /// Load initial data
    /// </summary>
    private async Task LoadData()
    {
        try
        {
            IsRefreshing = true;
            //Load data
            var todoItems = await _todoItemService.GetAllTodo();
            if (todoItems != null) TodoItems = new ObservableCollection<TodoItem>(todoItems);
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

    [RelayCommand]
    private void OpenCreateNewNote(object arg)
    {
        Shell.Current.GoToAsync(nameof(CreateNewTodoItemViewModel));
    }
    #endregion Public Methods
}