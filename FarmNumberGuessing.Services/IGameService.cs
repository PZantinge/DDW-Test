using System;
using System.Threading.Tasks;

namespace FarmNumberGuessing.Services
{
    public interface IGameService
    {
        Task<Guid> StartGameAsync(int digits, string playerName, int playerAge);
    }
}