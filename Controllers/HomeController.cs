using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoModels.Models;

namespace DojoModels.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("result")]
        [HttpPost]

        public IActionResult Result(Survey blah)
        {
            if (ModelState.IsValid)
            {
                Survey Person = new Survey()
                {
                FirstName = Request.Form["FirstName"],
                Location = Request.Form["Location"],
                Language =  Request.Form["Language"],
                Comment = Request.Form["Comment"],

            };
            
            return View("result",Person); 
        } 
        else 
        { 
            return View("Index");
        }
    }


}
}
