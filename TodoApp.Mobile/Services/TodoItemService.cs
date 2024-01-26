using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Services;

public class TodoItemService : ITodoItemService
{
    private readonly string _urlBase = "http://192.168.1.102:5049/";
    private readonly string _getAllMethod = "todoitems";

    public async Task<List<TodoItem>?> GetAllTodo()
    {
        List<TodoItem>? toDoItems = null;
        try
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Uri(_urlBase + _getAllMethod));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                toDoItems = JsonSerializer.Deserialize<List<TodoItem>>(jsonResponse);
                toDoItems?.ForEach(td => td.TagsString = td.Tags.Select(x => x.Title)); 
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