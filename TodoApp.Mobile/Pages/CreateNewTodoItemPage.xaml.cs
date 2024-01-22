using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Mobile.ViewModels;

namespace TodoApp.Mobile.Pages;

public partial class CreateNewTodoItemPage : ContentPage
{
    public CreateNewTodoItemPage(CreateNewTodoItemViewModel createNewTodoItemViewModel)
    {
        InitializeComponent();
        this.BindingContext = createNewTodoItemViewModel;
    }
}