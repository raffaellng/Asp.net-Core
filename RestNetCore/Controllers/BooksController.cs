using Microsoft.AspNetCore.Mvc;
using RestNetCore.Business;
using RestNetCore.Data.VO;
using RestNetCore.Model;


namespace RestNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private IBooksBusiness _booksService;

        public BooksController(IBooksBusiness booksBusiness)
        {
            _booksService = booksBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_booksService.FindByall());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var books = _booksService.FindById(id);
            if (books == null) return NotFound();

            return Ok(books);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BooksVO books)
        {
            if (books == null) return BadRequest();
            return Ok(_booksService.Create(books));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BooksVO books)
        {
            if (books == null) return BadRequest();
            return Ok(_booksService.Update(books));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _booksService.Delete(id);
            return NoContent();
        }
    }
}
