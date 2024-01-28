using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Mobile.Interfaces;
using TodoApp.Mobile.Model;
using TodoApp.Shared.Models;

namespace TodoApp.Mobile.Services;

public class RandomUserService : IRandomUserService
{
    private readonly string _randomUserUrl = "https://randomuser.me/api/";

    public async Task<RandomUser?> GetRandomUser()
    {
        RandomUser? randomUser = null;
        try
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(new Uri(_randomUserUrl));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                RandomUserResult randomUserResult = JsonSerializer.Deserialize<RandomUserResult>(jsonResponse);
                randomUser = randomUserResult?.Results.FirstOrDefault();
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