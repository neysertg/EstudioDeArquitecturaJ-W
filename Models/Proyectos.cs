using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio_de_Arquitectura_J_W.Models
{
    [Table ("t_proyectos")]
    public class Proyectos
    {

        public int id {get;set;}

        public string nombre{get;set;}

        public string imagen{get;set;}

        public string descripcion{get;set;}

        public double precio{get;set;}
    }
}