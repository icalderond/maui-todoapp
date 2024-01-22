using System.Net;
using System.Text.Json;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Services;

public class TodoItemService : ITodoItemService
{
    private readonly string UrlBase = "http://192.168.0.110:5043/";
    private readonly string GetAllMethod = "GetAll";

    public async Task<List<ToDoItem>?> GetAllTodo()
    {
        List<ToDoItem>? toDoItems = null;
        try
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Uri(UrlBase + GetAllMethod));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                toDoItems = JsonSerializer.Deserialize<List<ToDoItem>>(jsonResponse);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return toDoItems;
    }
}