using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Mobile.Helpers.AppSettings;
using TodoApp.Mobile.Helpers.Services;
using TodoApp.Mobile.Interfaces;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Services;

public class TodoItemService : HttpClientService,ITodoItemService
{
    public async Task<List<TodoItem>?> GetAllTodo()
    {
        List<TodoItem>? toDoItems = null;
        try
        {
            var response = await CallGetAsync<List<TodoItem>>(UrlBaseWebApi + ApiSettingKeys.CRUDName);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                toDoItems = response.Content;
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