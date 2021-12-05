using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;
using GuessMyAge.Database;
using GuessMyAge.Database.Entities;
using GuessMyAge.Database.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyAge.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;      
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("")]
        public IEnumerable<PersonDatabaseEntity> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] PersonDatabaseEntity person)
        {
            _personRepository.Create(person);

            return Ok();
        }

        [HttpPut("")]
        public IActionResult Update([FromBody] PersonDatabaseEntity person)
        {
            _personRepository.Update(person);

            return Ok();
        }
    }
}
