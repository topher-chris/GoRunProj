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
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}