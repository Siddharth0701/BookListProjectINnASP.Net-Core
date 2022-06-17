using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;

namespace BookList.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController( ApplicationDbContext db)

        {
            _db = db;

        }
        [HttpGet]
        public IActionResult GelAll()
        {
            return Json(new { data=_db.Book.ToList()});
        }
    }
}
