using Microsoft.AspNetCore.Mvc;

namespace ShoeStore.Controllers
{
    public class ShoeController : Controller
    {
        private readonly ShoeStoreContext _context;

        public ShoeController(ShoeStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var shoes = _context.ShoeDetails.Include(s => s.ShoeType).ToList();
            return View(shoes);
        }
    }
}
