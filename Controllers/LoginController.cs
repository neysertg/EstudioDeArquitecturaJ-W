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
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ApplicationDbContext _context;


        public LoginController(ILogger<LoginController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Login objAdmin)
        {
            _context.Add(objAdmin);
            _context.SaveChanges();
            ViewData["Message"] = "El usuario se registro con exito";
            return View();
            
          
        
        }
        

    }
}
