using GuessMyAge.Business.Models;
using GuessMyAge.Business.Services;
using GuessMyAge.Database;
using GuessMyAge.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuessMyAge.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly GuessMyAgeDbContext _context;
        public PersonController(IPersonService personService, GuessMyAgeDbContext context)
        {
            _personService = personService;
            _context = context;
        }

        [HttpGet("")]
        public IEnumerable<PersonDatabaseEntity> GetAll()
        {
            return _context.Persons.ToList();
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] PersonDatabaseEntity person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();

            return Ok();
        }
    }
}
