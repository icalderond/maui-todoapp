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
using TodoApp.Mobile.Model;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Services;

public class RandomUserService : HttpClientService, IRandomUserService
{
    private readonly string _randomUserUrl = "https://randomuser.me/api/";

    public async Task<RandomUser?> GetRandomUser()
    {
        RandomUser? randomUser = null;
        try
        {
            var response = await CallGetAsync<RandomUserResult>(ApiSettingKeys.RandomUserUri);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                randomUser = response.Content?.Results.FirstOrDefault();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return randomUser;
    }
}