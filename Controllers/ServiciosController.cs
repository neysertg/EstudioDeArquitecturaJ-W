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
    public class ServiciosController : Controller
    {
        
        public IActionResult DiseñoArquitectonico(){
            return View();
        }

        public IActionResult Construccion(){
            return View();
        }

        public IActionResult Consultoria(){
            return View();
        }

        public IActionResult Saneamiento(){
            return View();
        }
        

    }
}
