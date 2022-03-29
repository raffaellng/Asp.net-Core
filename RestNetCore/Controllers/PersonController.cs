using Microsoft.AspNetCore.Mvc;
using RestNetCore.Business;
using RestNetCore.Model;


namespace RestNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonBusiness _personService;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personService = personBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personService.FindByall());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
