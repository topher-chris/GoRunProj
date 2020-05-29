using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoRunProj.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoRunProj.Controllers
{
    public class RatedSpotController : Controller
    {
        private GoRunProjContext _context;
        public RatedSpotController(GoRunProjContext context)
        {
            this._context = context;
        } //end of contructor

        //action to return a data query
        public IActionResult Index() //was not routed until i changed view folder name form ratedspotdata to ratedspot
        {
            return View("Index");
        }
        public IActionResult Data()//return a set of object that have the zone number and count how many of them
        {                           //return [{LocationName:1,numOfChoices:3],{}]
            var result = _context.Runningspot
                .Where(x => x.Choice == "yes")
                .GroupBy(x => new { group = x.LocationName }) //grouping by locationname

                .Select(group => new                //locationname: name , choice 3 
                {
                    locationName = group.Key.group, //
                    count = group.Count()  //will count within choices...how many yes and how many no's in each name
                }
            ).OrderByDescending(o => o.count).ToList();
            // return Json(result);
            var labels = result.Select(x => x.locationName).ToArray();
            var values = result.Select(x => x.count).ToArray(); //had rate
                
             var max = values[0];
             List<object> list1 = new List<object>();
             list1.Add(labels);
                 list1.Add(values);
                 list1.Add(max);
                 return Json(list1);
                }
    }//ec
}