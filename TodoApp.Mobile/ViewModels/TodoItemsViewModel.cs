using System.Collections.ObjectModel;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.ViewModels;

public class TodoItemsViewModel : BaseViewModel
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
        _ = LoadData();
    }

    private async Task LoadData()
    {
        var todoItems = await _todoItemService.GetAllTodo();
        if (todoItems != null) DummyData = new ObservableCollection<ToDoItem>(todoItems);
    }
    #endregion Lifecycle Methods

    #region Public Properties
    private ObservableCollection<ToDoItem> _dummyData; 
    public ObservableCollection<ToDoItem> DummyData
    {
        get => _dummyData;
        set => SetProperty(ref _dummyData, value);
    }
    
    #endregion Public Properties
}