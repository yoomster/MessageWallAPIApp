using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageWallAPI.Controllers
{
    public class MessageWallController : Controller
    {
        // GET: MessageWallController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageWallController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageWallController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
