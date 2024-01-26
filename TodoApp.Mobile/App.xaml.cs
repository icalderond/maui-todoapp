using Microsoft.Maui.Controls;

namespace TodoApp.Mobile;

public partial class App : Application
{
    public App()
    {
        // Dribbble design
        // https://dribbble.com/shots/23185462-Notebook-Mobile-App
        
        InitializeComponent();

        MainPage = new AppShell();
    }
}