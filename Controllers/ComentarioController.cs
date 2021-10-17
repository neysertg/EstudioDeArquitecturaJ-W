using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio_de_Arquitectura_J_W.Models;
using Estudio_de_Arquitectura_J_W.Data;

namespace appventas.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly ILogger<ComentarioController> _logger;
        private readonly ApplicationDbContext _context;


        public ComentarioController(ILogger<ComentarioController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult MostrarComentarios()
        {
            
            var listcomentarios = _context.Comentarios.ToList();
            ViewData["Message"] = "";
            return View(listcomentarios);
        }

        [HttpGet]
        public IActionResult CrearComentario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearComentario(Comentarios objComentarios)
        {
            _context.Add(objComentarios);
            _context.SaveChanges();
            objComentarios.comentario = "Subido";
            ViewData["Message"] = "El comentario ya esta " + objComentarios.comentario;
            return View();
        }

    }
}
