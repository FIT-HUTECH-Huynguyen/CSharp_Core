using NguyenMaiBaoHuy_7564_Tuan3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan3.Controllers
{
    public class BookController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Book
        public ActionResult Index()
        {
            var all_theloai = from sach in data.Saches select sach;

            return View(all_theloai);
        }

        public ActionResult Details(int id)
        {
            var detail_sach = data.Saches.First(sach => sach.masach == id);
            return View(detail_sach);
        }

        public ActionResult Create()
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
                    Value = value,
                });
            }
            ViewBag.listImageBook = listImageBook;

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, Sach sach)
        {
            var name = collection["tensach"];
            var category = collection["maloai"];
            var image = collection["hinh"];

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) ||
                string.IsNullOrEmpty(image))
            {
                ViewData["Error"] = "Không được để trống";
            }
            else
            {
                sach.tensach = name;
                sach.maloai = int.Parse(category);
                sach.hinh = image;
                data.Saches.InsertOnSubmit(sach);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();

        }

        public ActionResult Edit(int id)
        {
            List<SelectListItem> listCategory;

            listCategory = new List<SelectListItem>();

            foreach (var item in data.TheLoais.ToList())
            {
                listCategory.Add(new SelectListItem()
                {
                    Text = item.tenloai,
                    Value = item.maloai.ToString(),
                });
            }

            ViewBag.listCategory = listCategory;

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
                });
            }
            ViewBag.listImageBook = listImageBook;

            var edit_sach = data.Saches.Where(sach => sach.masach == id).First();
            return View(edit_sach);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection collection, int id)
        {
            var edit_sach = data.Saches.First(s => s.masach == id);
            var name = collection["tensach"];
            var category = collection["maloai"];
            var idBook = collection["masach"];
            var image = collection["hinh"];
            edit_sach.masach = id;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(idBook) ||
                string.IsNullOrEmpty(image))
            {
                ViewData["Error"] = "Không được để trống";
            }
            else
            {
                edit_sach.tensach = name;
                edit_sach.maloai = int.Parse(category);
                edit_sach.masach = int.Parse(idBook);
                edit_sach.hinh = image;
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }

        public ActionResult Delete(int id)
        {
            var delete_sach = data.Saches.First(sach => sach.masach == id);
            return View(delete_sach);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var delete_sach = data.Saches.First(sach => sach.masach == id);
            data.Saches.DeleteOnSubmit(delete_sach);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}