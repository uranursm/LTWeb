using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebASPNETMVCApplication.Models;

namespace FirstWebASPNETMVCApplication.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBooks;
        /// <summary>
        /// Ham khoi tao BooksController
        /// </summary>
        public BooksController()
        {
            listBooks = new List<Book>();
            //Populate Sample Book Data
            #region populate sample book data
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Sach 1",
                Author = "Tac gia sach 1",
                PublicYear = 2017,
                Price = 40000,
                Cover="Content/images/book1.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Sach 2",
                Author = "Tac gia sach 2",
                PublicYear = 2018,
                Price = 50000,
                Cover = "Content/images/book2.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Sach 3",
                Author = "Tac gia sach 3",
                PublicYear = 2019,
                Price = 100000,
                Cover = "Content/images/book3.jpg"
            });
            #endregion
        }

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Trang xem danh sach Book
        /// </summary>
        /// <returns></returns>
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "Book view page";
            return View(listBooks);
        }
    }
}