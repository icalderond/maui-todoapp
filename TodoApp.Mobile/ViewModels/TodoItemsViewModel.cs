using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.ViewModels;

public partial class TodoItemsViewModel : ObservableObject
{
    #region Private Properties
    private readonly ITodoItemService _todoItemService;
    #endregion Private Properties

    #region Lifecycle Methods
    /// <summary>
    /// Constructor
    /// </summary>
    public TodoItemsViewModel(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
        _ = Initialize();
    }
    #endregion Lifecycle Methods

    #region Public Properties
    private ObservableCollection<ToDoItem> _todoItems; 
    public ObservableCollection<ToDoItem> TodoItems
    {
        get => _todoItems;
        set => SetProperty(ref _todoItems, value);
    }
    #endregion Public Properties

    #region Public Methods
    /// <summary>
    /// Load initial data
    /// </summary>
    private async Task Initialize()
    {
        //Load data
        var todoItems = await _todoItemService.GetAllTodo();
        if (todoItems != null) TodoItems = new ObservableCollection<ToDoItem>(todoItems);
    }

    [RelayCommand]
    private async Task OpenNote(object arg)
    {
       //await Shell.Current.GoToAsync("");
    }

    [RelayCommand]
    private void OpenCreateNewNote(object arg)
    {
         Shell.Current.GoToAsync(nameof(CreateNewTodoItemViewModel));
    }
    #endregion Public Methods
}