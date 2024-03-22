//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;
//using TheBookstore.Models;

//namespace TheBookstore.Controllers
//{
//    public class HomeController : Controller
//    {
//        private IBookRepository _repo;
//        //private readonly ILogger<HomeController> _logger;

//        public HomeController(IBookRepository temp)
//        {
//            _repo = temp;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}



using Microsoft.AspNetCore.Mvc;
using TheBookstore.Models;
using TheBookstore.Models.ViewModels;

namespace TheBookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var blah = new BooksListViewModel {
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


          
            // Retrieve list of books from the repository
            var books = _repo.Books;
          

            // Pass the list of books to the view
            return View(blah);
        }
    }
}

