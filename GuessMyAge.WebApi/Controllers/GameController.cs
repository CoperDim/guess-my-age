using GuessMyAge.Business.Services;
using GuessMyAge.Database.Entities;
using GuessMyAge.Database.Repositories;
using GuessMyAge.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyAge.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;      
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        
        [HttpPost("")]
        public IActionResult Create([FromBody] Game game)
        {
            _gameService.Create(game);

            return Ok();
        }
        
        [HttpGet("")]
        public IEnumerable<Game> GetAll()
        {
            return _gameService.GetAll();
        }
    }
}