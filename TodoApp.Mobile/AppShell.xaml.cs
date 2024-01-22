using TodoApp.Mobile.Pages;
using TodoApp.Mobile.ViewModels;

namespace TodoApp.Mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TodoItemsViewModel), typeof(TodoItemsPage));
            Routing.RegisterRoute(nameof(CreateNewTodoItemViewModel), typeof(CreateNewTodoItemPage));
        }

        // UnComment the below method to handle Shell Menu item click event
        // And ensure appropriate page definitions are available for it work as expected
        //private async void OnMenuItemClicked(object sender, EventArgs e)
        //{
        //    await Current.GoToAsync("//login");
        //}
    }
}
