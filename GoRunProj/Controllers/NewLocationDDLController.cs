using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoRunProj.Models;
using GoRunProj.Data;

namespace GoRunProj.Controllers
{
    public class NewLocationDDLController : Controller
    {
        private readonly GoRunProjContext _cc;
        public NewLocationDDLController(GoRunProjContext cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewLocationDDL sc)
        {
            _cc.Add(sc);
            _cc.SaveChanges();
            ViewBag.mesage = "The Selected is Saved";
            return View();
        }
    }
}