using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GoRunProj.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoRunProj.Controllers
{
    public class BarChartController : Controller
    {
        private GoRunProjContext _context;

        //constructor
        public BarChartController(GoRunProjContext context)
        {
            this._context = context;

        }//end of constructor
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Data()
        {
            var result = _context.RunningSpot
                
                .GroupBy(x => new { group = x.LocationType })
                .Select(group => new
                {
                    locationType = group.Key.group,
                    count = group.Count()
                }
        ).OrderByDescending(o => o.count).ToList();
            // return Json(result);
            var labels = result.Select(x => x.locationType).ToArray();
            var values = result.Select(x => x.count).ToArray();
            var max = values[0];
            List<object> list1 = new List<object>();
            list1.Add(labels);
            list1.Add(values);
            list1.Add(max);
            return Json(list1);

        }
    }
}