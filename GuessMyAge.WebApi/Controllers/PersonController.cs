using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyAge.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
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
            _personService.AddPerson(person);

            return Ok();
        }
    }
}
