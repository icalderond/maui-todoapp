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
    private readonly string UrlBase = "http://192.168.0.120:5049/";
    private readonly string GetAllMethod = "todoitems";

    public async Task<List<TodoItem>?> GetAllTodo()
    {
        List<TodoItem>? toDoItems = null;
        try
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Uri(UrlBase + GetAllMethod));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                toDoItems = JsonSerializer.Deserialize<List<TodoItem>>(jsonResponse);
                toDoItems.ForEach(td => td.TagsString = td.Tags.Select(x => x.Title)); 
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