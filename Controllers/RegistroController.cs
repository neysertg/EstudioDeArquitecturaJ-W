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
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;
        private readonly ApplicationDbContext _context;


        public RegistroController(ILogger<RegistroController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult RegistrarAdmin()
        {            
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Registrar(Login objAdmin)
        {
            _context.Add(objAdmin);
            _context.SaveChanges();
            ViewData["Message"] = "El usuario ya esta registrado";
            return View();
        }
        
        

    }
}
