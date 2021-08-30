using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
           // string dd = DateTime.Now.ToShortDateString();
           // return Ok(dd); 
        }

        public IActionResult Deatails (int id) {
            return Ok("right id with which is {id}" + id);
        }
    }
}
