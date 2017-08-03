using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspWebMvc.Controllers
{
    public class DBController:Controller
    {
        public IActionResult GetAll()
        {
            return View();//("GetAll");
        }
        
    }
}