using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using AngularBookstore.Models;

namespace AngularBookstore.Api.Controllers
{
    [Route("api/[controller]")]
    public class BooksController
    {
        public IEnumerable<Book> Get()
        {
            yield return new Book() { Id = 1, Title = "High Society", Author = "Ben Elton" };
        }
    }
}
