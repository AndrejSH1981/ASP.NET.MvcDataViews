using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDataViews.Models;

namespace MvcDataViews.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> people = new List<Person>();



        // GET: Person
        [HttpGet]
        public ActionResult Index()
        {
            return View(people);
        }


        // GET: Person/Details/5
        //[HttpGet]
        public ActionResult Details(Person p)
        {
            return View(p);
        }

        // GET: Person/Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", p);
                }
                people.Add(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Person/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
               
{
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);
        }

        // POST: Person/Edit/5
       
        [HttpPost]
        public ActionResult Edit(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }
            foreach (Person pn in people)
            {
                if (pn.Id == p.Id)
                {
                    pn.Name = p.Name;
                    pn.Age = p.Age;
                    pn.Id = p.Id;
                    pn.Phone = p.Phone;
                    pn.Email = p.Email;
                }
            }
      
return RedirectToAction("Edit", p);
        }


        // GET: Person/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    
                p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(Person p)
        {
            try
            {
                // TODO: Add delete logic here
                foreach (Person pn in people)
                {
                    if (pn.Id == p.Id)
                    {
                        people.Remove(pn);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        }
    }
}
