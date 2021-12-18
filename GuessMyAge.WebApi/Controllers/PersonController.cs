using GuessMyAge.Business.Services;
using GuessMyAge.Database.Entities;
using GuessMyAge.Database.Repositories;
using GuessMyAge.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyAge.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService, IGameService gameService )
        {
            _personService = personService;
        }

        [HttpGet("")]
        public IEnumerable<Person> GetAll()
        {
            return _personService.GetAll();
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] Person person)
        {
            _personService.Create(person);
            return Ok();
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] Person person)
        {
            _personService.Update(person);

            return Ok();
        }
    }
}
