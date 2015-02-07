using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using AngularBookstore.Models;
using System.Linq;

namespace AngularBookstore.Api.Controllers
{
    [Route("api/[controller]")]
    public class BooksController
    {

        private readonly BooksDb _booksDb;

        public BooksController(BooksDb booksDb)
        {
            _booksDb = booksDb;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _booksDb.Books;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var book = _booksDb.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return new ObjectResult(book);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book.Id == 0)
            {
                _booksDb.Books.Add(book);
                _booksDb.SaveChanges();
                return new ObjectResult(book);
            }
            else
            {
                var original = _booksDb.Books.FirstOrDefault(b => b.Id == book.Id);
                original.Title = book.Title;
                original.Author = book.Author;
                _booksDb.SaveChanges();
                return new ObjectResult(original);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var movie = _booksDb.Books.FirstOrDefault(b => b.Id == id);
            _booksDb.Books.Remove(movie);
            _booksDb.SaveChanges();
            return new HttpStatusCodeResult(200);
        }

    }
}
