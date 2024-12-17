using Microsoft.AspNetCore.Mvc;

namespace Hsm.Controllers
{
    public class HsmController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HsmController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.HsmModel();
            return View(data); // Asegúrate de que tienes una vista llamada "Index.cshtml"
        }
    }
}
