using NguyenMaiBaoHuy_7564_Tuan4.Models;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan4.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index(int? page, int? pageSize)
        {
            if (page == null)
            {
                page = 1;
            }

            if (pageSize == null)
            {
                pageSize = 3;
            }
            var book = data.Saches.ToList();
            int pageNumber = page ?? 1;
            return View(book.ToPagedList(pageNumber, (int)pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}