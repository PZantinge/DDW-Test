using FarmNumberGuessing.Data;
using System;
using System.Threading.Tasks;

namespace FarmNumberGuessing.Services
{
    public class GameService : IGameService
    {
        private readonly IGameContext DbContext;

        public GameService(IGameContext gameContext)
        {
            DbContext = gameContext;
        }

        public async Task<Guid> StartGameAsync(int digits, string playerName, int playerAge)
        {
            // playerName may not be null, empty or white space
            if (string.IsNullOrWhiteSpace(playerName))
            {
                throw new ArgumentException("may not be empty", nameof(playerName));
            }

            // player Age should be non negative.
            if (playerAge < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(playerAge), "may not be negative");
            }

            // validate number of digits
            if (digits < 4 || digits > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(digits), "must be betweeen 4 and 8");
            }


            var maxValue = Convert.ToInt32(Math.Pow(10, digits));
            var newGame = new Game {
                Digits = digits,
                Number = new Random().Next(maxValue),
                Player = new Player {
                    Name = playerName,
                    Age = playerAge
                }
            };
            DbContext.Games.Add(newGame);

            await DbContext.SaveChangesAsync();
            return newGame.Id;
        }
    }
}
