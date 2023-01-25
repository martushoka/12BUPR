using DogWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWebApp.Controllers
{
    public class DogsController : Controller
    {
        private readonly ApplicationDbContext context;

        public DogsController(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IActionResult Create()
        {
            return this.View();
        }
    }
    
}
