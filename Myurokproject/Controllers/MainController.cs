using Microsoft.AspNetCore.Mvc;
using Myurokproject.Models;
using System.Diagnostics;

namespace Myurokproject.Controllers
{ 

 
        public class MainController : Controller
        {
            public IActionResult index()
            {
                return View();
            }
        
            public IActionResult about()
        {
            return View();
        }
    }
    
}
