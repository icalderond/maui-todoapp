using Microsoft.Maui.Controls;
using TodoApp.Mobile.ViewModels;

namespace TodoApp.Mobile.Pages;

public partial class TodoItemsPage : ContentPage
{
    public TodoItemsPage(TodoItemsViewModel todoItemsViewModel)
    {
        InitializeComponent();
        this.BindingContext = todoItemsViewModel;
    }
}