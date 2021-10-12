using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    public class Servicios
    {

        public int id {get;set;}

        public string foto {get;set;}

        public string descripcion{get;set;}

        public string nombre{get;set;}
    }
}