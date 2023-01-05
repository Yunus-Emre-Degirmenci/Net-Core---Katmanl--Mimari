using Directory.BLL.RepositoryPattern.Interfaces;
using Directory.DAL.Context;
using Directory.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.WebUI.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext _context;
        IPersonRepository _repoPerson;
        public HomeController(MyDbContext context, IPersonRepository repoPerson)
        {
            _repoPerson = repoPerson;
        }
        public IActionResult Directory()
        {
            List<Person> person = _repoPerson.GetActives();
            return View(person);
        }
        public IActionResult Created()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Created(Person person)
        {
            if(!ModelState.IsValid)
            {
                return View(person);
            }
            _repoPerson.Add(person);
            return RedirectToAction("Directory");
        }
        public IActionResult Edit(int id)
        {
            Person person = _repoPerson.GetById(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _repoPerson.Update(person);
            return RedirectToAction("Directory");
        }
        public IActionResult Delete(int id)
        {
            _repoPerson.Delete(id);
            return RedirectToAction("Directory");
        }
    }
}
