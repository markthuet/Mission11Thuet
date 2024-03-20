using Microsoft.AspNetCore.Mvc;
using Mission11Thuet.Models;
using Mission11Thuet.Models.ViewModels;
using System.Diagnostics;
namespace Mission11Thuet.Controllers
{
    public class HomeController : Controller
    {

        private IBookRepo _repo;
        public HomeController(IBookRepo temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BookList
            {

                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()

                }
            };

           
            return View(blah);
        }
    }
}

