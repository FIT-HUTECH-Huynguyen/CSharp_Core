using NguyenMaiBaoHuy_7564_Tuan2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan2.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;
        public BookController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Sach 1",
                Author = "Không biết",
                PublicYear = 2020,
                Price = 10000,
                Cover = "/Content/images/book1.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Sach 2",
                Author = "Không biết",
                PublicYear = 2020,
                Price = 20000,
                Cover = "/Content/images/book2.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Sach 3",
                Author = "Không biết",
                PublicYear = 2020,
                Price = 30000,
                Cover = "/Content/images/book3.jpg"
            });
        }
        public ActionResult ListBook()
        {
            ViewBag.TitlePageName = " Hutech Book";
            return View(listBooks);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(b => b.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(b => b.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> listImageBook;

            listImageBook = new List<SelectListItem>();

            string imagePath = Server.MapPath("/Content/images");
            string[] images = System.IO.Directory.GetFiles(imagePath);
            foreach (string image in images)
            {
                string[] imgPath = image.Split('\\');
                string value = "/Content/images/" + imgPath[imgPath.Length - 1];
                string text = imgPath[imgPath.Length - 1].Split('.')[0];
                listImageBook.Add(new SelectListItem()
                {
                    Text = text,
                    Value = value,
                    Selected = imgPath.Equals(book.Cover)
                });
            }
            ViewBag.ListImageBook = listImageBook;
            return View(book);
        }
        // edit book 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid) // du lieu nhap dung theo yeu cau 
            {
                try
                {
                    var editBook = listBooks.Find(b => b.Id == book.Id);
                    editBook.Title = book.Title;
                    editBook.Author = book.Author;
                    editBook.PublicYear = book.PublicYear;
                    editBook.Price = book.Price;
                    editBook.Cover = book.Cover;
                    return View("ListBook", listBooks);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valide");
                return View(book);
            }
        }

        public ActionResult DeleteBook(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("empty");
                return HttpNotFound();
            }
            Book book = listBooks.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                listBooks.Remove(book);
                return View("ListBook", listBooks);

            }
            else
            {
                return HttpNotFound();
            }

        }
        public ActionResult AddBook(int? id)
        {
            List<SelectListItem> listImageBook;

            listImageBook = new List<SelectListItem>();

            string imagePath = Server.MapPath("/Content/images");
            string[] images = System.IO.Directory.GetFiles(imagePath);
            foreach (string image in images)
            {
                string[] imgPath = image.Split('\\');
                string value = "/Content/images/" + imgPath[imgPath.Length - 1];
                string text = imgPath[imgPath.Length - 1].Split('.')[0];
                listImageBook.Add(new SelectListItem()
                {
                    Text = text,
                    Value = value
                });
            }
            ViewBag.ListImageBook = listImageBook;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    book.Id = listBooks.Count + 1;
                    listBooks.Add(book);
                    return View("ListBook", listBooks);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valide");
                return View(book);
            }
        }
    }
}