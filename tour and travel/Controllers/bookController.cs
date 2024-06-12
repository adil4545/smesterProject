using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using tour_and_travel.data;
using tour_and_travel.Models;

namespace tour_and_travel.Controllers
{
    public class bookController : Controller
    {
        private readonly addDbContext dbContext;

        public bookController(addDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Book()
        {
            var boo = dbContext.tour.ToList();
            return View(boo);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(bookdto bd)
        {
            if (!ModelState.IsValid)
            {
                return View(bd);
            }

            book b = new book()
            {
                cname = bd.cname,
                cdestination = bd.cdestination,
                cadult = bd.cadult,
                cchild = bd.cchild,
                cstay = bd.cstay,

            };
            dbContext.tour.Add(b);
            dbContext.SaveChanges();
            return RedirectToAction("Book", "book");
        }
        public IActionResult Edit(int Id)
        {
            var book = dbContext.tour.Find(Id);
            if (book == null)
            {
                return RedirectToAction("Book", "book");

            }
            var bookdto = new bookdto()
            {
                cname = book.cname,
                cdestination = book.cdestination,
                cadult = book.cadult,
                cchild = book.cchild,

            };
            ViewData["bookid"] = book.Id;

            return View(bookdto);
        }


        [HttpPost]
        public IActionResult Edit(int Id, bookdto bd)
        {
            var book = dbContext.tour.Find(Id);
            if (book == null)
            {
                return RedirectToAction("Book", "book");

            }
            if (!ModelState.IsValid)
            {
                ViewData["bookid"] = book.Id;
                return View(bd);
            }
            book.cname = bd.cname;
            book.cdestination = bd.cdestination;
            book.cadult = bd.cadult;
            book.cchild = bd.cchild;
            dbContext.SaveChanges();
            return RedirectToAction("Book", "book");

        }
        public IActionResult Delete(int Id)
        {
            var book = dbContext.tour.Find(Id);
            if (book == null)
            {
                return RedirectToAction("Book", "book");
            }
            dbContext.Remove(book);
            dbContext.SaveChanges();

            return RedirectToAction("Book", "book");
        }

    }
}
