using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var authors = new List<Author>
        {
            new Author { Id = 1, Name = "J.R.R. Tolkien", Nationality = "British" },
            new Author { Id = 2, Name = "George Orwell", Nationality = "British" },
            new Author { Id = 3,  Name = "Jane Austen", Nationality = "British" }
        };

            var books = new List<Book>
        {
            new Book { Id = 1, Title = "The Lord of the Rings", Year = 1954, Author = authors[0] },
            new Book { Id = 2, Title = "1984", Year = 1949, Author = authors[1] },
            new Book { Id = 3, Title = "Pride and Prejudice", Year = 1813, Author = authors[2] },
            new Book { Id = 4, Title = "The Hobbit", Year = 1937, Author = authors[0] },
            new Book { Id = 5, Title = "Animal Farm", Year = 1945, Author = authors[1] }
        };
            return View(books);
        }
    }
}
