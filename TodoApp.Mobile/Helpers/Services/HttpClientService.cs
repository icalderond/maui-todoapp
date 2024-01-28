using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Mobile.Helpers.AppSettings;

namespace TodoApp.Mobile.Helpers.Services;

public class HttpClientService : HttpClient
{
    public HttpClientService()
    {
        BaseAddress = new Uri(UrlBaseWebApi);
        InitHeaders();
    }

    public HttpClientService(string urlController)
    {
        UrlController = urlController;
        InitHeaders();
    }

    public HttpClientService(string urlController, string url)
    {
        this.UrlBaseWebApi = url;
        UrlController = urlController;
        InitHeaders();
    }

    public string UrlBaseWebApi
    {
        get => _urlBaseWebApi;
        set => _urlBaseWebApi = value;
    }

    string urlController;
    private string _urlBaseWebApi = ApiSettingKeys.BaseHost;

    protected string UrlController
    {
        get => urlController;
        set
        {
            urlController = !value.EndsWith("/") ? value + "/" : value;
            UrlBaseWebApi += (!UrlBaseWebApi.EndsWith("/") ? "/" : string.Empty) + value;
            BaseAddress = new Uri(UrlBaseWebApi);
        }
    }

    void InitHeaders()
    {
        DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public virtual async Task<(HttpStatusCode StatusCode, TResponse Content)> CallPostAsync<TRequest, TResponse>(
        string url, TRequest req)
    {
        try
        {
            var jsonConvert = JsonSerializer.Serialize(req);
            StringContent stringContent = new StringContent(jsonConvert, Encoding.UTF8, "application/json");

            var res = await PostAsync(url, stringContent).ConfigureAwait(false);
            return ProcessResponse<TResponse>(res);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<(HttpStatusCode StatusCode, TResponse Content)> CallPutAsync<TRequest, TResponse>(string url,
        TRequest req)
    {
        var res = await PutAsync(url,
            new StringContent(JsonSerializer.Serialize(req), Encoding.UTF8, "application/json")).ConfigureAwait(false);
        return ProcessResponse<TResponse>(res);
    }

    public async Task<(HttpStatusCode StatusCode, TResponse Content, string Exception)> CallPutAsyncException<TRequest,
        TResponse>(string url, TRequest req)
    {
        try
        {
            var jsonConvert = JsonSerializer.Serialize(req);
            StringContent stringContent = new StringContent(jsonConvert, Encoding.UTF8, "application/json");
            var res = await PutAsync(url, stringContent).ConfigureAwait(false);
            return await ProcessResponseExtended<TResponse>(res);
        }
        catch (Exception e)
        {
            return (HttpStatusCode.BadRequest, default(TResponse), e.Message);
        }
    }

    public async Task<(HttpStatusCode StatusCode, TResponse Content)> CallGetAsync<TResponse>(string url)
    {
        var res = await GetAsync(url).ConfigureAwait(false);
        var query = from err in res.Headers.ToList()
            where err.Key == "errorMsg"
            select err.Value;
        return ProcessResponse<TResponse>(res);
    }

    public async Task<(HttpStatusCode StatusCode, TResponse Content)> CallDeleteAsync<TResponse>(string url)
    {
        var res = await DeleteAsync(url).ConfigureAwait(false);
        return ProcessResponse<TResponse>(res);
    }

    private (HttpStatusCode StatusCode, TResponse Content) ProcessResponse<TResponse>(HttpResponseMessage res)
    {
        if (res.IsSuccessStatusCode)
        {
            var s = res.Content.ReadAsStringAsync().Result;
            var response = JsonSerializer.Deserialize<TResponse>(s, new JsonSerializerOptions() { });
            return (res.StatusCode, response);
        }
        else
        {
            return (res.StatusCode, default(TResponse));
        }
    }

    private async Task<(HttpStatusCode StatusCode, T Content, string exception)> ProcessResponseExtended<T>(
        HttpResponseMessage res)
    {
        if (res.IsSuccessStatusCode)
        {
            var result = await res.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(result);
            return (res.StatusCode, response, null);
        }
        else
        {
            #region validar la excepcion del back
            try
            {
                var query = from err in res.Headers.ToList()
                    where err.Key == "errorMsg"
                    select err.Value.FirstOrDefault();

                string exception = query.FirstOrDefault();
                if (!string.IsNullOrEmpty(exception))
                {
                    return (res.StatusCode, default(T), exception);
                }
                else
                {
                    var errorJson = res.Content.ReadAsStringAsync().Result;
                    return (res.StatusCode, default(T), errorJson);
                }
            }
            catch (Exception ex)
            {
                return (res.StatusCode, default(T), ex.Message);
            }
            #endregion
        }
    }
}