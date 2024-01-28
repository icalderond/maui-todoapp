using System.Threading.Tasks;
using TodoApp.Mobile.Model;

namespace TodoApp.Mobile.Interfaces;

public interface IRandomUserService
{
    Task<RandomUser?> GetRandomUser();
}