using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestNetCore.Business;
using RestNetCore.Data.VO;
using RestNetCore.Hypermedia.Filters;
using RestNetCore.Model;


namespace RestNetCore.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]")]
    [Authorize("Bearer")]
    public class PersonController : ControllerBase
    {
        private IPersonBusiness _personService;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personService = personBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {
            return Ok(_personService.FindByall());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PersonVO person)
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
