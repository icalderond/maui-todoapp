using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TodoApp.Mobile.Helpers.AppSettings;
using TodoApp.Mobile.Helpers.Services;
using TodoApp.Mobile.Interfaces;
using TodoApp.Mobile.Model;

namespace TodoApp.Mobile.Services;

public class TodoItemService : HttpClientService,ITodoItemService
{
    public async Task<List<TodoItemClient>?> GetAllTodo()
    {
        List<TodoItemClient>? toDoItems = null;
        try
        {
            var response = await CallGetAsync<List<TodoItemClient>>(UrlBaseWebApi + ApiSettingKeys.CRUDName);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                toDoItems = response.Content;
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