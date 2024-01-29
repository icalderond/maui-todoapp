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

public partial class CreateNewTodoItemViewModel : ObservableObject
{
    #region Private Properties
    private readonly ITodoItemService _todoItemService;
    private string _titleString;
    private string _contentString;
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

    #region Public Properties
    public string TitleString
    {
        get => _titleString;
        set => SetProperty(ref _titleString, value);
    }

    public string ContentString
    {
        get => _contentString;
        set => SetProperty(ref _contentString, value);
    }
    #endregion Public Properties

    #region Public Methods
    /// <summary>
    /// Load initial data
    /// </summary>
    private async Task Initialize()
    {
    }

    [RelayCommand]
    private async Task GoBack(object arg)
    {
        if (!string.IsNullOrEmpty(TitleString) && !string.IsNullOrEmpty(ContentString))
        {
            await _todoItemService.SaveTodoItem(new TodoItemClient()
            {
                Title = TitleString,
                Content = ContentString
            });
            await Shell.Current.GoToAsync($"..?reload=true");
        }
        else
        {
            await Shell.Current.GoToAsync("..");
        }
    }
    #endregion Public Methods
}