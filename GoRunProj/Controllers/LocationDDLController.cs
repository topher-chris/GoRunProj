using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoRunProj.Models;
using GoRunProj.Data;

namespace GoRunProj.Controllers
{
    public class LocationDDLController : Controller
    {
        public readonly GoRunProjContext _cc;
        public LocationDDLController(GoRunProjContext cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            List<RunningSpot> cl = new List<RunningSpot>();
            cl = (from c in _cc.Runningspot select c).ToList();
            cl.Insert(0, new RunningSpot { Id = 0, LocationName = "-- Select Location Name --" });
            ViewBag.message = cl;
            return View();
        }
    }
}