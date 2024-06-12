using Application.Class;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestOnline_View.Controllers
{
    public class ClassesController : Controller
    {
        // GET: ClassesController
        private readonly IClassService _classService;
        private readonly ILogger<ClassesController> _logger;


        public ClassesController(IClassService classes, ILogger<ClassesController> logger)
        {
            _classService = classes;
            _logger = logger;
        }
        public async Task<ActionResult> Index()
        {
            var result = await _classService.GetClassById("00000000-0000-0000-0000-0000000000001");
            _logger.LogInformation("RESULT", result.ToString());
            return View(result);
        }

        // GET: ClassesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesController/Create
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

        // GET: ClassesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ClassesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
