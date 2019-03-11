using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    using WishList.Data;
    using WishList.Models;

    public class ItemController : Controller
    {

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ApplicationDbContext _context;


        public IActionResult Index()
        {
            var items = _context.Items.ToList();
            return View("Index", items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var itemFromId = _context.Items.Find(Id);
                _context.Items.Remove(itemFromId);
                _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
