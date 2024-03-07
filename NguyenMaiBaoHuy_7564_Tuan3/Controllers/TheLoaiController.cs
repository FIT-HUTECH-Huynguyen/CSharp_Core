using NguyenMaiBaoHuy_7564_Tuan3.Models;
using System.Linq;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan3.Controllers
{
    public class TheLoaiController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();

        // GET: TheLoai
        public ActionResult Index()
        {
            var all_theloai = from tt in data.TheLoais select tt;

            return View(all_theloai);
        }

        #region detail

        public ActionResult Details(int id)
        {
            var detail_theloai = data.TheLoais.First(tl => tl.maloai == id);
            return View(detail_theloai);
        }
        #endregion

        #region create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection, TheLoai theloai)
        {
            var name = collection["tenloai"];

            if (string.IsNullOrEmpty(name))
            {
                ViewData["Error"] = "Tên thể loại không được để trống";
            }
            else
            {
                theloai.tenloai = name;
                data.TheLoais.InsertOnSubmit(theloai);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }

        #endregion

        #region edit

        public ActionResult Edit(int id)
        {
            var edit_theloai = data.TheLoais.First(tl => tl.maloai == id);
            return View(edit_theloai);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var edit_theloai = data.TheLoais.First(tl => tl.maloai == id);
            var name = collection["tenloai"];
            edit_theloai.maloai = id;
            if (string.IsNullOrEmpty(name))
            {
                ViewData["Error"] = "Tên thể loại không được để trống";
            }
            else
            {
                edit_theloai.tenloai = name;
                UpdateModel(edit_theloai);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }
        #endregion

        #region delete

        public ActionResult Delete(int id)
        {
            var delete_theloai = data.TheLoais.First(tl => tl.maloai == id);
            return View(delete_theloai);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var delete_theloai = data.TheLoais.First(tl => tl.maloai == id);
            data.TheLoais.DeleteOnSubmit(delete_theloai);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}