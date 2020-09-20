﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContactList.Models;

namespace Lab_4ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext Context { get; set; }

        public ContactController(ContactContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = Context.Categories.OrderBy(g => g.CatName).ToList();
            return View("Edit", new Contact());
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = Context.Categories.OrderBy(g => g.CatName).ToList();
            var contact = Context.Contacts.Find(id);
            return View(contact);
        }
        [HttpGet]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                {
                    Context.Contacts.Add(contact);
                }
                else
                {
                    Context.Contacts.Update(contact);
                }
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = Context.Categories.OrderBy(g => g.CatName).ToList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = Context.Contacts.Find(id);
            return View(contact);
        }
        public IActionResult Delete(Contact contact)
        {
            Context.Contacts.Remove(contact);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
