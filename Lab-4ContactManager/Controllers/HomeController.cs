using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactList.Models;

namespace Lab_4ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext Context { get; set; }
        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = Context.Contacts
            .Include(m => m.Category)
            .OrderBy(m => m.FirstName)
            .ToList();
            return View(contacts);
        }
    }
}
