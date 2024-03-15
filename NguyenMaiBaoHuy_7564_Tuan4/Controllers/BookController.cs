using NguyenMaiBaoHuy_7564_Tuan4.Models;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan4.Controllers
{
    public class BookController : Controller
    {
        private MyDataDataContext data = new MyDataDataContext();
        // GET: Book
        public ActionResult Index()
        {
            var books = data.Saches.ToList();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = data.Saches.First(bk => bk.masach == id);
            return View(book);
        }

        public ActionResult Edit(int id)
        {
            var Edit_book = data.Saches.First(bk => bk.masach == id);
            return View(Edit_book);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection form)
        {
            if (id == null)
                return HttpNotFound();
            var Edit_book = data.Saches.First(s => s.masach == id);
            var Edit_name = form["tensach"];
            var Edit_image = form["hinh"];
            var Edit_price = Convert.ToDecimal(form["giaban"]);
            var Edit_updateDay = Convert.ToDateTime(form["ngaycapnhat"]);
            var Edit_stock = Convert.ToInt32(form["soluongton"]);
            Edit_book.masach = id;
            if (string.IsNullOrEmpty(Edit_name))
            {
                ViewData["Error"] = "Tên sách không được để trống";
            }
            else
            {
                Edit_book.tensach = Edit_name;
                Edit_book.hinh = Edit_image;
                Edit_book.giaban = Edit_price;
                Edit_book.ngaycapnhat = Convert.ToDateTime(Edit_updateDay);
                Edit_book.soluongton = Convert.ToInt32(Edit_stock);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }

            return this.Edit(id);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, Sach book)
        {
            var Create_name = collection["tensach"];
            var Create_image = collection["hinh"];
            var Create_price = Convert.ToDecimal(collection["giaban"]);
            var Create_updateDay = Convert.ToDateTime(collection["ngaycapnhat"]);
            var Create_stock = Convert.ToInt32(collection["soluongton"]);
            if (string.IsNullOrEmpty(Create_name))
            {
                ViewData["Error"] = "Tên sách không được để trống";
            }
            else
            {
                book.tensach = Create_name;
                book.hinh = Create_image;
                book.giaban = Create_price;
                book.ngaycapnhat = Convert.ToDateTime(Create_updateDay);
                book.soluongton = Convert.ToInt32(Create_stock);
                data.Saches.InsertOnSubmit(book);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }

        public ActionResult Delete(int id)
        {
            var Delete_book = data.Saches.First(bk => bk.masach == id);
            return View(Delete_book);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var Delete_book = data.Saches.Where(bk => bk.masach == id).First();
            data.Saches.DeleteOnSubmit(Delete_book);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }

        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
    }
}