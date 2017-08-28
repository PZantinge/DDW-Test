using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmNumberGuessing.Services;
using FarmNumberGuessing.Api.ViewModels.Game;

namespace FarmNumberGuessing.Api.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly IGameService GameService;

        public GameController(IGameService gameService)
        {
            GameService = gameService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Guess(int number, Guid gameId)
        {
            //TODO: check if number matches number in GameId (determine Cows and Chickens)
            //TODO. Create viewmodel to return
            return Ok(new { Cows = 0, Chickens = 5 });
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateGameViewModel model)
        {
            var gameId = await GameService.StartGameAsync(model.Digits, model.Name, model.Age);
            return Ok(gameId);
        }
    }
}
