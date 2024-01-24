using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.ViewModels;

public partial class CreateNewTodoItemViewModel : ObservableObject
{
    #region Private Properties
    private readonly ITodoItemService _todoItemService;
    #endregion Private Properties

    #region Lifecycle Methods
    /// <summary>
    /// Constructor
    /// </summary>
    public CreateNewTodoItemViewModel(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
        _ = Initialize();
    }
    #endregion Lifecycle Methods
    
    #region Public Methods
    /// <summary>
    /// Load initial data
    /// </summary>
    private async Task Initialize()
    {
        
    }

    [RelayCommand]
    private async Task OpenNote(object arg)
    {
        // _todoItemService
    }
    #endregion Public Methods
}