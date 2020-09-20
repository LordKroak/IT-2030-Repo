using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_4ContactManager.Models;
using System.Runtime.InteropServices.ComTypes;
using ContactList.Models;

namespace Lab_4ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts
            .Include(m => m.Category)
            .OrderBy(m => m.CatName)
            .ToList();
            return View(contacts);
        }
    }
}
