using Microsoft.AspNetCore.Mvc;
using Myurokproject.Models;
using System.Diagnostics;

namespace Myurokproject.Controllers
{ 

 
        public class ProductController : Controller
        {
            public IActionResult index()
            {
                return View();
            }

            public IActionResult details(int id)
            {

              ViewBag.Id = id;
              if(id == 1)
              {
                 ViewBag.Name = "Notebook";
                 ViewBag.Price = 45000;
            }
              else if (id == 2)
              {
                 ViewBag.Name = "Теліфони";
                 ViewBag.Price = 25000;
            }
              else if (id == 3)
              {
                 ViewBag.Name = "naushniki";
                 ViewBag.Price = 5000;
            }
              else
              {
                 return NotFound();
              }
              return View();
             }
    }
    
}
