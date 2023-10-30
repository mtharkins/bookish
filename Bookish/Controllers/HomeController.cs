using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Book()
    {
        var context = new BookishDbContext();
        var books = context.Books.Include(b => b.Author);
        var book = books.First();

        return View(book);
    }

        public IActionResult Author()
    {
        var context = new BookishDbContext();
        var author = context.Authors.Include(b => b.Books).FirstOrDefault();

        return View(author);
    }

        public IActionResult Authors()
    {
        var context = new BookishDbContext();
        var authors = context.Authors
            .Include(b => b.Books)
            .ToList();

        return View(authors);
    }

        public IActionResult Books()
    {
        var context = new BookishDbContext();
        var books = context.Books
            .Include(b => b.Author)
            .ToList();

        return View(books);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
