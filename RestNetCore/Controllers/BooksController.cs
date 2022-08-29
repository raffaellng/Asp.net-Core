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
    [Authorize("Bearer")]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private IBooksBusiness _booksService;

        public BooksController(IBooksBusiness booksBusiness)
        {
            _booksService = booksBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {
            return Ok(_booksService.FindByall());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var books = _booksService.FindById(id);
            if (books == null) return NotFound();

            return Ok(books);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] BooksVO books)
        {
            if (books == null) return BadRequest();
            return Ok(_booksService.Create(books));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] BooksVO books)
        {
            if (books == null) return BadRequest();
            return Ok(_booksService.Update(books));
        }

        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(long id)
        {
            _booksService.Delete(id);
            return NoContent();
        }
    }
}
