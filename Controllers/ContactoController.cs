using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio_de_Arquitectura_J_W.Models;
using Estudio_de_Arquitectura_J_W.Data;

namespace Estudio_de_Arquitectura_J_W.Controllers
{
    
    public class ContactoController : Controller
    {
        
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoController(ILogger<ContactoController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Contacto()   
        {
           
            ViewData["Message"] = "";
            return View();
        
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
