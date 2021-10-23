using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio_de_Arquitectura_J_W.Models;
using Estudio_de_Arquitectura_J_W.Data;
using Microsoft.EntityFrameworkCore;

namespace Estudio_de_Arquitectura_J_W.Controllers
{
    public class ProyectosArealizar : Controller
    {
        private readonly ILogger<ProyectosArealizar> _logger;
        private readonly ApplicationDbContext _context;


        public ProyectosArealizar(ILogger<ProyectosArealizar> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult ProyectosRealizar()
        {            
            var proyectos = _context.Proyectos.ToList();
            ViewData["Message"] = "";
            return View(proyectos);
        }
        
        public IActionResult CrearProyectoRealizar()
        {            
            return View();
            
        }
        [HttpPost]
        public IActionResult CrearProyectoRealizar(Proyectos objProyect)
        {            
            _context.Add(objProyect);
            _context.SaveChanges();
            TempData["mensaje"] = "El proyecto se ha subido correctamente";
            return RedirectToAction("ProyectosRealizar");
            
        }

        [HttpGet]
        public IActionResult EditarProyectoRealizar(int? id )
        { 

                if(id == null || id == 0){

                    return NotFound();
            }

            var proyecto = _context.Proyectos.Find(id);

            if(proyecto == null){
                return NotFound();

            } 

            return View(proyecto);           
         }
        
        
        [HttpPost]

        public IActionResult EditarProyectoRealizar(Proyectos proyecto){

            if(ModelState.IsValid){
                _context.Proyectos.Update(proyecto);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("ProyectosRealizar");
            }
            return View ();
        }   
        
     
    }
}
