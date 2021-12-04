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
        private readonly IPersonService personService;
        public PersonController()
        {
            personService = new PersonService();
        }

        [HttpGet("")]
        public IEnumerable<Person> GetAll()
        {
            return personService.GetAll();
        }
    }
}
